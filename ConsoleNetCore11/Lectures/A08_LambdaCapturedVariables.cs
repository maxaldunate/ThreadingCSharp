using System;
using System.Threading;

namespace ConsoleNetCore11.Lectures
{
    public class A08_LambdaCapturedVariables
    {

        public static void Run()
        {
            //Repeated i numbers ... why?
            for (int i = 0; i < 10; i++)
                new Thread(() => Console.Write(i)).Start();

            Thread.Sleep(1000);
            Console.WriteLine();
            Console.WriteLine();

            for (int i = 0; i < 10; i++)
            {
                var temp = i;
                new Thread(() => Console.Write(temp)).Start();
            }

            Thread.Sleep(1000);
            Console.WriteLine();
            Console.WriteLine();

            for (int i = 0; i < 10; i++)
            {
                var temp2 = i;
                new Thread(() => {
                    Thread.Sleep(TimeSpan.FromMilliseconds(200));
                    Console.Write(temp2);
                }).Start();
            }


        }
    }
}