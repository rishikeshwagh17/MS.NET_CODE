using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace Collections_Csharp
{
    /*collections are dynamic they goes on increasing as we add values in them
     * AUTO RESIZING
     */
    public class Program
    {
        static void Main(string[] args)
        {
            //int[] myarr = new int[3];
            //myarr[0] = 1;
            //myarr[1] = 2;
            //myarr[2] = 3;
            //resize method destroys old array and create new array with new length

            /*dreawback of array is we can never insert value in the middle of an array
             * if we want to do this then we have to increase arrays length but we cannot increase arrays length
            */
            //also we cannot delete in the middle of an array
            //Array.Resize(ref myarr, 5);
            //myarr[0] = 1;
            //myarr[1] = 2;
            //myarr[2] = 22;
            //myarr[3] = 24;
            //myarr[4] = 29;
           
            //we can add any type of data into arraylist because in its add mrthod it accepts Object as a parameter
            ArrayList Mylist = new ArrayList();
            Mylist.Add(10);
            Mylist.Add("rishi");
            
            Console.WriteLine(Mylist.Capacity);
            //point to note arraylist capacity goes on increase by 2X each time once limit reach and add new element
            /*like add 1 in arraylist --- capacity 4
             * add 2 --- cap 4
             * add 3 --- cap4
             * add 4 --- cap4
             * add 5 --- cap8 (4 + 4) (Doubling)
             */
            foreach (var item in Mylist)
            {
                Console.WriteLine(item);
            }
            //inserting in between arraylist ele    (parameters index and value)
            Mylist.Insert(1, 25);
            //also we delete two ways directly pass value or pass index
            Mylist.Remove(25); //value
            Mylist.RemoveAt(1);
            foreach (var item in Mylist)
            {
                Console.Write(item + " ");
            }
            Console.ReadLine();
        }
    }
}
