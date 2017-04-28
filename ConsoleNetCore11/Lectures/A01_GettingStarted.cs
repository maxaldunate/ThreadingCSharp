using System;
using System.Threading;

namespace ConsoleNetCore11.Lectures
{
    public static class A01_GettingStarted
    {
        public static void Run()
        {
            Thread t = new Thread(WriteY);
            t.Start();
            for (int i = 0; i < 1000; i++) Console.Write("x");
        }

        private static void WriteY()
        {
            for (int i = 0; i < 1000; i++) Console.Write("y");
        }
    }
}