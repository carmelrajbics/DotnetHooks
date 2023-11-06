using System.Diagnostics;
using System;
using System.Diagnostics;
using System.Threading;

namespace HookProxy
{
    public class MatrixCollector
    {
        public MatrixCollector()
        {
            new Thread(MetricsPoller)
            {
                IsBackground = true,
                Name = "Collector"
            }.Start();
        }

        private static void MetricsPoller()
        {
            while (true)
            {
                var gen0 = GC.CollectionCount(0);
                var gen1 = GC.CollectionCount(1);
                var gen2 = GC.CollectionCount(2);

                Console.WriteLine($"Gen0: {gen0}");
                Console.WriteLine($"Gen1: {gen1}");
                Console.WriteLine($"Gen2: {gen2}");

                TimeSpan totalProcessorTime = Process.GetCurrentProcess().TotalProcessorTime;
                // Calculate the CPU usage.
                double cpuUsage = (totalProcessorTime.TotalMilliseconds / Environment.TickCount) * 100;
                Console.WriteLine($"CPU usage: {cpuUsage:F2}%");

                Thread.Sleep(2000);
            }
        }
    }

}
