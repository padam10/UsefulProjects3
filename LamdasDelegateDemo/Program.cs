
namespace LamdasDelegateDemo
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using LamdasWithLinq;

    /// <summary>
    /// The program.
    /// </summary>
    public class Program
    {
       
        private static void Main(string[] args)
        {
            var listEmployees = new List<Employee>
                                    {
                                        new Employee { ID = 1, Name = "Mark" }, 
                                        new Employee { ID = 2, Name = "John" }, 
                                        new Employee { ID = 3, Name = "Mary" }
                                    };

            try
            {
                var employee = listEmployees.Find(emp => emp.ID == 2);
                Console.WriteLine("Id = {0}, Name = {1}", employee.ID, employee.Name);
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine("Exception Occured{0} ", e.Message);
            }

            //using lamda for linq to return the no of name starts with M
            int count = listEmployees.Count(emp => emp.Name.StartsWith("m",StringComparison.OrdinalIgnoreCase));
            Console.WriteLine("There are {0} employees whose Name starts with M",count);

            Console.Read();
        }
    }
}