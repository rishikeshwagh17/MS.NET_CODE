using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace MoreConceptsOOPs
{
    //singlr cast delegate point only single method only
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
            Console.ReadLine();
        }
    }
}
