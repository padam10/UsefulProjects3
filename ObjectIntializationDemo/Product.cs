using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ObjectIntializationDemo
{
    

    public class Product{
       
        public string ProductName { get; set; }
        public int ProductId { get; set; }
        public string ProductDes { get; set; }

       

        public Product()
        {

        }

        public Product(string pName, int Id, string desc)
        {
            this.ProductName = pName;
            this.ProductId = Id;
            this.ProductDes = desc;
        }

        public string SayHello()
        {
         
            return "Hello " + ProductName + " " + ProductId + " " + ProductDes;
        }
    }

    
}
