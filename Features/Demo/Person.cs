using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR
{
    public class Person
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public string ContactNumber { get; set; }

        public Person(string fname, string lname, string email, string contact) {

            this.firstName = fname;
            this.lastName = lname;
            this.email = email;
            this.ContactNumber = contact;
        }

        public override string ToString()
        {
            //base.ToString(); base classes to string method
            return firstName + " " + lastName + " " + email + " " + ContactNumber;
        }

    }
}
