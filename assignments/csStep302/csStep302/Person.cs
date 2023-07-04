using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csStep302
{
    //made this class abstract so it wouldn't be instantiated
    public abstract class Person
    {
        //string properties for Person class
        public string firstName { get; set; }
        public string lastName { get; set; }

        //abstract method which means Employee class will implement this method
        public abstract void SayName();
    }
}
