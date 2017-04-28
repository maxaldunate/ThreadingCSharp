using System;
using System.Threading;

namespace ConsoleNetCore11.Lectures
{
    public static class A02_Cycles
    {
        public static void Run()
        {
            new Thread(Go).Start();
            Go();
        }

        private static void Go()
        {
            for (int cycles = 1; cycles <= 15; cycles++) Console.Write(cycles.ToString() + ' ');
        }
    }
}