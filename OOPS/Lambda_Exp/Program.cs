using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_Exp
{
    //launch in c# 3.0
    //prereq - must know anonymous function
    //similar to anonymous but easier
    public delegate void mydel(int num);

    public class Program
    {
        static void Main(string[] args)
        {
            //this is anonymous function
            mydel obj = delegate (int a)
            {
                a += 25;
                Console.WriteLine("final result is {0}",a);
            };
            obj.Invoke(10);

            //in lambda delegate keyword removed also data type of para not req bec it matchs with delegate
            //thus lambda expression is shorthand of anonymous function
            mydel obj2 = (a) =>
            {
                a *= 25;
                Console.WriteLine(a);
            };
            obj2.Invoke(10);
            Console.ReadLine();
        }
    }
}
