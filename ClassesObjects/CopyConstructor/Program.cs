using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyConstructor
{
    public class example
    {
        public string name;
        public int age;

        public example(string name, int age) { 
            this.name = name;
            this.age = age;

        }
        public void getdata() {
            Console.WriteLine("name is: {0} and age is {1}",name,age);
        }

        public example(example e) { 
            this.name=e.name;
            this.age=e.age;
        }

    }

    public class Program
    {
        static void Main(string[] args)
        {
            example e1 = new example("rishi", 22);

            e1.getdata();
            example e2 = new example(e1);
            e2.getdata();
            Console.ReadLine();
        }
    }
}
