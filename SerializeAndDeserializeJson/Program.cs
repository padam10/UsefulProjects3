using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

// This program shows how easy it is convert an regular object to json object with the help of the newtonsoft
// This also helps you to deserialize json to c# object. 

namespace SerializeAndDeserializeJson
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product();
            product.Name = "Orange";
            product.ExpirayDate = new DateTime(2015,11,23);
            product.Price = 12.99;
            product.Sizes = new[] { "Small", "Medium", "Large" };

            Console.WriteLine("This is converted to Json");
            string output = JsonConvert.SerializeObject(product);
            Console.WriteLine(output);
            Console.WriteLine();
            Console.WriteLine();


            Console.WriteLine("Here is the deserialized Object");
            Product deserializedProduct = JsonConvert.DeserializeObject<Product>(output);
            Console.WriteLine("Name: {0},Expiration Date: {1}, Price: {2}, Sizes: {3}",deserializedProduct.Name,deserializedProduct.ExpirayDate,deserializedProduct.Price,deserializedProduct.Sizes[0]);
            Console.Read();
        }
    }
}
