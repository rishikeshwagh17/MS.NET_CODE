using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_prop
{
    public class myclass 
    {
        private static string universityName;
        private static string DepartmentName;

        public static string _universityName 
        {
            get {
                return myclass.universityName; 
            }
            set {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("university name cannot be empty or null");
                }
                else
                {
                    myclass.universityName= value;
                }
            }       
        }

        public static string _DepartmentName
        {
            get {
                return myclass.DepartmentName;
            }
            set {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("department name must not null or empty");
                }
                else
                {
                    myclass.DepartmentName= value;
                }
            }
        }

    }
    public class Program
    {

        static void Main(string[] args)
        {
            myclass._universityName = "SPPU";
            myclass._DepartmentName = "MECH";
            Console.WriteLine(myclass._universityName);
            Console.WriteLine(myclass._DepartmentName);
            Console.ReadLine();
        }
    }
}
