using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ThreadPool
{
    using System.Threading;

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("{0} Main called",Thread.CurrentThread.ManagedThreadId);
            Thread t = new Thread(SayHello);
            //t.IsBackground = true;
            t.Start();
            Console.WriteLine("{0} Main Done", Thread.CurrentThread.ManagedThreadId);
            Console.Read();
        }

        private static void SayHello()
        {
            int iterations = 10;
            for (int n = 0; n < iterations; n++)
            {
                Console.WriteLine("{0} Hello World {1}! {2}",Thread.CurrentThread.ManagedThreadId,n,Thread.CurrentThread.IsBackground);
            }

           }
        
    }
}
