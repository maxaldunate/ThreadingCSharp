using System;
using System.Threading;

namespace ConsoleNetCore11.Lectures
{
    public class A03_SharedByInstances
    {
        private bool _done;

        public static void Run()
        {
            var tt = new A03_SharedByInstances();
            new Thread(tt.Go).Start();
            tt.Go();
        }

        public void Go()
        {
            if (!_done)
            {
                _done = true;
                Console.WriteLine("Done");
            }
        }
    }
}