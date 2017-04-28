using System;
using System.Threading;

namespace ConsoleNetCore11.Lectures
{
    public class A05_JoinandSleep
    {
        public static void Run()
        {
            var t = new Thread(Go);
            t.Start();
            t.Join();
            //t.Join(70);
            Console.WriteLine("Thread ended!");
        }

        public static void Go()
        {
            for (int i = 0; i < 1000; i++) Console.Write("y");
            //Thread.Sleep(TimeSpan.FromHours(1));
            //Thread.Sleep(1000);
            //Thread.Sleep(0); //will interrupt the current thread to allow other threads to do work
            //Thread.Yield() in .net fw 4; //will interrupt the current thread to allow other threads to do work
        }

    }
}