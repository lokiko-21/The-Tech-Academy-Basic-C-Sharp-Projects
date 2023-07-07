using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csStep390
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //asking user for their age
                Console.WriteLine("What is your age?");
                int age = Convert.ToInt32(Console.ReadLine());

                if (age <= 0)
                {
                    //exception message thrown if age is 0 or less
                    throw new Exception("Age must be greater than 0.");
                }
                else
                {
                    int currentYear = DateTime.Now.Year;
                    int birthYear = currentYear - age;  //if user's birthday has passed this year
                    int birthYear2 = birthYear - 1;  //if user's birthday is coming up this year

                    Console.WriteLine("You were born in {0} if your birthday is today or it already passed", birthYear);
                    Console.WriteLine("Otherwise if your birthday is coming up you were born in {0}.", birthYear2);
                }
            }
            //exception catcher
            catch (Exception x)
            {
                //will display excepion message
                Console.WriteLine("Error: " + x.Message);
            }

            Console.ReadLine();
        }
    }
}
