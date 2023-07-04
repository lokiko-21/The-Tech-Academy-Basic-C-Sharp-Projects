using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csStep318
{
    public class Employee<T>
    {
        //Employee class properties
        public List<T> Things { get; set; }

        //method to that makes the new list for Employee
        public Employee()
        {
            Things = new List<T>();
        }
    }
}
