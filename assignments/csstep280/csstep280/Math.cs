using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csstep280
{
    public class Math
    {
        public static void Multiply(int num1, int times = 1)  //SETTING UP PARAMETERS FOR MY METHOD SECOND ONE IS OPTIONAL IF USER WANTS TO MULTIPLY OR NOT
        {
            int product = num1 * times;  //PERFORMS MATH OPERATION WITH BOTH PARAMETERS GIVEN
            Console.WriteLine("The  number " + num1 + ", added to itself " + times + " times, is " + product);
            Console.ReadLine();
        }
    }
}
