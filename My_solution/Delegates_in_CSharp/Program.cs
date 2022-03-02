using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates_in_CSharp
{
    //each signature has unique delegate if your method signature changes create seperate delegate for this
    //delegate doesnt have body {definition} cause it acts as a middleman
    public delegate void delegatefunc(int a, int b);
    public class myclass 
    {
        public void addition(int a, int b) 
        {
            int result = a + b; 
            Console.WriteLine("adiition is {0}",result);
        }
        public void substract(int a, int b)
        {
            int result = a - b;
            Console.WriteLine("substract is {0}", result);
        }
        public void multiply (int a, int b)
        {
            int result = a * b;
            Console.WriteLine("multiply is {0}", result);
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            myclass myclass = new myclass();
            delegatefunc obj = new delegatefunc(myclass.addition);
            
            //delegate use to hold reference to the method of class we can use delegate to call various
            //methods of class   ---> create delegate instance in main and pass method as a argument
            //delegate signamture must be same as a method which it point to
            //you can call this method by  (<obj ref>.<methodname>)


            obj.Invoke(20,30);

            obj = myclass.substract;
            obj.Invoke(50, 10);
            Console.ReadLine();


        }
    }
}
