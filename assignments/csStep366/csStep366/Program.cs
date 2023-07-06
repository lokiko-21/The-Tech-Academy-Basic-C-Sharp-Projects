using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;  //using the System.IO namespace

namespace csStep366
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please give me a number: ");  //asking user for input
            string userInput = Console.ReadLine();  //storing user input into variable
            //using the StreamWriter class to allow me to write text in a separate file
            using (StreamWriter file = new StreamWriter(@"log.txt", true))  //appends user input everytime to bin\Debug\log.txt
            {
                file.WriteLine(userInput);  //inserting new line within text file
            }
        }
    }
}
