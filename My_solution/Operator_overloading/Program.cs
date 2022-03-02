using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator_overloading
{
    public class NewClass 
    {
        public string str;
        public int num;

        //must use operator keyword for operator overloading function
        //compiler read them as a function
        public static NewClass operator +(NewClass obj1,NewClass obj2) {
            NewClass obj3 = new NewClass();
            obj3.str = obj1.str + obj2.str;
            obj3.num = obj1.num + obj2.num;

            return obj3;
        }


    }
    internal class Program
    {
        static void Main(string[] args)
        {
            NewClass obj1 = new NewClass();
            obj1.str = "rishi";
            obj1.num = 11;

            NewClass obj2 = new NewClass();
            obj2.str = "wagh";
            obj2.num = 33;

            NewClass obj3 = new NewClass();
            obj3 = obj1 + obj2;
        }
    }
}
