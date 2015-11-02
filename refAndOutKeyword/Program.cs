using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 1. Out and Ref helps to pass by reference
   2. Ref is two way from caller to callee and back
   3. Out is one way it sends data back from calle to caller and any data
      that was passed from caller is discarded. 

 */

namespace refAndOutKeyword
{
    public class Program
    {
        static void Main(string[] args)
        {
            int OutSideVar = 20;
            SomeFunction(ref OutSideVar);
            Console.WriteLine(OutSideVar);

            int varForOut = 50;
            FunctionForOut(out varForOut);
            Console.WriteLine(varForOut);
        }
        // for ref, it takes data 20 that was passed and adds to 10
        // and returns 30
        private static void SomeFunction(ref int inSideVar)
        {
            inSideVar = inSideVar + 10;
        }
        // for out we passed 50 but it was discarded before it was used. 
        // It only returns the data from the this function. which is 40 
       static void FunctionForOut(out int insideVar)
        {
            insideVar = 0;
            insideVar = insideVar + 40;
        }
    }
}
