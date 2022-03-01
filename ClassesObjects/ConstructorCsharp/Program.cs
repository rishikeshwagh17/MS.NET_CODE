using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorCsharp
{
    public class Program
    {
        public static int id = 100;
        public string fname;
        public string lname;
        public string dept;
        public Program() {
            Console.WriteLine("this is default constructor");
        }

        public Program( string fname, string lname,string dept)
        {
            
            this.fname = fname;
            this.lname = lname;
            this.dept = dept;
        }
        static void Main(string[] args)
        {
            Program p1 = new Program();
            Program p2 = new Program("rishi","wagh","Analyst");
            string result = p2.ToString();
            Console.WriteLine(Program.id);
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
