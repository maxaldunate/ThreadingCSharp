using System;
using System.Threading;

namespace ConsoleNetCore11.Lectures
{
    public class A07_PassingDataToAThread
    {

        public static void Run()
        {
            //Using multi lambda
            new Thread(() =>
            {
                Console.WriteLine("I'm running on another thread!");
                Console.WriteLine("This is so easy!");
            }).Start();

            //Sending a string
            Thread t = new Thread(() => Print("Hello from string!"));
            t.Start();

            //Sending an object
            Thread t2 = new Thread(PrintObj);
            t2.Start("Hello from object!");
        }

        public static void Print(string message)
        {
            Console.WriteLine(message);
        }

        public static void PrintObj(object messageObj)
        {
            string message = (string)messageObj;   // We need to cast here
            Console.WriteLine(message);
        }
    }
}