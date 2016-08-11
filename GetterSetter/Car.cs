using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetterSetter
{
     class Car
    {
        private int id;

        private string color;

         /// <exception cref="Exception" accessor="set">Id can not be negative</exception>
         public int Id
        {
            get
            {
                return this.id;
            }
            set
            {
               
                this.id = value;
                
            }
        }


         public string Color
         {
             get
             {
                 return this.color;
             }
             set
             {
                
                 this.color = value;
             }
         }

    }
}
