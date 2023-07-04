using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csStep325
{
    //created enum for the day of the week
    enum DayOfTheWeek
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }

    class Program
    {
        static void Main(string[] args)
        {
            //prompting user to give us a day of the week
            Console.WriteLine("What day of the week is it today?");
            string userInput = Console.ReadLine();

            //try block that will execute if user input matches the days of the week.
            try
            {
                //day is our variable which equals what the user typed if it matches whats in my enum
                //the true at the end makes it case-insensitive meaning one could type monday or MoNDay
                //and enum.parse is used to convert the userInput string type into the enum type of DayOfTheWeek
                DayOfTheWeek day = (DayOfTheWeek)Enum.Parse(typeof(DayOfTheWeek), userInput, true);
                Console.WriteLine("Oh it's {0}!", day);
                Console.ReadLine();
            }
            //catch block that handles any exceptions of the type "augmentexception"
            catch (ArgumentException)
            {
                Console.WriteLine("Please enter an actual day of the week.");
                Console.ReadLine();
            }
        }
    }
}
