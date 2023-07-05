using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csStep338
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiating list of employees so that I can add to it later
            List<Employee> employees = new List<Employee>();

            Employee employee1 = new Employee();  //instantiated employee
            employee1.Id = 1;  //gave uniquie id to employee starting at 1
            employee1.FirstName = "Marco";  //gave first name to employee
            employee1.LastName = "Breton";  //gave last name to employee
            employees.Add(employee1);  //added employee to employees list

            //repeated same steps as employee1 to all other employees each with unique names and id's
            Employee employee2 = new Employee();
            employee2.Id = 2;
            employee2.FirstName = "Max";
            employee2.LastName = "Lopez";
            employees.Add(employee2);

            Employee employee3 = new Employee();
            employee3.Id = 3;
            employee3.FirstName = "Kevin";
            employee3.LastName = "Martinez";
            employees.Add(employee3);

            Employee employee4 = new Employee();
            employee4.Id = 4;
            employee4.FirstName = "Duke";
            employee4.LastName = "Chaddington";
            employees.Add(employee4);

            Employee employee5 = new Employee();
            employee5.Id = 5;
            employee5.FirstName = "Lucci";
            employee5.LastName = "Mayne";
            employees.Add(employee5);

            Employee employee6 = new Employee();
            employee6.Id = 6;
            employee6.FirstName = "Joe";
            employee6.LastName = "Rogan";
            employees.Add(employee6);

            Employee employee7 = new Employee();
            employee7.Id = 7;
            employee7.FirstName = "Russel";
            employee7.LastName = "Wilson";
            employees.Add(employee7);

            Employee employee8 = new Employee();
            employee8.Id = 8;
            employee8.FirstName = "Lola";
            employee8.LastName = "La-Pistola";
            employees.Add(employee8);

            Employee employee9 = new Employee();
            employee9.Id = 9;
            employee9.FirstName = "Jesus";
            employee9.LastName = "Breton";
            employees.Add(employee9);

            Employee employee10 = new Employee();
            employee10.Id = 10;
            employee10.FirstName = "Joe";
            employee10.LastName = "Biden";
            employees.Add(employee10);

            //made a new list joeList to store all employees named Joe
            List<Employee> joeList = new List<Employee>();

            //foreach loop that will iterate through each employee in employees list
            foreach (Employee employee in employees)
            {
                //will pick out employees with first name Joe
                if (employee.FirstName == "Joe")
                {
                    //adds employee to the new list for employees named Joe
                    joeList.Add(employee);
                }
            }

            //made a new list to store all employees with Id greater than 5
            List<Employee> idList = new List<Employee>();

            //lambda expression
            idList.AddRange(employees.Where(emp => emp.Id > 5));

            //showing employees named Joe
            Console.WriteLine("Employees named Joe: \n");
            //foreach loop that goes through each employee in the list joeList
            foreach (Employee employee in joeList)
            {
                Console.WriteLine("ID: {0} \nFull-name: {1} {2} \n", employee.Id, employee.FirstName, employee.LastName);
            }
            Console.ReadLine();

            //showing employees with an Id greater than 5
            Console.WriteLine("Employees with an Id greater than 5: \n");
            //foreach loop that goes through each employee in the list idList
            foreach (Employee employee in idList)
            {
                Console.WriteLine("ID: {0} \nFull-name: {1} {2} \n", employee.Id, employee.FirstName, employee.LastName);
            }
            Console.ReadLine();
        }
    }
}
