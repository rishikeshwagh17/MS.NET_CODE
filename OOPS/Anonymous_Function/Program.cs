using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anonymous_Function
{
    //function with no names is called as a anonymous function & they are always sue with delegates
    //anonymous function has only body use delegate keyword for declaring them
    public delegate void delega(int num);
    public class concepts 
    {
        public void mymethod(int a) 
        {
            a += 10;
            Console.WriteLine(a);
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            delega obj = delegate (int a)
            {
                a = a + 25;
                Console.WriteLine(a);
            };
            obj(10);
            Console.ReadLine();        }
    }
}
