using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_inheritance
{

    interface I1 
    {
        void printp1();
    }
    interface I2 
    {
        void printp2();
    }
    interface I3 : I1,I2 
    {
        void print();
    }

    public class mycls : I3
    {
        public void print()
        {
            Console.WriteLine("i3 methods function");
        }

        public void printp1()
        {
            Console.WriteLine("i3 parent1 func");
        }

        public void printp2()
        {
            Console.WriteLine("i3 parent2 func");
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            mycls mycls = new mycls();
            mycls.print();
            mycls.printp1();
            mycls.printp2();
            Console.ReadLine();
        }
    }
}
