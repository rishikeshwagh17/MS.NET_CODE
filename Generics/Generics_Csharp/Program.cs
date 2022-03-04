using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_Csharp
{
    public class arrayExp 
    {
        //normal way but if we want for string type of array or any other type of data then we have to overload
        //this function for each data type ---- solution is use generics

        //public static void ShowArray(int[] arr) {
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        Console.Write(arr[i] + " ");
        //    }
        //}



        //generic method
        // T here is any data type (placeholder)
        /*
         * generics allow us to write a class or method that can work with any data type
         * generics allow us to write class with placeholders for the type of its fields methods parameters
         * by replacing placeholders with some specific type of compile time
        */
        public static void Showarr<T>(T[] arr) {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            int [] arr = { 1, 2, 3 };
            arrayExp.Showarr(arr);

            string[] names = { "rishi", "kaka", "baba", "nana" };
            arrayExp.Showarr(names);
            
            Console.ReadLine();
        }
    }
}
