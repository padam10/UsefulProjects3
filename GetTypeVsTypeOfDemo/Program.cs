using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GetTypeVsTypeOfDemo
{
    public class Program
    {
        public void Main(string[] args)
        {
            Employee employee = new Employee(1,"Padam");

            //use of GetType. This can only be invoked on the instance of the type

            Console.WriteLine(employee.GetType());

            // Use of TypeOf
            // It takes Type itself as an argument and returns underline
            //type of the argument. 
            Type t1 = typeof(Employee);
            Console.WriteLine(t1.AssemblyQualifiedName);
            Console.WriteLine(t1.FullName);
            Console.WriteLine(t1.Namespace);
            Console.WriteLine(t1.Name);


            Console.Read();

        }
    }
}
