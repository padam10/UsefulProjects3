using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadOnInstanceMethod
{
    using System.Threading;

    class Program
    {
        static void Main(string[] args)
        {
            Messenger m = new Messenger("Hello World");
            Thread t = new Thread(m.DisplayMessage); 
            t.Start();
            Console.Read();
        }
    }
}
