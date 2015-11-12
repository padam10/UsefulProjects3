using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
// Three ways to intialize an object 
namespace ObjectIntializationDemo
{
    public class Program
    {
        public void Main(string[] args)
        {
            //Object intializatoin Best practices

            //Setting Proporties
            var currentProduct = new Product();
            currentProduct.ProductName = "Pen";
            currentProduct.ProductId = 3;
            currentProduct.ProductDes = "Red Ball Pen";
            Console.WriteLine("Name: {0}, Id: {1}, Description:{2}",currentProduct.ProductName,currentProduct.ProductId,currentProduct.ProductDes);
            
            //Parameterized Constructor
            var product = new Product("Labtop", 500, "ThinkPad 500");
            Console.WriteLine("Name: {0}, Id: {1}, Description:{2}", product.ProductName, product.ProductId, product.ProductDes);


            //Object Initializers
            var myProduct = new Product
                                {
                                    ProductId = 7,
                                    ProductName = "Shoes",
                                    ProductDes = "Nike Sports Shoes"
                                };
            Console.WriteLine("Name: {0}, Id: {1}, Description:{2}", myProduct.ProductName, myProduct.ProductId, myProduct.ProductDes);

            Console.Read();
        }
    }
    
}
