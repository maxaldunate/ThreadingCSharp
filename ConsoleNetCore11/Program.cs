using System;
using System.Threading;
using ConsoleNetCore11.Lectures;

namespace ConsoleNetCore11
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //A01_GettingStarted.Run();
            //A02_Cycles.Run();
            //A03_SharedByInstances.Run();
            //A03_SharedByStatics.Run();
            //A04_LockStatement.Run();
            //A05_JoinandSleep.Run();
            //A06_Delegates.Run();
            //A07_PassingDataToAThread.Run();
            //A08_LambdaCapturedVariables.Run();
            A09_CapturedVariables.Run();

            Thread.Sleep(500);
            Console.ReadKey();
        }

    }
}