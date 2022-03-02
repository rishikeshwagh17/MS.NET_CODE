using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sealed_Class
{
    public class a
    {
        public virtual void print() 
        {
            Console.WriteLine("a class method");
        }
    }

    public class b :a
    {
        public sealed override void print() {
            Console.WriteLine("this is b class sealed method");
        }
        
        // if we mention the sealed on method then another class c which inherits b cannot
        // override this sealed method
        // try to create and see compile time error cannot use sealed method
    }

    
}
