using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csStep385
{
    class Program
    {
        static void Main(string[] args)
        {
            //creating my const variable another variable using var
            const string creatorName = "Marco Breton";
            var myAge = 21;

            //using first contructor with only one parameter
            Class1 object1 = new Class1("Duke");
            object1.Action();  //calling my Action() method

            //using second constructor with two parameters
            Class1 object2 = new Class1("Lucci", 3);
            object2.Action();  //calling my Action() method

            Console.ReadLine();
        }
    }
}
