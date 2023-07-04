using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csStep314
{
    class Program
    {
        static void Main(string[] args)
        {
            //first employee
            Employee employee1 = new Employee();
            employee1.FirstName = "Marco";
            employee1.LastName = "Breton";
            employee1.Id = 1001;

            //second employee
            Employee employee2 = new Employee();
            employee2.FirstName = "Max";
            employee2.LastName = "Lopez";
            employee2.Id = 1002;

            //checks to see if they are the same person by checking the employees Id's
            bool isTheSame = employee1 == employee2;

            Console.WriteLine(isTheSame);
            Console.ReadLine();

            //checks to see if they are a different person by checking the employees Id's
            bool isNotSame = employee1 != employee2;

            Console.WriteLine(isNotSame);
            Console.ReadLine();
        }
    }
}
