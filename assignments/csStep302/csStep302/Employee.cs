using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csStep302
{
    //created class Employee that inherits Person class
    public class Employee : Person
    {
        //override keyword will help implement the SayName() method from Person
        public override void SayName()
        {
            //output will be the person's first and last name
            Console.WriteLine("{0} {1}", firstName, lastName);
            Console.ReadLine();
        }
    }
}
