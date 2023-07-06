using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csStep370
{
    class Program
    {
        static void Main(string[] args)
        {
            //assigning value to current time and printing it to console
            DateTime currentTime = DateTime.Now;
            Console.WriteLine("It is currently: {0}", currentTime);
            Console.ReadLine();

            //asking user for number ans storing it to variable x
            Console.WriteLine("Give me a number: ");
            int x = Convert.ToInt32(Console.ReadLine());

            //printing new time to user by adding their number x to the hours of our currentTime variable using the AddHours() method
            DateTime futureTime = currentTime.AddHours(x);
            Console.WriteLine("In {0} hours it's going to be: {1}", x, futureTime);
            Console.ReadLine();
        }
    }
}
