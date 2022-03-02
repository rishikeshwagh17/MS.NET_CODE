using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexers_concept
{
    public class Program
    {
        class Indexer
        {
            //suppose we want to store values in this array we can store them using logic with the help
            //of indexers
            private string[] name = new string[3];
            
           //indexer allows object to be used as an array like index for object (obj[index])
           // we can say indexers are special typeof of properties which adds logic that
           // how can array or list stores the values
            public string this[int index]
            {
                get { return name[index]; }
                set { name[index] = value; }
            }

        }
        static void Main(string[] args)
        {
            Indexer app = new Indexer();
            app[0] = "rishi";
            app[1] = "swapnil";
            app[2] = "kunal";

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(app[i]);
            }
            Console.ReadKey();
        }
    }
}
