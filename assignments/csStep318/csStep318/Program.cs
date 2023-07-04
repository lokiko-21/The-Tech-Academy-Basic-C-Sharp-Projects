using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csStep318
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiating Employee as a string type
            Employee<string> employeeString = new Employee<string>();
            //adding string values to string type list
            employeeString.Things.Add("One");
            employeeString.Things.Add("Two");
            employeeString.Things.Add("Three");

            //instantiating Employee as a integer type
            Employee<int> employeeInt = new Employee<int>();
            //adding integer values to integer type list
            employeeInt.Things.Add(1);
            employeeInt.Things.Add(2);
            employeeInt.Things.Add(3);

            Console.WriteLine("String type things: ");
            //foreach loop that prints all items in my string list
            foreach (string thing in employeeString.Things)
            {
                Console.WriteLine(thing);
            }
            Console.ReadLine();

            Console.WriteLine("Integer type things: ");
            //foreach loop that prints all items in my integer list
            foreach (int thing in employeeInt.Things)
            {
                Console.WriteLine(thing);
            }
            Console.ReadLine();
        }
    }
}
