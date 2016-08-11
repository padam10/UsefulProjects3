using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetterSetter
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.Id = 5;
            car.Color = "red";
           
            Console.WriteLine("Id is: {0} and Color is {1}",car.Id,car.Color);
            Console.Read();
        }
    }
}
