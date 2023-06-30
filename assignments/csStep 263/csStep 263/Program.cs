using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csStep_263
{
    class Program
    {
        static void Main(string[] args)
        {
            //USING TRY/CATCH BLOCK TO HANDLE EXCEPTIONS
            try
            {
                //MY LIST OF INTEGERS THATS TO BE DIVIDED
                List<int> numbers = new List<int>();
                numbers.Add(6);
                numbers.Add(12);
                numbers.Add(24);
                numbers.Add(48);
                numbers.Add(96);
                numbers.Add(192);

                //SHOWING THE USER THE NUMBERS THE LIST
                Console.WriteLine("I have a list of numbers: ");
                foreach (int number in numbers)
                {
                    Console.WriteLine(number);
                }
                Console.ReadLine();

                //ASKING THE USER TO GIVE AN INTEGER TO DIVIDE THE NUMBERS BY
                Console.WriteLine("Give me a number to divide them by.");
                int userInput = Convert.ToInt32(Console.ReadLine());

                //foreach LOOP THAT GOES THROUGH EACH NUMBER IN THE LIST
                foreach (int number in numbers)
                {
                    //NEW VARIABLE IS EQUAL TO THE INTEGER IN THE LIST DIVIDED BY THE USER'S INPUT NUMBER
                    int answer = number / userInput;
                    Console.WriteLine(number + " divided by " + userInput + " is equal to " + answer);
                }
                Console.ReadLine();

                //ERROR MESSAGE FOR ENTERING 0: System.DivideByZeroException: 'Attempted to divide by zero.'
                //ERROR MESSAGE FOR ENTERING STRING: System.FormatException: 'Input string was not in a correct format.'
            }

            //WILL HANDLE EXCEPTIONS WHEN USER TYPES IN A STRING INSTEAD OF A NUMBER
            catch (FormatException ex)
            {
                Console.WriteLine("Type a whole number.");
            }

            //WILL HANDLE EXCEPTIONS WHEN USER TRY'S TO DIVIDE BY 0
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Don't divide by zero.");
            }

            //WILL HANDLE GENERAL EXCEPTIONS AND PRINT THEM OUT FOR THE USER TO SEE
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();

            //WILL POP UP AFTER THE TRY/CATCH BLOCK
            Console.WriteLine("Thanks for trying this program!");
            Console.ReadLine();

        }
    }
}
