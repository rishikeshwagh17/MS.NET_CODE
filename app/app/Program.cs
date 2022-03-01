using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//above all are namespaces like packages in java

namespace app
{
    public class Program
    {
        //main is where application start executing
        static void Main(string[] args)
        {
            int a = 20;
            Console.WriteLine(a);
            //console is in namespace system
            Console.WriteLine("Welcome to C sharp !!");
            // using read line method because console window executes and terminate quickly to halt it we
            //use this readline method
            //it is for user input
             string fname = Console.ReadLine();
            string lname = Console.ReadLine();
            Console.WriteLine(" your fullname is: {0} {1}", fname, lname);
            Console.WriteLine("over");
            Console.ReadLine();
            
            
        }
    }
}
