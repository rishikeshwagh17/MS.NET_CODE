using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_class
{
    /*
 * generic class define functionalities that can be use for any data type and are declared with 
 * class dec followed bt type  parameter enclosed within angular brackets
 */
    class Example<T> {
        T box;
        public Example(T b)
        {
            this.box = b;
            Console.WriteLine(this.box);
        }

        public T MyProperty {
            get 
            {
                return this.box;
            }
            set 
            {
                this.box = value;
            } 
        }
        public void method(T para) {
            Console.WriteLine("value of parameter is {0}",para);
            Console.WriteLine(para.GetType());
        }

    }
      
    public class Program
    {
        
        static void Main(string[] args)
        {
            Example<string> example = new Example<string>("rishi");
            example.MyProperty = "baba";
            Console.WriteLine(example.MyProperty);
            example.method("bapu");
            Console.ReadLine();
        }
    }
}
