using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csStep314
{
    public class Employee
    {
        //properties for our Employee class
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //overload of == operator will return a boolean value and compare the employee objects' Id's
        public static bool operator== (Employee employee1, Employee employee2)
        {
            //if both objects contain null values they will be considered equal
            if (employee1 is null && employee2 is null)
            {
                return true;
            }
            //if only one is null but not the other then they are not equal
            if (employee1 is null || employee2 is null)
            {
                return false;
            }
            //will return true or false depending on whether the employees Id's are equal
            return employee1.Id == employee2.Id;
        }
        //overload of != operator will return a boolean value and compare the employee objects' Id's
        public static bool operator!= (Employee employee1, Employee employee2)
        {
            //will return true or false depending on whether the employees Id's are not equal
            return !(employee1 == employee2);
        }
    }
}
