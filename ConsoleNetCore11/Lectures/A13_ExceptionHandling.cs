using System;
using System.Threading;

namespace ConsoleNetCore11.Lectures
{
    public class A13_ExceptionHandling
    {
        public static void Run()
        {
            try
            {
                new Thread(Go).Start();
            }
            catch (Exception)
            {
                Console.WriteLine("Exception!");
            }


            new Thread(Go2).Start();

        }

        private static void Go() {
            throw null;
        }

        private static void Go2()
        {
            try
            {
                throw null;
            }
            catch (Exception)
            {
                Console.WriteLine("Exception on thread!");
            }
        }

    }
}