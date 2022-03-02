using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sealed_Class
{
    //sealed class prevents inheritance

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
            parent parent = new parent();
            parent.meth1();
            Console.ReadLine();
        }
    }
}
