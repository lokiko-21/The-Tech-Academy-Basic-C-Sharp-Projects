using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csStep275
{
    class Program
    {
        static void Main(string[] args)
        {
            //ASKING USER FOR A NUMBER
            Console.WriteLine("Give me a number, and I will do math with it!");
            int userInput = Convert.ToInt32(Console.ReadLine());

            Math.AddTwo(userInput);  //DOES THE AddTwo() METHOD WITH userInput
            Math.SubtractTwo(userInput);  //DOES THE SubtractTwo() method with userInput
            Math.MultiplyTwo(userInput);  //DOES THE MultiplyTwo() method with userInput

            //RETURNS ANSWERS
            Console.ReadLine();
        }
    }
}
