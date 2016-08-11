using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryParseDateTimeOffsetDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Use DateTime.TryParse when input is valid.
            string input = "2017";
            DateTimeOffset dateTime;
            if (DateTimeOffset.TryParse(input, out dateTime))
            {
                Console.WriteLine(dateTime);
            }
            else
            {
                Console.WriteLine(dateTime);
            }

           
        }
    }
}
