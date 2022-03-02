using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_hiding
{
    class parent 
    {
        public void show()
        {
            Console.WriteLine("parent class method");
        }
    }

    class child : parent 
    {   
        //use new keyword if hiding was intended it says hide the parent class method
        public new void show() 
        {
            base.show();
            Console.WriteLine("child class method");
        }    
    }
    public class Program
    {
        static void Main(string[] args)
        {
            child c1 = new child();
            c1.show();
            //in op child class method hiding the parent class method so we have to use new keyword

            Console.ReadLine();
        }
    }
}
