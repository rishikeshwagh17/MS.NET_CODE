using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
    public class Student
    {
        int rollno;
        string name;
        int age;
        int std;

        public void setRoll(int roll) { 
            rollno = roll;
        }

        public int GetRoll() { 
            return this.rollno;
        }

        static void Main(string[] args)
        {
            Student student = new Student();
            student.setRoll(11);
            Console.WriteLine(student.GetRoll()); 
            Console.ReadLine();
        }
    }
}
