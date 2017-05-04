using System;
using System.Threading;

namespace ConsoleNetCore11.Lectures
{
    public class A10_NamingThreads
    {
        public static void Run()
        {
            Thread.CurrentThread.Name = "main";
            Thread worker = new Thread(Go);
            worker.Name = "worker";
            Thread worker2 = new Thread(Go);
            worker2.Name = "worker2";

            worker.Start();
            worker2.Start();
        }

        private static void Go()
        {
            Console.WriteLine("Hello from " + Thread.CurrentThread.Name);
        }
    }
}