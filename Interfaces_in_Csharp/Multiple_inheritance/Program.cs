using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiple_inheritance
{
    //multiple inheritance using classes is not possible because child gets confused
    //if it saws two methods with same signature and definition in its parent
    //so which parents method it uses is the ambiguity


    //multiple inheritance can be done using the two interface & also one class and other interface

    public class parent 
    {
        public void Show() {
            Console.WriteLine("parent class show method");
        }
    }
    interface I1
    {
        void Show();
    }
    public class Child : parent, I1
    {
        void I1.Show()
        {
            Console.WriteLine("this is interface method");
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            Child c = new Child();
            c.Show();
            ((I1)c).Show();
        }
    }
}
