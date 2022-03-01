using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marksheet
{
    public class Program
    {
        public static void addition(int a, int b) {
            int result = a + b;
            Console.WriteLine("addition result is: {0}", result);
        }
        public static void substraction(int a, int b)
        {
            int result = a - b;
            Console.WriteLine("substraction result is: {0}", result);
        }
        public static void multiplication(int a, int b)
        {
            int result = a * b;
            Console.WriteLine("multiplication result is: {0}", result);
        }
        public static void division(int a, int b)
        {
            int result = a / b;
            Console.WriteLine("division result is: {0}", result);
        }

        static void Main(string[] args)
        {

            Console.WriteLine("enter first number: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter second number: ");
            int num2 = int.Parse(Console.ReadLine());
            while (true)
            {
                Console.WriteLine("Enter Operation + - * /");
                string op = Console.ReadLine();

                if (op.Equals("+"))
                {
                    Program.addition(num1, num2);
                }
                else if (op.Equals("-"))
                {
                    Program.substraction(num1, num2);
                }
                else if (op.Equals("*"))
                {
                    Program.multiplication(num1, num2);
                }
                else if (op.Equals("/"))
                {
                    Program.division(num1, num2);
                }
                else
                {
                    Console.WriteLine("invalid input !!");
                }
            }
            
           
                 
        }
    }
}
