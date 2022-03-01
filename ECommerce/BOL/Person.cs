using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL
{
    public class Person
    {
        public int Id { get; set; }
        
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string address { get; set; }
        public static int count = 0;

            public Person() {
                this.Id = 1;
                this.firstName = "rishi";
                this.lastName = "wagh";
            }

        public Person(int id, string fname, string lname, string address) {

            this.Id = id;
            this.firstName=
        }

    }
   
}
