using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excplicit_Imple_interface
{
    public interface I1 
    {
        void show();
    }
    public interface I2 
    {
        void show();
    }
    public class myclass : I1,I2
    {

        //I1.show() declare specific to I1 interface implemenatation
        void I1.show() {
            Console.WriteLine("explicit impl of i1 interface");
        }
        //I2.show() decalres specific to I2 interface implemenatation
        void I2.show() {
            Console.WriteLine("explicit impl of i2 interface");
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            myclass obj = new myclass();
            //casting required to get access to i1 method
            ((I1)obj).show();
            //casting required to get access to i2 method
            ((I2)obj).show();

            Console.ReadLine();
        }
    }
}
