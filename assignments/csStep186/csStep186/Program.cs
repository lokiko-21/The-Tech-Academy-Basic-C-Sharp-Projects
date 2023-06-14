using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csStep186
{
    class Program
    {
        static void Main()
        {

            //VARIABLES THAT HAVE A SUFFIX c HAVE BEEN CASTED/CONVERTED
            //EXAMPLE wage1 IS A STRING AND wage1c IS AN INT

            //PROGRAM HEADING

            Console.WriteLine("Anonymus Income Comparison Program");

            Console.WriteLine("");



            //PERSON 1

            Console.WriteLine("Person 1: ");

            Console.WriteLine("Hourly wage?");
            string wage1 = Console.ReadLine();  //receive input as a string to convert later
            int wage1c = Convert.ToInt32(wage1);  //converted string to int type for math operations

            Console.WriteLine("Hours worked per week?");
            string hoursWorked1 = Console.ReadLine();  //receive input as a string to convert later
            int hoursWorked1c = Convert.ToInt32(hoursWorked1);  //converted string to int type for math operations

            Console.WriteLine("");



            //PERSON 2

            Console.WriteLine("Person 2: ");

            Console.WriteLine("Hourly wage?");
            string wage2 = Console.ReadLine();  //receive input as a string to convert later
            int wage2c = Convert.ToInt32(wage2);  //converted string to int type for math operations

            Console.WriteLine("Hours worked per week?");
            string hoursWorked2 = Console.ReadLine();  //receive input as a string to convert later
            int hoursWorked2c = Convert.ToInt32(hoursWorked2);  //converted string to int type for math operations

            Console.WriteLine("");



            //PERSON 1 SALARY

            Console.WriteLine("Annual salary of person 1: ");
            int totalSalary1 = wage1c * hoursWorked1c * 52;  //yearly salary calculation
            Console.WriteLine(totalSalary1);

            Console.WriteLine("");



            //PERSON 2 SALARY

            Console.WriteLine("Annual salary of person 2: ");
            int totalSalary2 = wage2c * hoursWorked2c * 52;  //yearly salary calculation
            Console.WriteLine(totalSalary2);

            Console.WriteLine("");



            //FINAL COMPARISON
            Console.WriteLine("Does person 1 make more money than person 2?");
            bool isGreater = totalSalary1 > totalSalary2;  //boolean comparison of both yearly salaries
            Console.WriteLine(isGreater);



            Console.ReadLine();

        }
    }
}
