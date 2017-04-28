using System;
using System.Threading;

namespace ConsoleNetCore11.Lectures
{
    //public delegate void ThreadStart();

    public class A06_Delegates
    {

        public static void Run()
        {
            var t = new Thread(new ThreadStart(Go));
            t.Start();

            var u = new Thread(Go);    // No need to explicitly use ThreadStart
            u.Start();

            var v = new Thread(() => Console.WriteLine("Hello!"));
            v.Start();

            Go();

            Console.WriteLine("Thread ended!");
        }

        public static void Go()
        {
            Console.WriteLine("hello!");
        }

    }
}