using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csStep279
{
    public class Math
    {
        public static void AddTwo(int num1)  //FIRST METHOD THAT TAKES IN AN INTEGER
        {
            int sum = num1 + 10;  //PERFORMS MATH OPERATION ON NUMBER
            Console.WriteLine(sum);
        }
        public static void AddTwo(double num2)  //SECOND METHOD WITH SAME NAME THAT TAKES IN A DECIMAL NUMBER
        {
            double sum = num2 + 10.1;  //PERFORMS MATH OPERATION ON NUMBER
            Console.WriteLine(sum);
        }
        public static void AddTwo(string age)  //THIRD METHOD WITH SAME NAME THAT TAKES IN A STRING
        {
            int newAge = Convert.ToInt32(age) + 5;  //CONVERTS STRING INTO AN INTEGER AND PERFORMS MATH OPERATION ON IT
            Console.WriteLine("in 5 years you will be {0} years old!", newAge);
            Console.ReadLine();
        }
    }
}
