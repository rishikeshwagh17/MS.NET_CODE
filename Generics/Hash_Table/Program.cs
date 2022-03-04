using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hash_Table
{
    //hashtable is non generic collection
    //array -- collection of homogenous elements (same data type)
    //collections -- collections of heterogenous elements (any data at any index or same data also)

    //hashtable stores value store in key value format (same as a array and arralist (index, value))
    //in arrays and arralist key is index only but for hashtable key can be anything
    public class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add("id", 1123);
            ht.Add("name", "rishi");
            ht.Add("salary", 25000);
            ht.Add("designation", "manager");

            //way of getting access to value in hashTable
            Console.WriteLine(ht["id"]);

            Console.WriteLine("-------------");
            //another way of writing hashTable
            Hashtable ht1 = new Hashtable() 
            {
                {"id",1110 },{"name","rishi" },{"salary",22000},{"design","coder"}
            };
            Console.WriteLine(ht1["name"]);
            Console.ReadLine();
        }
    }
}
