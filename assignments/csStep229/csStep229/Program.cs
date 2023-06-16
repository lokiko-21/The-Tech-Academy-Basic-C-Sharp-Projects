using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csStep229
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Do while loop. Please guess a number between 1 and 10");
            int A = Convert.ToInt32(Console.ReadLine());
            bool guessedA = A == 5;

            //BEGINNING OF DO-WHILE LOOP
            do
            {
                //BEGINNING OF SWITCH STATEMENT
                switch (A)
                {
                    //EACH CASE BETWEEN 1 AND 4 WILL TELL USER INPUT IS TOO LOW
                    case 1:
                        Console.WriteLine("Number is too low.");
                        Console.WriteLine("Guess again.");
                        A = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 2:
                        Console.WriteLine("Number is too low.");
                        Console.WriteLine("Guess again.");
                        A = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 3:
                        Console.WriteLine("Number is too low.");
                        Console.WriteLine("Guess again.");
                        A = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 4:
                        Console.WriteLine("Number is too low.");
                        Console.WriteLine("Guess again.");
                        A = Convert.ToInt32(Console.ReadLine());
                        break;
                    //THIS CASE WILL TELL THE USER THEY GUESSED CORRECT
                    case 5:
                        Console.WriteLine("You got it!");
                        guessedA = true;  //CHANGING THIS TO TRUE WILL EXIT LOOP SINCE guessedA IS NO LONGER FALSE OR (!guessedA)
                        break;
                    //EACH CASE BETWEEN 6 AND 10 WILL TELL USER INPUT IS TOO HIGH
                    case 6:
                        Console.WriteLine("Number is too high.");
                        Console.WriteLine("Guess again.");
                        A = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 7:
                        Console.WriteLine("Number is too high.");
                        Console.WriteLine("Guess again.");
                        A = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 8:
                        Console.WriteLine("Number is too high.");
                        Console.WriteLine("Guess again.");
                        A = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 9:
                        Console.WriteLine("Number is too high.");
                        Console.WriteLine("Guess again.");
                        A = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 10:
                        Console.WriteLine("Number is too high.");
                        Console.WriteLine("Guess again.");
                        A = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }
            while (!guessedA);
            Console.ReadLine();


            Console.WriteLine("Now the while loop will count until i gets to 10.");
            Console.ReadLine();

            int i = 0;
            while (i < 11)
            {
                Console.WriteLine(i);
                Console.ReadLine();
                i++;
            }
        }
    }
}
