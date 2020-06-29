using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lsw1188291fSimulator
{
    internal static class Common
    {
        public static void Clear<T>(this ConcurrentQueue<T> pQueue)
        {
            while (pQueue.TryDequeue(out T tmpItem))
            { }
        }
    }
}
