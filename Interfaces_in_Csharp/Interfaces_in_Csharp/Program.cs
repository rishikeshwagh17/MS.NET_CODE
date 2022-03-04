using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_in_Csharp
{
    public interface IEmployee
    {
        //interface cannot contain static fields like java
        //interface only contains methods with no definitions just like abstract class (similar to java)
        //you cannot add specifier in interface
        //interface implementation is similar to inherting the class ( : ) symbol in java we use implements keyword
        void show();
        
    }

    public class PartEmployee : IEmployee
    {
        public void show() {
            Console.WriteLine("hello guys");
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
