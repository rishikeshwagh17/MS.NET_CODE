using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_as_parameter
{
    public delegate void del(int n);
    public class myprogram
    {
        //myprogram.mymethod(delegate (int num)
        //    {
        //        Console.WriteLine(num);
        //    }, "rishi");

        //passing complete anonymous function as a mydel below  because delegate ref can hold anonymous function
        //like  del obj = delegate(int n){
        //          Console.WriteLine(n);
        //      }
    public void mymethod(del mydel, String name) {
            Console.WriteLine("hello {0}",name);
            mydel.Invoke(10);
        }

    }
    public class Program
    {
        static void Main(string[] args)
        {
            myprogram myprogram = new myprogram();
            myprogram.mymethod(delegate (int num)
            {
                Console.WriteLine(num);
            }, "rishi");

            Console.ReadLine();
        }
    }
}
