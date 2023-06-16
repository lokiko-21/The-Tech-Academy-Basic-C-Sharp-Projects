using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csStep222
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            //PROMPTS USER TO ENTER PACKAGE WEIGHT
            Console.WriteLine("Please enter the package weight: ");
            int weight = Convert.ToInt32(Console.ReadLine());


            //CHECKS TO SEE IF PACKAGE IS TOO HEAVY
            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
                Environment.Exit(1);  //EXITS PROGRAM IF PACKAGE IS OVER 50
            }


            //PROMPTS USER TO ENTER PACKAGE WIDTH
            Console.WriteLine("Please enter the package width: ");
            int width = Convert.ToInt32(Console.ReadLine());

            //PROMPTS USER TO ENTER PACKAGE HEIGHT
            Console.WriteLine("Please enter the package height: ");
            int height = Convert.ToInt32(Console.ReadLine());

            //PROMPTS USER TO ENTER PACKAGE LENGTH
            Console.WriteLine("Please enter the package length: ");
            int length = Convert.ToInt32(Console.ReadLine());

            int totalSize = width + height + length;  //ADDS ALL DIMENSIONS OF PACKAGE TOGETHER AND STORES IN totalSize VARIABLE
            int quote = ((width * height * length) * weight) / 100;  //CALCULATIONS FOR PRICE STORED IN quote VARIABLE

            //CHECKS TO SEE IF PACKAGE IS TOO BIG
            if (totalSize > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
                Environment.Exit(1);  //EXITS PROGRAM IF PACKAGE DIMENSIONS SUM IS OVER 50
            }


            Console.WriteLine("Your estimated total for shipping this package is: $" + quote + ".00");  //PRINTS TOTAL FOR USER
            Console.WriteLine("Thank you!");
            Console.ReadLine();
        }
    }
}
