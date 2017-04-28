using System;
using System.Threading;

namespace ConsoleNetCore11.Lectures
{
    public class A03_SharedByStatics
    {
        public static bool Done;

        public static void Run()
        {
            new Thread(Go).Start();
            Go();

            Console.WriteLine();
            Done = false;

            new Thread(GoReverse).Start();
            GoReverse();

        }

        public static void Go()
        {
            if (!Done)
            {
                Done = true;
                Console.WriteLine("Done");
            }
        }

        public static void GoReverse()
        {
            if (!Done)
            {
                Console.WriteLine("Done");
                Done = true;
            }
        }

    }
}