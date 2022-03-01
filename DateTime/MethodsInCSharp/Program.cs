using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsInCSharp
{
    public class Program
    {
        //out parameter it changes the original value in main function where it calls 
        public static void passByOut(out int var) {
            var = 20;
            Console.WriteLine("value is {0} ",var);
        }

        public static dynamic show(dynamic a) {
            return a;
        }

        static void Main(string[] args)
        {
            //int value;
            //passByOut(out value);
            ////out changes the original value to out value(value inside passByOut function)
            //Console.Write(value);
            //Console.WriteLine("");


            var a = "rishi";
            Console.WriteLine(a);
            dynamic b = 10;
            Console.WriteLine(b.GetType());
            //dynamic value is decided at runtime

            Program.show("rishi");
            Program.show(5);
            Program.show(true);
            Console.ReadLine();
        }
    }
}
