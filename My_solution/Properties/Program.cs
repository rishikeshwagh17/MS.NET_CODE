using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    public class Student
    { 
        private string name;
        private int age;
        private int id;
        private static string universityName;
        //auto props use this if we dont want logic in our properties
        public string department { get; set; }

        public static string _univeristyName 
        {
            get {
                return Student.universityName;
            }

            set {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("non empty or null");
                }
                else
                {
                    Student.universityName = value;
                }
            } 
        }

        //read write only props
        public string Name { 
            get { return name; } 
            set { name = value; } 
        }
        public int Age 
        { 
            get { return age; } 
            set { this.age = value; } 
        }
        public int Id { get { return id; } set { this.id = value; } }

    }
    public class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.Name = "rishi";
            Console.WriteLine(student.Name);
            student.Age = 22;
            Console.WriteLine(student.Age);
            student.Id = 101;
            Console.WriteLine(student.Id);
            Student._univeristyName = "";
            Console.WriteLine(Student._univeristyName);
            Console.ReadLine();
        }
    }
}
