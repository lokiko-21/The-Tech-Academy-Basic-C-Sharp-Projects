using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csStep185
{
    class Program
    {
        static void Main()
        {

            //ALL VARIABLES WITH c AS A SUFFIX INDICATE THAT THEY HAVE BEEN CONVERTED/CASTED
            //EXAMPLE by50 AFTER CONVERTING FROM STRING TO INT IS NOW by50c

            Console.WriteLine("Enter number to multiply by 50: ");  //asking user to enter number
            string by50 = Console.ReadLine();  //storing number as string to receive input
            int by50c = Convert.ToInt32(by50) * 50;  //converting string to integer and multiplying by 50
            Console.WriteLine(by50c);  //printing answer

            Console.WriteLine("Enter number to add 25: ");
            string add25 = Console.ReadLine();
            int add25c = Convert.ToInt32(add25) + 25;
            Console.WriteLine(add25c);

            Console.WriteLine("Enter number to check if it is greater than 50: ");
            string greater = Console.ReadLine();
            int greaterc = Convert.ToInt32(greater);  //converting string to an integer first to be compared later
            bool isgreater = greaterc > 50;  //created bool variable that compares greaterc variable with 50
            Console.WriteLine(isgreater);  //printing answer

            Console.WriteLine("Enter number to divide by 12.5: ");
            string divide = Console.ReadLine();
            double dividec = Convert.ToDouble(divide) / 12.5;  //converting string to double data type
            Console.WriteLine(dividec);

            Console.WriteLine("Enter number to divide by 7 and print the remainder: ");
            string modulus = Console.ReadLine();
            int modulusc = Convert.ToInt32(modulus) % 7;  //converting string to int data type to be used with modulus operator
            Console.WriteLine(modulusc);

            Console.ReadLine();

        }
    }
}
