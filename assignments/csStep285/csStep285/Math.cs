using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csStep285
{
    public static class Math  //DECLARING CLASS TO BE STATIC
    {
        public static void DivideByTwo(int number)  //MADE A VOID METHOD AND ADDED STATIC WHEN I MADE THE WHOLE CLASS STATIC
        {
            //SIMPLE CALCULATION
            int result = number / 2;
            Console.WriteLine("result of dividing {0} by 2 is: {1}", number, result);
            Console.ReadLine();
        }
        public static void GetCalculations(int a, int b, out int sum, out int difference)  //MADE A VOID METHOD AND ADDED STATIC WHEN I MADE THE WHOLE CLASS STATIC
        {
            //SIMPLE CALCULATIONS
            sum = a + b;
            difference = a - b;
            Console.WriteLine("{0} + {1} = {2}", a, b, sum);
            Console.WriteLine("{0} - {1} = {2}", a, b, difference);
            Console.ReadLine();
        }
        //OVERLOAD METHOD THAT HAS THE SAME NAME BUT DOES MULTIPLICATION INSTEAD OF ADDITION AND SUBTRACTION
        public static void GetCalculations(int c, int d, out int product)  //MADE A VOID METHOD AND ADDED STATIC WHEN I MADE THE WHOLE CLASS STATIC
        {
            product = c * d;
            Console.WriteLine("{0} * {1} = {2}", c, d, product);
            Console.ReadLine();
        }
    }
}
