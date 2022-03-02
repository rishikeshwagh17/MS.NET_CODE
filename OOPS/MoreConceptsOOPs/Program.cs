using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace MoreConceptsOOPs
{
    //single cast delegate point only single method only

    //there can be other delgates with diff signature pointing to corresponding signature method it point to
    public delegate void calc(int a, int b);
    public class Myclass 
    {
        public void add(int a, int b) {
            int res = a + b;
            Console.WriteLine("result is {0}", res);
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            Myclass myclass = new Myclass();
            calc obj = new calc(myclass.add);
            obj(10, 20);

            //multicast delegate application
            MultiCastDelegate multiCastDelegate = new MultiCastDelegate();
            calculation delobj = new calculation(multiCastDelegate.add);
            delobj(10, 20);
            //now we use += & -= operator to add & remove reference to delegate obj ref also look below
            delobj += multiCastDelegate.sub;
            delobj -= multiCastDelegate.add;
            delobj(50, 2);
            Console.ReadLine();
        }
    }
}
