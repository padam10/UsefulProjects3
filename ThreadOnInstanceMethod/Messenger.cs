using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadOnInstanceMethod
{
   public class Messenger
    {
        private string msg;

        public Messenger(string msg)
        {
            this.msg = msg;
        }

        public void DisplayMessage()
        {
            Console.WriteLine(this.msg);
        }
    }
}
