using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking
{
    public class Account
    {
        public double Balance { get; set; }
        public Account(double amount)
        {
            this.Balance = amount;
            if (amount < 2000)
            {
                throw new Exception("account cannot be created because amount is less");


            }
            else
            {
                Console.WriteLine("account cretated sucessfully");
            }
        }
        public void Deposit(double amount)
        {
            this.Balance = this.Balance + amount;
        }

        public void Withdraw(double amount)
        {
            this.Balance = this.Balance - amount;
        }

        public override string ToString()
        {
            return Balance.ToString();
        }

    }
}
