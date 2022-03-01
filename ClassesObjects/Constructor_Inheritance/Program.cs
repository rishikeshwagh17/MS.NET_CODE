using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_Inheritance
{
    public class Program
    {
        class baselass 
        {
            public baselass() {
                Console.WriteLine("this is constructor of base class");
            }
        }

        class derivedclass : baselass
        {
            public derivedclass() : base() 
            {
                Console.WriteLine("this is constructor of derived class");
            }
        }

        static void Main(string[] args)
        {
            //derived class firstly calls base class constructor
            //we explicitly add the base() when parent class has the paramterized constructor
            derivedclass d1 = new derivedclass();
            Console.ReadLine();
        }
    }
}
