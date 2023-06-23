using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csStep242
{
    class Program
    {
        static void Main()
        {
            //CREATING MY STRING AND INTEGER ARRAYS
            string[] stringArray = new string[] {"green", "blue", "red", "yellow"};
            int[] intArray = new int[] {7, 21, 17, 38};


            //ASKING USER TO SELECT AN INDEX FROM STRING ARRAY
            Console.WriteLine("Give a number to choose a string from my array: ");
            int stringIndex = Convert.ToInt32(Console.ReadLine());

            if (stringIndex <= 3)
            {
                Console.WriteLine(stringArray[stringIndex]);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("That index does not exist.");
                Console.ReadLine();
            }


            //ASKING USER TO SELECT AN INDEX FROM INTEGER ARRAY
            Console.WriteLine("Give a number to choose a string from my array: ");
            int integerIndex = Convert.ToInt32(Console.ReadLine());

            //CHECKS TO SEE IF CHOSEN INDEX EXISTS
            if (integerIndex <= 3)
            {
                Console.WriteLine(intArray[integerIndex]);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("That index does not exist.");
                Console.ReadLine();
            }


            //CREATING LIST OF STRINGS
            List<string> stringList = new List<string>();
            stringList.Add("first string");
            stringList.Add("second string");
            stringList.Add("third string");
            stringList.Add("fourth string");
            stringList.Add("fifth string");

            //ASKING USER TO SELECT AN INDEX FROM STRING LIST
            Console.WriteLine("give number to choose a string from my list: ");
            int integerList = Convert.ToInt32(Console.ReadLine());

            //CHECKS TO SEE IF INDEX IS INSIDE OF THE STRING LIST
            if (integerList <= 4)
            {
                Console.WriteLine(stringList[integerList]);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("index does not exist.");
                Console.ReadLine();
            }

        }
    }
}
