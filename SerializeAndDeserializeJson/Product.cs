using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializeAndDeserializeJson
{
    public class Product
    {
        public string Name { get; set; }
        public DateTime ExpirayDate { get; set; }
        public double Price { get; set; }
        public string [] Sizes { get; set; }
    }
}
