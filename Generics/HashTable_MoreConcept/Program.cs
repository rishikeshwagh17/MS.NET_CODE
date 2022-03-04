using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace HashTable_MoreConcept
{
    public class Program
    {
        static void Main(string[] args)
        {
            //items is accessed in hashtable by using its key
            //method - add,remove,clear

            Hashtable ht = new Hashtable();
            ht.Add("id", 1123);
            ht.Add("name", "rishi");
            ht.Add("salary", 25000);
            ht.Add("designation", "manager");

            foreach (var key in ht.Keys)
            {
                Console.WriteLine(key + " : " + ht[key]);
            }
            //foreach (var value in ht.Values)
            //{
            //    Console.WriteLine(value);
            //}

            ht.Remove("salary");
            
            Console.WriteLine("----------");
            
            foreach (var key in ht.Keys)
            {
                Console.WriteLine(key + " : " + ht[key]);
            }
            //clear method removes all elements
            //ht.Clear();
            Console.WriteLine("----------");
            
            //Contains and ConatinsKey method
            Console.WriteLine(ht.Contains("name"));

            //Contains value method true or false
            Console.WriteLine("----------");
            Console.WriteLine(ht.ContainsValue("rishi"));

            //getHashCode return hashcode for each element of hashcode it is assign to each key
            Console.WriteLine("----------");
            Console.WriteLine("rishi".GetHashCode());

            //props of hashtable -count,keys,values(keys and values use in foreach loop)
            Console.WriteLine(ht.Count);
            Console.ReadLine();
        }
    }
}
