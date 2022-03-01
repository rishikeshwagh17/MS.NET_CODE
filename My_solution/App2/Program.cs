using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Access_specifier_refernce_namespace;
namespace App2
{   
    public class myclass 
    {
        void meth1() {
            Console.WriteLine("this is method 1");            
        }

        public void meth2() {
            meth1 ();
            Console.WriteLine("this is method 2");
        }
    }
    public class Program
    {

        static void Main(string[] args)
        {
            //adding namespace Access_specifier_refernce_namespace to this app (App2)
            myclass m1 = new myclass();
            m1.meth2();
            Console.ReadLine();
        }
    }
}
