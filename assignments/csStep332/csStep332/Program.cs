using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csStep332
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiating new number object
            Number number = new Number();
            //giving number.Amount a value of 1.5 (don't forget to add the M at the end)
            number.Amount = 1.5M;

            //printing it out to the console
            Console.WriteLine(number.Amount);
            Console.ReadLine();
        }
    }
}
