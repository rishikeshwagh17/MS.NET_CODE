using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DestructorConcept
{
    public class person {
        public int id;
        public string name;
        public int age;

        public person(string name, int id , int age) { 
            this.age = age;
            this.name = name;
            this.id = id;
        }
        public void getdetails() {
            Console.WriteLine("name is {0} id is {1} age is {2}",this.name,this.id,this.age);
        }
        ~person() {
            Console.WriteLine("destructor");
        }

    }

    public class Program
    {
        static void Main(string[] args)
        {
            person rishi = new person("rishi",11,22);
            rishi.getdetails();
            Console.WriteLine("-------------------");
            person swap = new person("swapnil", 12, 23);
            swap.getdetails();
            //Console.ReadLine();
        }
    }
}
