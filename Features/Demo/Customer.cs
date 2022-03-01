using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using HR;
using Banking;
namespace CustomerRelationship
{
    public  partial class Customer:Person
    {
        public int Id { get; set; }
        public Customer(int id,string fname, string lname, string email, string contact,Account acct ) : base(fname, lname, email, contact)
        {
            Id = id;
            BankAccount = acct;
        }
        public override string ToString()
        {
            return this.Id + " " + this.BankAccount + " " + base.ToString();
        }
    }
}