using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Value_Reference
{
    public class Program
    {
        struct Employee
        {
            public int salary;
            public string name;
        }
        static void Main(string[] args)
        {
            Employee e1 = new Employee();
            e1.name = "Rishi";
            e1.salary = 5000;

            Console.WriteLine(" {0} {1} ",e1.salary,e1.name);
            Console.ReadLine();

        }
    }
}
