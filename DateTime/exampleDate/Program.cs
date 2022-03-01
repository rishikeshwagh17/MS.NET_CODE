using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exampleDate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello world");
            DateTime d1 = DateTime.Now;
            //Console.WriteLine("{0:dddd}",d1);
            Console.WriteLine("{0:MM}", d1);

            int a = 10, b = 20;
            string c = (a > b) ? "a is great" : "b is great";

            Console.WriteLine(c);
            Console.ReadLine();

        }
    }
}
