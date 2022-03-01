using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    public class person {
        private string name;
        private int age;

        public void setName(string name) {
            if (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("name is required !! ");
            }
            else
            {
                this.name = name;
            }
        }

        public string getName() { 
            return this.name;
        }

        public void setAge(int age)
        {
            this.age = age;
        }

        public int getAge()
        {
            return this.age;
        }

    }
    public class Program
    {
        static void Main(string[] args)
        {
            person p = new person();
            p.setName("");
            p.setAge(22);
            Console.WriteLine(p.getAge());
            Console.WriteLine(p.getName()); 
        }
    }
}
