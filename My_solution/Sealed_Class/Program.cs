using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sealed_Class;
namespace Sealed_Class
{
    //sealed class prevents inheritance
    //you can create sealed class instance | --> used to prevent data to inherit to other class
    sealed class parent 
    {
        public void meth1()
        {
            Console.WriteLine("this is base class meth");
        }
    }

    //here child cannot inherit from parent
    class child
    {
        public void method2() 
        {
            Console.WriteLine("this is child class meth");
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            //creating sealed class instance
            parent parent = new parent();
            parent.meth1();
            
            
            b obj1 = new b();
            obj1.print();
            Console.ReadLine();
        }
    }
}
