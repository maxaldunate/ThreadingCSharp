using System.Diagnostics;
using System.Threading;

namespace ConsoleNetCore11.Lectures
{
    public class A12_ThreadPriority
    {
        enum ThreadPriority { Lowest, BelowNormal, Normal, AboveNormal, Highest }

        public static void Run()
        {
            using (Process p = Process.GetCurrentProcess())
                p.PriorityClass = ProcessPriorityClass.High;
            //ProcessPriorityClass.RealTime
        }
    }
}