using System;
using System.Threading;

namespace ConsoleNetCore11.Lectures
{
    public class A04_LockStatement
    {
        public static bool Done;
        public static readonly object locker = new object();

        public static void Run()
        {
            new Thread(GoReverse).Start();
            GoReverse();
        }

        public static void GoReverse()
        {
            lock (locker)
            {
                if (!Done)
                {
                    Console.WriteLine("Done");
                    Done = true;
                }
            }
        }

    }
}