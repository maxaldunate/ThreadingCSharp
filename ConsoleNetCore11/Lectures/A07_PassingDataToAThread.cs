using System;
using System.Threading;

namespace ConsoleNetCore11.Lectures
{
    public class A07_PassingDataToAThread
    {

        public static void Run()
        {
            Console.WriteLine("Thread ended!");
        }

        public static void Go()
        {
            Console.WriteLine("hello!");
        }

    }
}