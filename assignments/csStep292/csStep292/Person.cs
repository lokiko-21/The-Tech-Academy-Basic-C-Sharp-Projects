using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csStep292
{
    class Person
    {
        //FIRST AND LAST NAME PROPERTIES
        public string FirstName { get; set; }
        public string LastName { get; set; }
        //SayName() METHOD THAT WRITES THE FIRST AND LAST NAMES TOGETHER
        public void SayName()
        {
            Console.WriteLine("Name: {0} {1}", FirstName, LastName);
        }
    }
}
