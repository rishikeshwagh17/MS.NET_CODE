using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic_poly
{
    //dynamic also called as a runtime polymorphism -- Method overriding
    //it also provides virtual and abstract
    class parent 
    {
        //virtual keyword always in base class
        public virtual void print() {
            Console.WriteLine("this is parent method");
        } 
    }
    class child : parent 
    {
        //override keyword always in derived class
        //it overrides the base class method in the derived class
        
        public override void print() {
            Console.WriteLine("this is child class method");
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            parent parent = new child();
            //it goes by the object type
            parent.print();
            Console.ReadLine();
        }
    }
}
