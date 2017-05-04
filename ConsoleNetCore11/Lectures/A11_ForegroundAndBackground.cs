using System;
using System.Threading;

namespace ConsoleNetCore11.Lectures
{
    public class A11_ForegroundAndBackground
    {
        public static void Run()
        {
            //Once all foreground threads finish, the application ends, 
            //and any background threads still running abruptly terminate.

            //Waiting read line
            Worker(false);
            //No wait read line
            Worker(true);

        }

        private static void Worker(bool background)
        {
            var worker = new Thread(() => Console.ReadLine());
            if (background) worker.IsBackground = true;
            worker.Start();
        }
    }
}