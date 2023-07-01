using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csStep275
{
    public class Math
    {
        //METHOD WITHIN MATH CLASS THAT WILL ADD TWO NUMBERS GIVEN userInput
        public static void AddTwo(int userInput)
        {
            int sum = userInput + 50;  //ADDS 50 TO userInput
            Console.WriteLine(sum);
        }
        //METHOD WITHIN MATH CLASS THAT WILL SUBTRACT TWO NUMBERS GIVEN userInput
        public static void SubtractTwo(int userInput)
        {
            int difference = userInput - 1;  //SUBTRACTS 1 TO userInput
            Console.WriteLine(difference);
        }
        //METHOD WITHIN MATH CLASS THAT WILL MULTIPLY TWO NUMBERS GIVEN userInput
        public static void MultiplyTwo(int userInput)
        {
            int product = userInput * 10;  //MULTIPLIES userInput BY 10
            Console.WriteLine(product);
        }
    }
}
