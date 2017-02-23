using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveFromList
{
    using System.Security.Cryptography.X509Certificates;

    class Program
    {
        static void Main(string[] args)
        {
           List<Person>mylist =new List<Person>();
            mylist.Add(new Person() {ID = 1,name = "Padam",date = Convert.ToDateTime("05/27/2017"),email = "padam10@yahoo.com"});
            mylist.Add(new Person() {ID = 2,name = "Adam",date = Convert.ToDateTime("04/27/2017")});
            mylist.Add(new Person() {ID = 3,name = "samy",date = Convert.ToDateTime("05/27/2017"),email = "pdfsf10@yahoo.com"});
            mylist.Add(new Person() {ID = 4,name = "test",date = Convert.ToDateTime("05/27/2017"),email = ""});

            foreach (var person in mylist)
            {
                if (string.IsNullOrEmpty(person.email))
                {
                    Console.WriteLine("no email address {0}",person.name);
                }
            }

            mylist.RemoveAll(x =>string.IsNullOrEmpty(x.email));

            foreach (var person in mylist)
            {
                    Console.WriteLine("list of emp after null check {0}", person.name);
                
            }

            Console.Read();
        }
    }
}
