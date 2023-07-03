using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csStep285
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me a number: ");  //ASKING USER FOR A NUMBER
            int userInput = Convert.ToInt32(Console.ReadLine());

            //Math math = new Math();  NO LONGER NEEDED SINCE WE MADE THE CLASS STATIC
            Math.DivideByTwo(userInput);  //WILL DIVIDE THE USERS NUMBER BY 2

            int a = 10;
            int b = 5;
            int sum;
            int difference;
            Math.GetCalculations(a, b, out sum, out difference);  //METHOD GIVES OUTPUT USING OUTPUT PARAMETERS

            int c = 4;
            int d = 6;
            int product;
            Math.GetCalculations(c, d, out product);  //OVERLOADED METHOD
        }
    }
}
