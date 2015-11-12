using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GetTypeVsTypeOfDemo
{
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public Employee(int id,string name)
        {
            this.ID = id;
            this.Name = name;
        }
    }
}
