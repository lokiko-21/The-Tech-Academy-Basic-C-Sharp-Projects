using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csStep281
{
    class Program
    {
        static void Main(string[] args)
        {
            Math Add = new Math();  //INSTANTIATED THE CLASS

            Math.Addition();  //CALLS METHOD WITH TWO GIVEN VALUES

            Console.WriteLine("What's your favorite number?");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int num1 = 21;
            Math.Addition(num1, num2);  //CALLS METHOD BY SPECIFYING BOTH NUMBERS NOW
        }
    }
}
