using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csStep199
{
    class Program
    {
        static void Main()
        {

            //QUESTION 1
            Console.WriteLine("What is your age? ");
            string answer1 = Console.ReadLine();
            int age = Convert.ToInt32(answer1);  //CONVERTING STRING VARIABLE TO INT FOR BOOLEAN COMPARISON
            bool isAge = age > 15;  //RESULTS TRUE IF PERSON IS OVER 15


            //QUESTION 2
            Console.WriteLine("Have you ever had a DUI? (please type \"yes\" or \"no\").");
            string answer2 = Console.ReadLine();
            bool isDui = answer2 == "no";  //RESULTS TRUE IF PERSON WRITES "no"


            //QUESTION 3
            Console.WriteLine("How many speeding tickets do you have? ");
            string answer3 = Console.ReadLine();
            int tickets = Convert.ToInt32(answer3);  //CONVERTING STRING VARIABLE TO INT FOR BOOLEAN COMPARISON
            bool isTickets = tickets <= 3;  //RESULTS TRUE IF PERSON HAS 3 OR LESS TICKETS


            //RESULT
            Console.WriteLine("Qualified? ");
            bool isQaulified = isAge && isDui && isTickets;  //RESULTS TRUE IF ALL QUESTIONS ARE TRUE PASSING REQUIREMENTS
            Console.WriteLine(isQaulified);
            Console.ReadLine();


        }
    }
}
