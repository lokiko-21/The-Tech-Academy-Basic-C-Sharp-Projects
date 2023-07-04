using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csStep302
{
    //created class Employee that inherits Person class
    public class Employee : Person, IQuittable
    {
        //override keyword will help implement the SayName() method from Person
        public override void SayName()
        {
            //output will be the person's first and last name
            Console.WriteLine("{0} {1}", firstName, lastName);
            Console.ReadLine();
        }
        //implemented Quit() method from IQuittable interface
        public void Quit()
        {
            //output will say "Employee has quit..."
            Console.WriteLine("Employee has quit...");
            Console.ReadLine();
        }
    }
}
