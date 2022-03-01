using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceConcept
{
    public class Program
    {
        class visitEmployee : Employee
        {
            public int visitSal;
            public int visitHours;
        }
        class permEmployee : Employee
        {
            public int permSal;
            public int perHours;
        }
        class Employee
        {
            public int empid;
            public string empname;
            public int age;
            public int contactNo;
        }
        static void Main(string[] args)
        {
            permEmployee asad = new permEmployee();
            asad.empname = "asad";
            Console.WriteLine(asad.permSal = 5000);
            visitEmployee ali = new visitEmployee();
            ali.empname = "ali";
            Console.WriteLine(ali.visitSal =1000);
        }
    }
}
