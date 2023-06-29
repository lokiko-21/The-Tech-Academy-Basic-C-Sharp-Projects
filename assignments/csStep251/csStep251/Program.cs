using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//THIS IS A SIX STEP ASSIGNMENT IN WHICH I WILL CREATE A CONSOLE APP. IT
//STARTS ON STEP 251 AND ENDS ON STEP (<--insert step here-->)
namespace csStep251
{
    class Program
    {
        static void Main(string[] args)
        {

            //MAKING STRING ARRAY
            string[] stringArray = { "marco", "max", "kevin", "duke", "lucci", "lola" };

            //ASKING USER FOR INPUT
            Console.WriteLine("Hello, what is your name? ");
            string userName = Console.ReadLine();
            Console.ReadLine();



            //SECOND LOOP THAT PRINTS EACH STRING IN THE ARRAY
            for (int a = 0; a < stringArray.Length; a++)
            {
                Console.WriteLine(stringArray[a]);
                Console.ReadLine();
            }
            //LOOP THAT ITERATES THROUGH EACH STRING IN ARRAY AND APPENDS USER INPUT
            for (int b = 0; b < stringArray.Length; b++)
            {
                string arrayAppend = stringArray + "and" + userName;
            }



            //THIS WAS AN INFINITE LOOP THAT KEPT GOING BECAUSE C WAS AND WILL ALWAYS BE LESS THAN stringArray.Length
            //IN ORDER TO FIX IT WE MUST ADD ON TO c TO MAKE IT GREATER THAN stringArray AT SOME POINT IN TIME

            //for (int c = 0; c < stringArray.Length; c--)
            //{
            //    Console.WriteLine("non-stop");
            //}
            //Console.ReadLine();

            //THE SIMPLE SOLUTION WAS TO MAKE c GRATER THAN stringArray BY ADDING 1 TO IT RATHER THAN SUBTRACTING
            for (int c = 0; c < stringArray.Length; c++)
            {
                Console.WriteLine("this is a loop");
            }
            Console.ReadLine();



            //LOOP THAT USES THE <= OPERATOR
            for (int d = 0; d <= stringArray.Length; d++)
            {
                Console.WriteLine("this is another loop");
            }
            Console.ReadLine();



            //LIST OF UNIQUE STRINGS
            List<string> stringList = new List<string>();
            stringList.Add("red");
            stringList.Add("green");
            stringList.Add("blue");
            stringList.Add("yellow");
            stringList.Add("purple");
            stringList.Add("pink");
            stringList.Add("black");
            stringList.Add("white");
            stringList.Add("grey");
            stringList.Add("magenta");
            stringList.Add("violet");
            stringList.Add("turqoise");
            stringList.Add("beige");
            stringList.Add("orange");
            stringList.Add("brown");

            //SETTING UP REUIREMENT FOR WHILE LOOP TO ALLOW SWITCH STATEMENT TO CONTINUE
            string retry = "no";

            //ASKING USER TO CHOOSE INDEX OF LIST TO PICK A LUCKY COLOR
            do
            {
                //ASKING USER TO GIVE A COLOR
                Console.WriteLine("give me a color and I will return it's index on the list.");
                string color = Console.ReadLine();

                //SWITCH STATEMENT THAT GOES THROUGH EACH ITEM IN THE LIST
                switch (color)
                {
                    case "red":
                        int e = stringList.IndexOf("red");  //CHECKS INDEX OF SAID ITEM IN LIST
                        Console.WriteLine(e);
                        Console.ReadLine();
                        retry = "no";  //ENDS LOOP
                        break;
                    case "green":
                        int f = stringList.IndexOf("green");  //CHECKS INDEX OF SAID ITEM IN LIST
                        Console.WriteLine(f);
                        Console.ReadLine();
                        retry = "no";  //ENDS LOOP
                        break;
                    case "blue":
                        int g = stringList.IndexOf("blue");  //CHECKS INDEX OF SAID ITEM IN LIST
                        Console.WriteLine(g);
                        Console.ReadLine();
                        retry = "no";  //ENDS LOOP
                        break;
                    case "yellow":
                        int h = stringList.IndexOf("yellow");  //CHECKS INDEX OF SAID ITEM IN LIST
                        Console.WriteLine(h);
                        Console.ReadLine();
                        retry = "no";  //ENDS LOOP
                        break;
                    case "purple":
                        int i = stringList.IndexOf("purple");  //CHECKS INDEX OF SAID ITEM IN LIST
                        Console.WriteLine(i);
                        Console.ReadLine();
                        retry = "no";  //ENDS LOOP
                        break;
                    case "pink":
                        int j = stringList.IndexOf("pink");  //CHECKS INDEX OF SAID ITEM IN LIST
                        Console.WriteLine(j);
                        Console.ReadLine();
                        retry = "no";  //ENDS LOOP
                        break;
                    case "black":
                        int k = stringList.IndexOf("black");  //CHECKS INDEX OF SAID ITEM IN LIST
                        Console.WriteLine(k);
                        Console.ReadLine();
                        retry = "no";  //ENDS LOOP
                        break;
                    case "white":
                        int l = stringList.IndexOf("white");  //CHECKS INDEX OF SAID ITEM IN LIST
                        Console.WriteLine(l);
                        Console.ReadLine();
                        retry = "no";  //ENDS LOOP
                        break;
                    case "grey":
                        int m = stringList.IndexOf("grey");  //CHECKS INDEX OF SAID ITEM IN LIST
                        Console.WriteLine(m);
                        Console.ReadLine();
                        retry = "no";  //ENDS LOOP
                        break;
                    case "magenta":
                        int n = stringList.IndexOf("magenta");  //CHECKS INDEX OF SAID ITEM IN LIST
                        Console.WriteLine(n);
                        Console.ReadLine();
                        retry = "no";  //ENDS LOOP
                        break;
                    case "violet":
                        int o = stringList.IndexOf("violet");  //CHECKS INDEX OF SAID ITEM IN LIST
                        Console.WriteLine(o);
                        Console.ReadLine();
                        retry = "no";  //ENDS LOOP
                        break;
                    case "turqoise":
                        int p = stringList.IndexOf("turqoise");  //CHECKS INDEX OF SAID ITEM IN LIST
                        Console.WriteLine(p);
                        Console.ReadLine();
                        retry = "no";  //ENDS LOOP
                        break;
                    case "beige":
                        int q = stringList.IndexOf("beige");  //CHECKS INDEX OF SAID ITEM IN LIST
                        Console.WriteLine(q);
                        Console.ReadLine();
                        retry = "no";  //ENDS LOOP
                        break;
                    case "orange":
                        int r = stringList.IndexOf("orange");  //CHECKS INDEX OF SAID ITEM IN LIST
                        Console.WriteLine(r);
                        Console.ReadLine();
                        retry = "no";  //ENDS LOOP
                        break;
                    case "brown":
                        int s = stringList.IndexOf("brown");  //CHECKS INDEX OF SAID ITEM IN LIST
                        Console.WriteLine(s);
                        Console.ReadLine();
                        retry = "no";  //ENDS LOOP
                        break;
                    default:
                        Console.WriteLine("that color is not on the list... try again");
                        retry = "yes";  //ALLOWS USER TO DECIDE WHETHER OR NOT THEY WANT TO CONTINUE BY TYPING "no"
                        break;
                }
            } while (retry != "no");  //WHILE retry != "no" LOOP WILL CONTINUE 

            //LIST OF STRING WITH TWO IDENTICAL STRINGS IN IT
            List<string> animals = new List<string>();
            animals.Add("dog");
            animals.Add("cat");
            animals.Add("bat");
            animals.Add("cat");
            animals.Add("bee");
            animals.Add("fly");

            //SETTING UP SWITCH STATEMENT TO LOOP
            retry = "no";

            do
            {
                //ASKING USER FOR AN ITEM ON LIST
                Console.WriteLine("what animal has 3 letters?");
                string animal = Console.ReadLine();

                //SWITCH STATEMENT THAT COMPARES USER INPUT WITH ITEMS ON LIST
                //FOR THIS SWITCH STATEMENT I COULD'VE PROBABLY ADDED THE for LOOP IN EACH CASE TO CHECK FOR DUPLICATES
                //BUT SINCE I KNOW WHICH CASE/ITEM WAS THE DUPLICATE I ONLY MADE A LOOP FOR THAT SPECIFIC ONE
                switch (animal)
                {
                    case "dog":
                        int index0 = animals.IndexOf(animal);  //USING IndexOf() TO FIND CURRENT INDEX
                        Console.WriteLine(index0);
                        Console.ReadLine();
                        retry = "no";
                        break;
                    //THIS IS THE DUPLICATE ITEM ON THE LIST
                    case "cat":
                        //THIS GOES THROUGH EACH ITEM ON THE LIST AND X IS THE CURRENT INDEX
                        for (int x = 0; x < animals.Count; x++)
                        {
                            //THIS CHECKS AT WHICH INDEX THE ITEM MATCHES THE USER INPUT
                            if (animals[x] == animal)
                            {
                                //PRINTS OUT EACH TIME THERE IS A DUPLICATE AT WHAT INDEX
                                Console.WriteLine(x);
                            }
                        }
                        Console.ReadLine();
                        retry = "no";
                        break;
                    case "bat":
                        int index2 = animals.IndexOf(animal);  //USING IndexOf() TO FIND CURRENT INDEX
                        Console.WriteLine(index2);
                        Console.ReadLine();
                        retry = "no";
                        break;
                    case "bee":
                        int index3 = animals.IndexOf(animal);  //USING IndexOf() TO FIND CURRENT INDEX
                        Console.WriteLine(index3);
                        Console.ReadLine();
                        retry = "no";
                        break;
                    case "fly":
                        int index4 = animals.IndexOf(animal);  //USING IndexOf() TO FIND CURRENT INDEX
                        Console.WriteLine(index4);
                        Console.ReadLine();
                        retry = "no";
                        break;
                    //MAKES THE USER TRY AGAIN IF ANIMAL IS NOT IN THE LIST
                    default:
                        Console.WriteLine("that's not on the list... try again.");
                        retry = "yes";
                        break;
                }
            } while (retry != "no");  //WHILE retry != "no" LOOP WILL CONTINUE

            

            //LIST OF STRINGS WITH WITH DUPLICATE LATER IN THE LIST
            List<string> letters = new List<string>();
            letters.Add("A");
            letters.Add("B");
            letters.Add("C");
            letters.Add("D");
            letters.Add("C");

            //SECOND LIST THAT WILL STORE UNIQUE STRINGS
            List<string> uniqueLetter = new List<string>();

            //FOREACH LOOP THAT ITERATES THROUGH EACH ITEM ON LIST
            foreach (string letter in letters)
            {
                if (uniqueLetter.Contains(letter))  //CHECKS TO SEE IF ITEM IS ALREADY IN LIST OR NOT. IF SO IT PRINTS THE DUPLICATE
                {
                    Console.WriteLine(letter + " - this item is a duplicate");
                }
                else  //OTHERWISE IT PRINTS OUT THE UNIQUE LETTER INSTEAD
                {
                    Console.WriteLine(letter + " - this item is unique");
                    uniqueLetter.Add(letter);
                }
            }
            Console.ReadLine();
        }
    }
}
