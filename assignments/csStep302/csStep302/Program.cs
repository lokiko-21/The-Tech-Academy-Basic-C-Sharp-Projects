using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csStep302
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiating Employee class
            Employee employee = new Employee();
            //giving values to first and last name properties
            employee.firstName = "Sample";
            employee.lastName = "Student";
            //calling SayName() method
            employee.SayName();

            //making a new object of type IQuittable
            IQuittable quittableEmployee = new Employee();
            //calling Quit() method to display employee has quit
            quittableEmployee.Quit();
        }
    }
}
