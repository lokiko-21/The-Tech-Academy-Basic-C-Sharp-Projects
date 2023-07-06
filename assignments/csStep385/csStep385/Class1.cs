using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csStep385
{
    public class Class1
    {
        //class properties
        public string name { get; set; }
        public int age { get; set; }

        //first constructor takes
        public Class1(string name) : this(name, 0)
        {
        }

        public Class1(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public void Action()
        {
            Console.WriteLine("Name: {0} \nAge: {1} \n", name, age);
        }
    }
}
