using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csStep279
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 21;
            Math.AddTwo(num1);  //CALLS ON FIRST METHOD THAT CALLS INTEGER
            Console.ReadLine();

            double num2 = 2.1;
            Math.AddTwo(num2);  //CALLS ON SECOND METHOD WITH SAME NAME THAT TAKES IN DOUBLE
            Console.ReadLine();

            Console.WriteLine("How old are you?");
            string age = Console.ReadLine();
            Math.AddTwo(age);  //CALLS ON THIRD METHOD WITH SAME NAME THAT TAKES IN STRING

            Console.ReadLine();
        }
    }
}
