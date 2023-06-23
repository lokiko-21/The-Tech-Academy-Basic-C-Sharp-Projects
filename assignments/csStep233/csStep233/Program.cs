using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csStep233
{
    class Program
    {
        static void Main()
        {

            //FIRST COUPLE OF STRINGS TO CONCATENATE
            string one = "Hi! ";
            string two = "I'm ";
            string three = "Marco.";

            Console.WriteLine(one + two + three);  //CONCATENATING STRINGS USING THE PLUS SIGNS
            Console.ReadLine();

            string bigOne = "this is written in lowercase.";
            bigOne = bigOne.ToUpper();  //CONVEERTING TO UPPERCASE USING .ToUpper()

            Console.WriteLine(bigOne);
            Console.ReadLine();

            //CREATING A SMALL PARAGRAPH ON SENTENCE AT A TIME
            StringBuilder paragraph = new StringBuilder();
            paragraph.Append(one + two + three);  //EACH APPEND ADDS ON TO PARAGRAPH
            paragraph.Append("\nAnd " + bigOne);  //EACH APPEND ADDS ON TO PARAGRAPH
            paragraph.Append("\nAll by using StringBuilder!");

            Console.WriteLine(paragraph);
            Console.ReadLine();

        }
    }
}
