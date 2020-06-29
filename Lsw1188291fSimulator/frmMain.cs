using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lsw1188291fSimulator
{
    public partial class frmMain : Form
    {
        private bool _displayRunning = false;
        private bool _controllerRunning = false;

        private SerialPort _serialPort;

        private Thread _displayRxThread;
        private Thread _displayTxThread;

        private Thread _controllerRxThread;
        private Thread _controllerTxThread;

        public frmMain()
        {
            InitializeComponent();
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            _displayRunning = false;
            _controllerRunning = false;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            foreach (string tmpPortName in SerialPort.GetPortNames())
            {
                comboBoxPort.Items.Add(tmpPortName);
            }

            if (comboBoxPort.Items.Count > 0)
            {
                comboBoxPort.SelectedIndex = 0;
            }

            comboBoxPasLevels.SelectedIndex = 0;

            comboBoxErrorController.SelectedIndex = 0;
            comboBoxStatusController.SelectedIndex = 0;

            _displayRxThread = new Thread(DisplayRx);
            _displayTxThread = new Thread(DisplayTx);

            _controllerRxThread = new Thread(ControllerRx);
            _controllerTxThread = new Thread(ControllerTx);
        }

        #region Display
        private void comboBoxPasLevels_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxPasLevel.Items.Clear();

            int levels = 0;

            switch (comboBoxPasLevels.SelectedIndex)
            {
                case 0:
                    levels = 3;
                    break;
                case 1:
                    levels = 5;
                    break;
                case 2:
                    levels = 9;
                    break;
            }

            for (int i = 0; i <= levels; i++)
            {
                comboBoxPasLevel.Items.Add(i.ToString());
            }

            if (comboBoxPasLevel.Items.Count > 0)
            {
                comboBoxPasLevel.SelectedIndex = 0;
            }
        }

        private void buttonStartStopDisplay_Click(object sender, EventArgs e)
        {
            if (buttonStartStopDisplay.Text.StartsWith("Start"))
            {
                buttonStartStopDisplay.Text = "Stop Simulating!";

                if (_serialPort != null)
                {
                    _serialPort.Close();
                    _serialPort.Dispose();
                    _serialPort = null;
                }

                _serialPort = new SerialPort(comboBoxPort.Text, 9600, Parity.None, 8, StopBits.One);

                _serialPort.Open();
                _displayRunning = true;

                if (_displayRxThread.ThreadState == System.Threading.ThreadState.Unstarted)
                {
                    _displayRxThread.Start();
                }

                if (_displayTxThread.ThreadState == System.Threading.ThreadState.Unstarted)
                {
                    _displayTxThread.Start();
                }
            }
            else
            {
                _displayRunning = false;

                buttonStartStopDisplay.Text = "Start Simulating!";
            }
        }

        private void DisplayTx()
        {
            while(true)
            {
                Thread.Sleep(100);

                if (_displayRunning)
                {
                    List<byte> dataToSend = new List<byte>();

                    dataToSend.Add(0x55); // Start byte

                    byte pasLevel = GetPasLevel();
                    if (checkBoxLights.Checked)
                    {
                        pasLevel = (byte)(pasLevel | 0x10);
                    }

                    dataToSend.Add(pasLevel); // PAS Level

                    dataToSend.Add((byte)GetNumbericUpDownValue(numericUpDownByte2)); // ??
                    dataToSend.Add((byte)GetNumbericUpDownValue(numericUpDownByte3)); // ??
                    dataToSend.Add((byte)GetNumbericUpDownValue(numericUpDownByte4)); // ??
                    dataToSend.Add((byte)GetNumbericUpDownValue(numericUpDownByte5)); // ??

                    int Crc = CalcCrc(dataToSend);

                    dataToSend.Add(GetLowByte(Crc));
                    dataToSend.Add(GetHighByte(Crc));

                    dataToSend.Add(0x0D); // Return

                    SetText(labelCurrentSentDataDisplay, BitConverter.ToString(dataToSend.ToArray()).Replace("-", " "));

                    _serialPort.Write(dataToSend.ToArray(), 0, dataToSend.Count);
                }
            }
        }

        private void DisplayRx()
        {
            List<byte> currentBytes = new List<byte>();

            Stopwatch lastValidRotationTimeStopwatch = new Stopwatch();
            int lastValidRotationTime = 0;

            while(true)
            {
                if (_displayRunning)
                {
                    try
                    {
                        int currentByte = _serialPort.ReadByte();

                        if (currentBytes.Count != 0)
                        {
                            currentBytes.Add((byte)currentByte);

                            if (currentByte == 0x0D && currentBytes.Count > 8)
                            {
                                SetText(labelCurrentDisplayReceivedData, BitConverter.ToString(currentBytes.ToArray()).Replace("-", " "));

                                int rotationTime = 0;

                                rotationTime = currentBytes[3] << 8;
                                rotationTime = rotationTime | currentBytes[2];

                                if (rotationTime > 0)
                                {
                                    lastValidRotationTimeStopwatch.Reset();
                                    lastValidRotationTimeStopwatch.Start();

                                    lastValidRotationTime = rotationTime;

                                    double wheelPerimeter = 0;

                                    if (!double.TryParse(GetText(this.textBoxPerimeterDisplay), out wheelPerimeter))
                                    {
                                        SetText(textBoxPerimeterDisplay, "2150");
                                        wheelPerimeter = 2150;
                                    }

                                    double speed = (double)wheelPerimeter / (double)rotationTime * 3.6;
                                    SetText(labelCalculatedSpeed, Math.Round(speed, 2).ToString().Replace(".", ",") + " km/h");
                                }
                                else
                                {
                                    if (lastValidRotationTimeStopwatch.IsRunning && lastValidRotationTimeStopwatch.ElapsedMilliseconds > lastValidRotationTime + 1500)
                                    {
                                        lastValidRotationTimeStopwatch.Reset();

                                        SetText(labelCalculatedSpeed, Math.Round((double)0, 2).ToString().Replace(".", ",") + " km/h");
                                    }
                                }

                                currentBytes.Clear();
                            }
                        }
                        else if (currentByte == 0x55)
                        {
                            currentBytes.Add((byte)currentByte);
                        }
                    }
                    catch
                    { }
                }
            }
        }

        private byte GetPasLevel()
        {
            if (checkBoxWalkAssist.Checked)
            {
                return 0x0F;
            }

            int currentLevel = Convert.ToInt32(GetText(comboBoxPasLevel));

            if (currentLevel == 0)
            {
                return 0;
            }

            switch (GetText(comboBoxPasLevels))
            {
                case "3":
                    return (byte)(currentLevel * 3);
                case "5":
                    return (byte)((currentLevel * 2) - 1);
                case "9":
                    return (byte)(currentLevel);
            }

            return 0;
        }
        #endregion

        #region Controller

        private ConcurrentQueue<byte> _controllerTxBytes = new ConcurrentQueue<byte>();

        private void buttonStartStopController_Click(object sender, EventArgs e)
        {
            if (buttonStartStopController.Text.StartsWith("Start"))
            {
                buttonStartStopController.Text = "Stop Simulating!";

                if (_serialPort != null)
                {
                    _serialPort.Close();
                    _serialPort.Dispose();
                    _serialPort = null;
                }

                _serialPort = new SerialPort(comboBoxPort.Text, 9600, Parity.None, 8, StopBits.One);

                _serialPort.Open();
                _controllerRunning = true;

                if (_controllerRxThread.ThreadState == System.Threading.ThreadState.Unstarted)
                {
                    _controllerRxThread.Start();
                }

                if (_controllerTxThread.ThreadState == System.Threading.ThreadState.Unstarted)
                {
                    _controllerTxThread.Start();
                }
            }
            else
            {
                _controllerRunning = false;

                buttonStartStopController.Text = "Start Simulating!";
            }
        }

        private void ControllerTx()
        {
            while (true)
            {
                try
                {
                    if (_controllerRunning && _controllerTxBytes != null && !_controllerTxBytes.IsEmpty)
                    {
                        if (_controllerTxBytes.TryDequeue(out byte tmpByte))
                        {
                            _serialPort.Write(new byte[] { tmpByte }, 0, 1);
                        }
                    }
                }
                catch
                { }
            }
        }

        private void ControllerRx()
        {
            List<byte> currentBytes = new List<byte>();

            Stopwatch lastRequestTimeStopwatch = new Stopwatch();

            while (true)
            {
                if (_controllerRunning)
                {
                    try
                    {
                        int currentByte = _serialPort.ReadByte();

                        if (currentBytes.Count != 0)
                        {
                            currentBytes.Add((byte)currentByte);

                            if (currentByte == 0x0D)
                            {
                                lastRequestTimeStopwatch.Stop();

                                SetText(labelReceivedDataController, BitConverter.ToString(currentBytes.ToArray()).Replace("-", " "));

                                _controllerTxBytes.Clear();

                                List<byte> CrcCalculation = new List<byte>();

                                _controllerTxBytes.Enqueue(0x55);
                                CrcCalculation.Add(0x55);

                                int watts = GetNumbericUpDownValue(numericUpDownWattsController);
                                watts = Convert.ToInt32(Math.Round(watts / (double)10));
                                watts = watts % 0xFF;

                                _controllerTxBytes.Enqueue((byte)watts);
                                CrcCalculation.Add((byte)watts);

                                double speed = Convert.ToDouble(GetNumbericUpDownValue(numericUpDownSpeedDigitController).ToString() + "." + GetNumbericUpDownValue(numericUpDownSpeedDecimalController), CultureInfo.InvariantCulture);

                                double wheelPerimeter = 0;

                                if (!double.TryParse(GetText(textBoxPerimeterController), out wheelPerimeter))
                                {
                                    SetText(textBoxPerimeterController, "2150");
                                    wheelPerimeter = 2150;
                                }

                                double rotationTime = 0;

                                if (speed > 0)
                                {
                                    rotationTime = Math.Round(3.6 * wheelPerimeter / speed);
                                }

                                if (lastRequestTimeStopwatch.ElapsedMilliseconds != 0 && rotationTime <= lastRequestTimeStopwatch.ElapsedMilliseconds)
                                {
                                    lastRequestTimeStopwatch.Reset();

                                    _controllerTxBytes.Enqueue(GetLowByte(Convert.ToInt32(rotationTime)));
                                    _controllerTxBytes.Enqueue(GetHighByte(Convert.ToInt32(rotationTime)));

                                    CrcCalculation.Add(GetLowByte(Convert.ToInt32(rotationTime)));
                                    CrcCalculation.Add(GetHighByte(Convert.ToInt32(rotationTime)));
                                }
                                else
                                {
                                    _controllerTxBytes.Enqueue(0x00);
                                    _controllerTxBytes.Enqueue(0x00);

                                    CrcCalculation.Add(0x00);
                                    CrcCalculation.Add(0x00);
                                }

                                _controllerTxBytes.Enqueue(Convert.ToByte(GetText(comboBoxErrorController).Substring(2, 2), 16));
                                CrcCalculation.Add(Convert.ToByte(GetText(comboBoxErrorController).Substring(2, 2), 16));

                                _controllerTxBytes.Enqueue(Convert.ToByte(GetText(comboBoxStatusController).Substring(2, 2), 16));
                                CrcCalculation.Add(Convert.ToByte(GetText(comboBoxStatusController).Substring(2, 2), 16));

                                _controllerTxBytes.Enqueue(0x00);
                                _controllerTxBytes.Enqueue(0x00);
                                _controllerTxBytes.Enqueue(0x00);
                                _controllerTxBytes.Enqueue(0x00);

                                CrcCalculation.Add(0x00);
                                CrcCalculation.Add(0x00);
                                CrcCalculation.Add(0x00);
                                CrcCalculation.Add(0x00);

                                int Crc = CalcCrc(CrcCalculation);

                                _controllerTxBytes.Enqueue(GetLowByte(Crc));
                                _controllerTxBytes.Enqueue(GetHighByte(Crc));

                                CrcCalculation.Add(GetLowByte(Crc));
                                CrcCalculation.Add(GetHighByte(Crc));

                                _controllerTxBytes.Enqueue(0x0D);

                                CrcCalculation.Add(0x0D);

                                SetText(labelSentDataController, BitConverter.ToString(CrcCalculation.ToArray()).Replace("-", " "));

                                currentBytes.Clear();
                                lastRequestTimeStopwatch.Start();
                            }
                        }
                        else if (currentByte == 0x55)
                        {
                            currentBytes.Add((byte)currentByte);
                        }
                    }
                    catch (Exception ex)
                    { }
                }
            }
        }

        #endregion


        private int CalcCrc(List<byte> pBytes)
        {
            int Crc = 0;

            for (int x = 0; x < pBytes.Count; x = x + 2)
            {
                Crc = Crc + FromHighByteLowByte(pBytes[x + 1], pBytes[x]);
            }

            return Crc;
        }

        private string GetText(Control pControl)
        {
            if (pControl.InvokeRequired)
            {
                return (string)pControl.Invoke(new Func<string>(() =>
                {
                    return pControl.Text;
                }));
            }

            return pControl.Text;
        }

        private void SetText(Control pControl, string pValue)
        {
            if (pControl.InvokeRequired)
            {
                pControl.Invoke(new Action(() =>
                {
                    pControl.Text = pValue;
                }));

                return;
            }

            pControl.Text = pValue;
        }

        private int GetNumbericUpDownValue(NumericUpDown pControl)
        {
            if (pControl.InvokeRequired)
            {
                return (int)pControl.Invoke(new Func<int>(() =>
                {
                    return Convert.ToInt32(pControl.Value);
                }));
            }

            return Convert.ToInt32(pControl.Value);
        }

        private int FromHighByteLowByte(byte pHightByte, byte pLowByte)
        {
            int Output = pHightByte << 8;
            Output = Output | pLowByte;

            return Output;
        }

        private byte GetLowByte(int pValue)
        {
            return (byte)(pValue & 0xFF);
        }

        private byte GetHighByte(int pValue)
        {
            return (byte)(pValue >> 8);
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            _displayRunning = false;

            _displayRxThread.Abort();
            _displayTxThread.Abort();

            _controllerRunning = false;

            _controllerRxThread.Abort();
            _controllerTxThread.Abort();
        }
    }
}
