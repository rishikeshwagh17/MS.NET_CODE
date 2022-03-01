using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR
{
    public abstract class Employee : Person
    {
        public int Id { get; set; }
        public string Location { get; set; }

        private int hours;


        public int Hours
        {

            get { return this.hours; }
            set
            {
                if (value < 10)
                {

                    throw new Exception("less work done");
                }
                else
                {
                    this.hours = value;
                }

            }
        }

            public double Charges { get; set; }

        public Employee(string fname, string lname, string email, string contact,int id,string location, int hours, double charges ) : base(fname, lname, email, contact)
        {
            this.Id = Id;
            this.Location =location;
            this.Charges = charges;
            this.hours = hours;
        }

        public override string ToString()
        {
            return this.Id + " " + this.Location + " " + base.ToString();
        }

        //virtual method is 
        public virtual double computePay() {

            double amount = Charges + Hours * 30;
            return amount;
        }

        //abstract method so we have to tell that class is abstract
        public abstract void DoWork();
    }

}

