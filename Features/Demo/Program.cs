using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using HR;
using Banking;
using CustomerRelationship;
namespace Demo
{
    public class Program 
    {
        static void Main(string[] args) 
        {
            Account acct1 = new Account(50000);
            Customer c1 = new Customer(10, "rishi", "wagh", "rishi.wagh1708@gmail.com", "9021111111", acct1);
            Account acct2 = new Account(50000);
            Customer c2 = new Customer(11, "swapnil", "gaikwad", "swapnil123@gmail.com", "9023232323", acct2);

            Console.WriteLine("--------------------------------------");
            try
            {
                Account acct = new Account(1000);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally {
                Console.WriteLine("this code always get executed because this is in finally block");
            }

            SalesEmployee saleemp1 = new SalesEmployee("ravi", "sir", "ravisir123@gmail.com", "1231231231", 11, "pune", 12, 5000.00, 10000, 20000, 5000);
            saleemp1.DoWork();
            double salary = saleemp1.computePay();
            Console.WriteLine("salary at month end");
            Console.WriteLine("sales employee salary ={0}", salary);
        }
    
    }

}
