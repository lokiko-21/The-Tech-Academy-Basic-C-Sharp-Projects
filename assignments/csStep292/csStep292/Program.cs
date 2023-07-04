using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csStep292
{
    class Program
    {
        static void Main(string[] args)
        {
            //INSTANTIATING Employee CLASS AND GIVING STRING VLAUES TO FIRST AND LAST NAME
            Employee employee = new Employee();
            employee.FirstName = "Sample";
            employee.LastName = "Student";

            //CALLING SUPERCLASS SayName() ON THE Employee OBJECT
            employee.SayName();
            Console.ReadLine();
        }
    }
}
