using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csstep280
{
    class Program
    {
        static void Main(string[] args)
        {
            Math.Multiply(num1: 1234, times: 0);  //CALLING MY METHOD USING MY OWN PRE-SET NUMBERS

            Console.WriteLine("Give me a number: ");  //ASKING USER FOR THE FIRST NUMBER
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("give me a second number: ");  //ASKING USER FOR THE SECOND NUMBER
            int times = Convert.ToInt32(Console.ReadLine());

            Math.Multiply(num1, times);  //CALLS MY METHOD USING THE PARAMETERS GIVEN BY THE USER

            Math.Multiply(num1);  //CALLS MY METHOD USING ONLY ONE PARAMETER GIVEN BY THE USER
        }
    }
}
