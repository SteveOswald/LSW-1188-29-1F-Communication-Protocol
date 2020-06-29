namespace Lsw1188291fSimulator
{
    partial class frmMain
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBoxPort = new System.Windows.Forms.ComboBox();
            this.labelPort = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageDisplay = new System.Windows.Forms.TabPage();
            this.labelByte8 = new System.Windows.Forms.Label();
            this.labelByte7 = new System.Windows.Forms.Label();
            this.labelByte6 = new System.Windows.Forms.Label();
            this.numericUpDownByte5 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownByte4 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownByte3 = new System.Windows.Forms.NumericUpDown();
            this.labelByte1 = new System.Windows.Forms.Label();
            this.numericUpDownByte2 = new System.Windows.Forms.NumericUpDown();
            this.labelByte0 = new System.Windows.Forms.Label();
            this.labelFixedBytes = new System.Windows.Forms.Label();
            this.labelCurrentDisplayReceivedData = new System.Windows.Forms.Label();
            this.labelDisplayReceivedData = new System.Windows.Forms.Label();
            this.labelCurrentSentDataDisplay = new System.Windows.Forms.Label();
            this.labelSentDataDisplay = new System.Windows.Forms.Label();
            this.buttonStartStopDisplay = new System.Windows.Forms.Button();
            this.checkBoxWalkAssist = new System.Windows.Forms.CheckBox();
            this.checkBoxLights = new System.Windows.Forms.CheckBox();
            this.comboBoxPasLevel = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxPasLevels = new System.Windows.Forms.ComboBox();
            this.labelPasLevels = new System.Windows.Forms.Label();
            this.labelCalculatedSpeed = new System.Windows.Forms.Label();
            this.labelSpeed = new System.Windows.Forms.Label();
            this.textBoxPerimeterDisplay = new System.Windows.Forms.TextBox();
            this.labelPerimeterDisplay = new System.Windows.Forms.Label();
            this.tabPageController = new System.Windows.Forms.TabPage();
            this.comboBoxStatusController = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDownWattsController = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelComma = new System.Windows.Forms.Label();
            this.numericUpDownSpeedDecimalController = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownSpeedDigitController = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxPerimeterController = new System.Windows.Forms.TextBox();
            this.labelPerimeterController = new System.Windows.Forms.Label();
            this.comboBoxErrorController = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.labelReceivedDataController = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labelSentDataController = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.buttonStartStopController = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPageDisplay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownByte5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownByte4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownByte3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownByte2)).BeginInit();
            this.tabPageController.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWattsController)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSpeedDecimalController)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSpeedDigitController)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Controls.Add(this.comboBoxPort);
            this.panel1.Controls.Add(this.labelPort);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(411, 58);
            this.panel1.TabIndex = 0;
            // 
            // comboBoxPort
            // 
            this.comboBoxPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPort.FormattingEnabled = true;
            this.comboBoxPort.Location = new System.Drawing.Point(15, 25);
            this.comboBoxPort.Name = "comboBoxPort";
            this.comboBoxPort.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPort.TabIndex = 1;
            // 
            // labelPort
            // 
            this.labelPort.AutoSize = true;
            this.labelPort.Location = new System.Drawing.Point(12, 9);
            this.labelPort.Name = "labelPort";
            this.labelPort.Size = new System.Drawing.Size(58, 13);
            this.labelPort.TabIndex = 0;
            this.labelPort.Text = "Serial Port:";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageDisplay);
            this.tabControl.Controls.Add(this.tabPageController);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 58);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(411, 483);
            this.tabControl.TabIndex = 1;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // tabPageDisplay
            // 
            this.tabPageDisplay.Controls.Add(this.labelByte8);
            this.tabPageDisplay.Controls.Add(this.labelByte7);
            this.tabPageDisplay.Controls.Add(this.labelByte6);
            this.tabPageDisplay.Controls.Add(this.numericUpDownByte5);
            this.tabPageDisplay.Controls.Add(this.numericUpDownByte4);
            this.tabPageDisplay.Controls.Add(this.numericUpDownByte3);
            this.tabPageDisplay.Controls.Add(this.labelByte1);
            this.tabPageDisplay.Controls.Add(this.numericUpDownByte2);
            this.tabPageDisplay.Controls.Add(this.labelByte0);
            this.tabPageDisplay.Controls.Add(this.labelFixedBytes);
            this.tabPageDisplay.Controls.Add(this.labelCurrentDisplayReceivedData);
            this.tabPageDisplay.Controls.Add(this.labelDisplayReceivedData);
            this.tabPageDisplay.Controls.Add(this.labelCurrentSentDataDisplay);
            this.tabPageDisplay.Controls.Add(this.labelSentDataDisplay);
            this.tabPageDisplay.Controls.Add(this.buttonStartStopDisplay);
            this.tabPageDisplay.Controls.Add(this.checkBoxWalkAssist);
            this.tabPageDisplay.Controls.Add(this.checkBoxLights);
            this.tabPageDisplay.Controls.Add(this.comboBoxPasLevel);
            this.tabPageDisplay.Controls.Add(this.label1);
            this.tabPageDisplay.Controls.Add(this.comboBoxPasLevels);
            this.tabPageDisplay.Controls.Add(this.labelPasLevels);
            this.tabPageDisplay.Controls.Add(this.labelCalculatedSpeed);
            this.tabPageDisplay.Controls.Add(this.labelSpeed);
            this.tabPageDisplay.Controls.Add(this.textBoxPerimeterDisplay);
            this.tabPageDisplay.Controls.Add(this.labelPerimeterDisplay);
            this.tabPageDisplay.Location = new System.Drawing.Point(4, 22);
            this.tabPageDisplay.Name = "tabPageDisplay";
            this.tabPageDisplay.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDisplay.Size = new System.Drawing.Size(403, 457);
            this.tabPageDisplay.TabIndex = 0;
            this.tabPageDisplay.Text = "Display Simulator";
            this.tabPageDisplay.UseVisualStyleBackColor = true;
            // 
            // labelByte8
            // 
            this.labelByte8.AutoSize = true;
            this.labelByte8.Location = new System.Drawing.Point(367, 187);
            this.labelByte8.Name = "labelByte8";
            this.labelByte8.Size = new System.Drawing.Size(32, 13);
            this.labelByte8.TabIndex = 24;
            this.labelByte8.Text = "0x0D";
            this.labelByte8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelByte7
            // 
            this.labelByte7.AutoSize = true;
            this.labelByte7.Location = new System.Drawing.Point(307, 187);
            this.labelByte7.Name = "labelByte7";
            this.labelByte7.Size = new System.Drawing.Size(58, 13);
            this.labelByte7.TabIndex = 23;
            this.labelByte7.Text = "(CRC high)";
            // 
            // labelByte6
            // 
            this.labelByte6.AutoSize = true;
            this.labelByte6.Location = new System.Drawing.Point(250, 187);
            this.labelByte6.Name = "labelByte6";
            this.labelByte6.Size = new System.Drawing.Size(54, 13);
            this.labelByte6.TabIndex = 22;
            this.labelByte6.Text = "(CRC low)";
            // 
            // numericUpDownByte5
            // 
            this.numericUpDownByte5.Location = new System.Drawing.Point(205, 186);
            this.numericUpDownByte5.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDownByte5.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownByte5.Name = "numericUpDownByte5";
            this.numericUpDownByte5.Size = new System.Drawing.Size(41, 20);
            this.numericUpDownByte5.TabIndex = 21;
            this.numericUpDownByte5.Value = new decimal(new int[] {
            21,
            0,
            0,
            0});
            // 
            // numericUpDownByte4
            // 
            this.numericUpDownByte4.Location = new System.Drawing.Point(161, 186);
            this.numericUpDownByte4.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDownByte4.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownByte4.Name = "numericUpDownByte4";
            this.numericUpDownByte4.Size = new System.Drawing.Size(41, 20);
            this.numericUpDownByte4.TabIndex = 20;
            this.numericUpDownByte4.Value = new decimal(new int[] {
            27,
            0,
            0,
            0});
            // 
            // numericUpDownByte3
            // 
            this.numericUpDownByte3.Location = new System.Drawing.Point(117, 186);
            this.numericUpDownByte3.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDownByte3.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownByte3.Name = "numericUpDownByte3";
            this.numericUpDownByte3.Size = new System.Drawing.Size(41, 20);
            this.numericUpDownByte3.TabIndex = 19;
            this.numericUpDownByte3.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // labelByte1
            // 
            this.labelByte1.AutoSize = true;
            this.labelByte1.Location = new System.Drawing.Point(34, 187);
            this.labelByte1.Name = "labelByte1";
            this.labelByte1.Size = new System.Drawing.Size(34, 13);
            this.labelByte1.TabIndex = 18;
            this.labelByte1.Text = "(PAS)";
            // 
            // numericUpDownByte2
            // 
            this.numericUpDownByte2.Location = new System.Drawing.Point(73, 186);
            this.numericUpDownByte2.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDownByte2.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownByte2.Name = "numericUpDownByte2";
            this.numericUpDownByte2.Size = new System.Drawing.Size(41, 20);
            this.numericUpDownByte2.TabIndex = 17;
            this.numericUpDownByte2.Value = new decimal(new int[] {
            45,
            0,
            0,
            0});
            // 
            // labelByte0
            // 
            this.labelByte0.AutoSize = true;
            this.labelByte0.Location = new System.Drawing.Point(6, 187);
            this.labelByte0.Name = "labelByte0";
            this.labelByte0.Size = new System.Drawing.Size(30, 13);
            this.labelByte0.TabIndex = 16;
            this.labelByte0.Text = "0x55";
            // 
            // labelFixedBytes
            // 
            this.labelFixedBytes.AutoSize = true;
            this.labelFixedBytes.Location = new System.Drawing.Point(6, 171);
            this.labelFixedBytes.Name = "labelFixedBytes";
            this.labelFixedBytes.Size = new System.Drawing.Size(115, 13);
            this.labelFixedBytes.TabIndex = 15;
            this.labelFixedBytes.Text = "Fixed / Unkown Bytes:";
            // 
            // labelCurrentDisplayReceivedData
            // 
            this.labelCurrentDisplayReceivedData.AutoSize = true;
            this.labelCurrentDisplayReceivedData.Location = new System.Drawing.Point(6, 305);
            this.labelCurrentDisplayReceivedData.Name = "labelCurrentDisplayReceivedData";
            this.labelCurrentDisplayReceivedData.Size = new System.Drawing.Size(13, 13);
            this.labelCurrentDisplayReceivedData.TabIndex = 14;
            this.labelCurrentDisplayReceivedData.Text = "0";
            // 
            // labelDisplayReceivedData
            // 
            this.labelDisplayReceivedData.AutoSize = true;
            this.labelDisplayReceivedData.Location = new System.Drawing.Point(8, 292);
            this.labelDisplayReceivedData.Name = "labelDisplayReceivedData";
            this.labelDisplayReceivedData.Size = new System.Drawing.Size(82, 13);
            this.labelDisplayReceivedData.TabIndex = 13;
            this.labelDisplayReceivedData.Text = "Received Data:";
            // 
            // labelCurrentSentDataDisplay
            // 
            this.labelCurrentSentDataDisplay.AutoSize = true;
            this.labelCurrentSentDataDisplay.Location = new System.Drawing.Point(6, 275);
            this.labelCurrentSentDataDisplay.Name = "labelCurrentSentDataDisplay";
            this.labelCurrentSentDataDisplay.Size = new System.Drawing.Size(13, 13);
            this.labelCurrentSentDataDisplay.TabIndex = 12;
            this.labelCurrentSentDataDisplay.Text = "0";
            // 
            // labelSentDataDisplay
            // 
            this.labelSentDataDisplay.AutoSize = true;
            this.labelSentDataDisplay.Location = new System.Drawing.Point(6, 262);
            this.labelSentDataDisplay.Name = "labelSentDataDisplay";
            this.labelSentDataDisplay.Size = new System.Drawing.Size(58, 13);
            this.labelSentDataDisplay.TabIndex = 11;
            this.labelSentDataDisplay.Text = "Sent Data:";
            // 
            // buttonStartStopDisplay
            // 
            this.buttonStartStopDisplay.Location = new System.Drawing.Point(6, 329);
            this.buttonStartStopDisplay.Name = "buttonStartStopDisplay";
            this.buttonStartStopDisplay.Size = new System.Drawing.Size(394, 65);
            this.buttonStartStopDisplay.TabIndex = 10;
            this.buttonStartStopDisplay.Text = "Start Simulating!";
            this.buttonStartStopDisplay.UseVisualStyleBackColor = true;
            this.buttonStartStopDisplay.Click += new System.EventHandler(this.buttonStartStopDisplay_Click);
            // 
            // checkBoxWalkAssist
            // 
            this.checkBoxWalkAssist.AutoSize = true;
            this.checkBoxWalkAssist.Location = new System.Drawing.Point(201, 138);
            this.checkBoxWalkAssist.Name = "checkBoxWalkAssist";
            this.checkBoxWalkAssist.Size = new System.Drawing.Size(87, 17);
            this.checkBoxWalkAssist.TabIndex = 9;
            this.checkBoxWalkAssist.Text = "Walk-Assist?";
            this.checkBoxWalkAssist.UseVisualStyleBackColor = true;
            // 
            // checkBoxLights
            // 
            this.checkBoxLights.AutoSize = true;
            this.checkBoxLights.Location = new System.Drawing.Point(11, 138);
            this.checkBoxLights.Name = "checkBoxLights";
            this.checkBoxLights.Size = new System.Drawing.Size(60, 17);
            this.checkBoxLights.TabIndex = 8;
            this.checkBoxLights.Text = "Lights?";
            this.checkBoxLights.UseVisualStyleBackColor = true;
            // 
            // comboBoxPasLevel
            // 
            this.comboBoxPasLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPasLevel.FormattingEnabled = true;
            this.comboBoxPasLevel.Items.AddRange(new object[] {
            "3",
            "5",
            "9"});
            this.comboBoxPasLevel.Location = new System.Drawing.Point(201, 78);
            this.comboBoxPasLevel.Name = "comboBoxPasLevel";
            this.comboBoxPasLevel.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPasLevel.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(198, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Current PAS Level:";
            // 
            // comboBoxPasLevels
            // 
            this.comboBoxPasLevels.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPasLevels.FormattingEnabled = true;
            this.comboBoxPasLevels.Items.AddRange(new object[] {
            "3",
            "5",
            "9"});
            this.comboBoxPasLevels.Location = new System.Drawing.Point(11, 78);
            this.comboBoxPasLevels.Name = "comboBoxPasLevels";
            this.comboBoxPasLevels.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPasLevels.TabIndex = 5;
            this.comboBoxPasLevels.SelectedIndexChanged += new System.EventHandler(this.comboBoxPasLevels_SelectedIndexChanged);
            // 
            // labelPasLevels
            // 
            this.labelPasLevels.AutoSize = true;
            this.labelPasLevels.Location = new System.Drawing.Point(8, 62);
            this.labelPasLevels.Name = "labelPasLevels";
            this.labelPasLevels.Size = new System.Drawing.Size(65, 13);
            this.labelPasLevels.TabIndex = 4;
            this.labelPasLevels.Text = "PAS Levels:";
            // 
            // labelCalculatedSpeed
            // 
            this.labelCalculatedSpeed.AutoSize = true;
            this.labelCalculatedSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCalculatedSpeed.Location = new System.Drawing.Point(197, 19);
            this.labelCalculatedSpeed.Name = "labelCalculatedSpeed";
            this.labelCalculatedSpeed.Size = new System.Drawing.Size(91, 24);
            this.labelCalculatedSpeed.TabIndex = 3;
            this.labelCalculatedSpeed.Text = "0,00 km/h";
            // 
            // labelSpeed
            // 
            this.labelSpeed.AutoSize = true;
            this.labelSpeed.Location = new System.Drawing.Point(198, 3);
            this.labelSpeed.Name = "labelSpeed";
            this.labelSpeed.Size = new System.Drawing.Size(41, 13);
            this.labelSpeed.TabIndex = 2;
            this.labelSpeed.Text = "Speed:";
            // 
            // textBoxPerimeterDisplay
            // 
            this.textBoxPerimeterDisplay.Location = new System.Drawing.Point(11, 19);
            this.textBoxPerimeterDisplay.Name = "textBoxPerimeterDisplay";
            this.textBoxPerimeterDisplay.Size = new System.Drawing.Size(121, 20);
            this.textBoxPerimeterDisplay.TabIndex = 1;
            // 
            // labelPerimeterDisplay
            // 
            this.labelPerimeterDisplay.AutoSize = true;
            this.labelPerimeterDisplay.Location = new System.Drawing.Point(8, 3);
            this.labelPerimeterDisplay.Name = "labelPerimeterDisplay";
            this.labelPerimeterDisplay.Size = new System.Drawing.Size(124, 13);
            this.labelPerimeterDisplay.TabIndex = 0;
            this.labelPerimeterDisplay.Text = "Wheel Perimeter (in mm):";
            // 
            // tabPageController
            // 
            this.tabPageController.Controls.Add(this.labelReceivedDataController);
            this.tabPageController.Controls.Add(this.label8);
            this.tabPageController.Controls.Add(this.labelSentDataController);
            this.tabPageController.Controls.Add(this.label10);
            this.tabPageController.Controls.Add(this.buttonStartStopController);
            this.tabPageController.Controls.Add(this.comboBoxErrorController);
            this.tabPageController.Controls.Add(this.label6);
            this.tabPageController.Controls.Add(this.comboBoxStatusController);
            this.tabPageController.Controls.Add(this.label5);
            this.tabPageController.Controls.Add(this.numericUpDownWattsController);
            this.tabPageController.Controls.Add(this.label4);
            this.tabPageController.Controls.Add(this.label2);
            this.tabPageController.Controls.Add(this.labelComma);
            this.tabPageController.Controls.Add(this.numericUpDownSpeedDecimalController);
            this.tabPageController.Controls.Add(this.numericUpDownSpeedDigitController);
            this.tabPageController.Controls.Add(this.label3);
            this.tabPageController.Controls.Add(this.textBoxPerimeterController);
            this.tabPageController.Controls.Add(this.labelPerimeterController);
            this.tabPageController.Location = new System.Drawing.Point(4, 22);
            this.tabPageController.Name = "tabPageController";
            this.tabPageController.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageController.Size = new System.Drawing.Size(403, 457);
            this.tabPageController.TabIndex = 1;
            this.tabPageController.Text = "Controller Simulator";
            this.tabPageController.UseVisualStyleBackColor = true;
            // 
            // comboBoxStatusController
            // 
            this.comboBoxStatusController.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStatusController.FormattingEnabled = true;
            this.comboBoxStatusController.Items.AddRange(new object[] {
            "0x02 - Ready",
            "0x03 - Brakes are pulled",
            "0x04 - Motor running"});
            this.comboBoxStatusController.Location = new System.Drawing.Point(201, 71);
            this.comboBoxStatusController.Name = "comboBoxStatusController";
            this.comboBoxStatusController.Size = new System.Drawing.Size(121, 21);
            this.comboBoxStatusController.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(198, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Status:";
            // 
            // numericUpDownWattsController
            // 
            this.numericUpDownWattsController.Location = new System.Drawing.Point(11, 70);
            this.numericUpDownWattsController.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDownWattsController.Maximum = new decimal(new int[] {
            2500,
            0,
            0,
            0});
            this.numericUpDownWattsController.Name = "numericUpDownWattsController";
            this.numericUpDownWattsController.Size = new System.Drawing.Size(121, 20);
            this.numericUpDownWattsController.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Watts:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(307, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 24);
            this.label2.TabIndex = 21;
            this.label2.Text = "km / h";
            // 
            // labelComma
            // 
            this.labelComma.AutoSize = true;
            this.labelComma.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelComma.Location = new System.Drawing.Point(244, 15);
            this.labelComma.Name = "labelComma";
            this.labelComma.Size = new System.Drawing.Size(16, 24);
            this.labelComma.TabIndex = 20;
            this.labelComma.Text = ",";
            // 
            // numericUpDownSpeedDecimalController
            // 
            this.numericUpDownSpeedDecimalController.Location = new System.Drawing.Point(261, 19);
            this.numericUpDownSpeedDecimalController.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDownSpeedDecimalController.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.numericUpDownSpeedDecimalController.Name = "numericUpDownSpeedDecimalController";
            this.numericUpDownSpeedDecimalController.Size = new System.Drawing.Size(41, 20);
            this.numericUpDownSpeedDecimalController.TabIndex = 19;
            // 
            // numericUpDownSpeedDigitController
            // 
            this.numericUpDownSpeedDigitController.Location = new System.Drawing.Point(201, 19);
            this.numericUpDownSpeedDigitController.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDownSpeedDigitController.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.numericUpDownSpeedDigitController.Name = "numericUpDownSpeedDigitController";
            this.numericUpDownSpeedDigitController.Size = new System.Drawing.Size(41, 20);
            this.numericUpDownSpeedDigitController.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(198, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Speed:";
            // 
            // textBoxPerimeterController
            // 
            this.textBoxPerimeterController.Location = new System.Drawing.Point(11, 19);
            this.textBoxPerimeterController.Name = "textBoxPerimeterController";
            this.textBoxPerimeterController.Size = new System.Drawing.Size(121, 20);
            this.textBoxPerimeterController.TabIndex = 5;
            // 
            // labelPerimeterController
            // 
            this.labelPerimeterController.AutoSize = true;
            this.labelPerimeterController.Location = new System.Drawing.Point(8, 3);
            this.labelPerimeterController.Name = "labelPerimeterController";
            this.labelPerimeterController.Size = new System.Drawing.Size(124, 13);
            this.labelPerimeterController.TabIndex = 4;
            this.labelPerimeterController.Text = "Wheel Perimeter (in mm):";
            // 
            // comboBoxErrorController
            // 
            this.comboBoxErrorController.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxErrorController.FormattingEnabled = true;
            this.comboBoxErrorController.Items.AddRange(new object[] {
            "0x00 - No Error",
            "0x01 - Communication Error"});
            this.comboBoxErrorController.Location = new System.Drawing.Point(11, 129);
            this.comboBoxErrorController.Name = "comboBoxErrorController";
            this.comboBoxErrorController.Size = new System.Drawing.Size(121, 21);
            this.comboBoxErrorController.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Error:";
            // 
            // labelReceivedDataController
            // 
            this.labelReceivedDataController.AutoSize = true;
            this.labelReceivedDataController.Location = new System.Drawing.Point(6, 241);
            this.labelReceivedDataController.Name = "labelReceivedDataController";
            this.labelReceivedDataController.Size = new System.Drawing.Size(13, 13);
            this.labelReceivedDataController.TabIndex = 32;
            this.labelReceivedDataController.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 228);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 13);
            this.label8.TabIndex = 31;
            this.label8.Text = "Received Data:";
            // 
            // labelSentDataController
            // 
            this.labelSentDataController.AutoSize = true;
            this.labelSentDataController.Location = new System.Drawing.Point(6, 211);
            this.labelSentDataController.Name = "labelSentDataController";
            this.labelSentDataController.Size = new System.Drawing.Size(13, 13);
            this.labelSentDataController.TabIndex = 30;
            this.labelSentDataController.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 198);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 13);
            this.label10.TabIndex = 29;
            this.label10.Text = "Sent Data:";
            // 
            // buttonStartStopController
            // 
            this.buttonStartStopController.Location = new System.Drawing.Point(6, 265);
            this.buttonStartStopController.Name = "buttonStartStopController";
            this.buttonStartStopController.Size = new System.Drawing.Size(394, 65);
            this.buttonStartStopController.TabIndex = 28;
            this.buttonStartStopController.Text = "Start Simulating!";
            this.buttonStartStopController.UseVisualStyleBackColor = true;
            this.buttonStartStopController.Click += new System.EventHandler(this.buttonStartStopController_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 541);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.panel1);
            this.Name = "frmMain";
            this.Text = "LSW1188-29-1F Simulator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabPageDisplay.ResumeLayout(false);
            this.tabPageDisplay.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownByte5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownByte4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownByte3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownByte2)).EndInit();
            this.tabPageController.ResumeLayout(false);
            this.tabPageController.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWattsController)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSpeedDecimalController)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSpeedDigitController)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBoxPort;
        private System.Windows.Forms.Label labelPort;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageDisplay;
        private System.Windows.Forms.TabPage tabPageController;
        private System.Windows.Forms.ComboBox comboBoxPasLevels;
        private System.Windows.Forms.Label labelPasLevels;
        private System.Windows.Forms.Label labelCalculatedSpeed;
        private System.Windows.Forms.Label labelSpeed;
        private System.Windows.Forms.TextBox textBoxPerimeterDisplay;
        private System.Windows.Forms.Label labelPerimeterDisplay;
        private System.Windows.Forms.ComboBox comboBoxPasLevel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonStartStopDisplay;
        private System.Windows.Forms.CheckBox checkBoxWalkAssist;
        private System.Windows.Forms.CheckBox checkBoxLights;
        private System.Windows.Forms.Label labelCurrentSentDataDisplay;
        private System.Windows.Forms.Label labelSentDataDisplay;
        private System.Windows.Forms.Label labelCurrentDisplayReceivedData;
        private System.Windows.Forms.Label labelDisplayReceivedData;
        private System.Windows.Forms.NumericUpDown numericUpDownByte2;
        private System.Windows.Forms.Label labelByte0;
        private System.Windows.Forms.Label labelFixedBytes;
        private System.Windows.Forms.Label labelByte1;
        private System.Windows.Forms.NumericUpDown numericUpDownByte5;
        private System.Windows.Forms.NumericUpDown numericUpDownByte4;
        private System.Windows.Forms.NumericUpDown numericUpDownByte3;
        private System.Windows.Forms.Label labelByte7;
        private System.Windows.Forms.Label labelByte6;
        private System.Windows.Forms.Label labelByte8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxPerimeterController;
        private System.Windows.Forms.Label labelPerimeterController;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelComma;
        private System.Windows.Forms.NumericUpDown numericUpDownSpeedDecimalController;
        private System.Windows.Forms.NumericUpDown numericUpDownSpeedDigitController;
        private System.Windows.Forms.NumericUpDown numericUpDownWattsController;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxStatusController;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelReceivedDataController;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelSentDataController;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button buttonStartStopController;
        private System.Windows.Forms.ComboBox comboBoxErrorController;
        private System.Windows.Forms.Label label6;
    }
}

