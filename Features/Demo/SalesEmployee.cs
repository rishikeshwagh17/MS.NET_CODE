using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR
{
    public sealed class SalesEmployee : Employee
    {
        public SalesEmployee(string fname, string lname, string email, string contact, int id, string location, int hours,double charges,double target, double achievement, double incentive) : base(fname, lname, email, contact, id, location, hours,charges)
        {
            this.Target = target;
            this.Achievement =achievement;
            this.Incentive = incentive;
        }

        public double Target { get; set; }
        public double Achievement { get; set; }
        public double Incentive { get; set; }

        public override string ToString()
        {
            return base.ToString() + " achievement=" + this.Achievement + " Target=" + this.Target + " incentives=" + this.Incentive; 
        }

        public override double computePay()
        {
            double salary = 0;
            if (Achievement > Target)
            {
                salary = Incentive + base.computePay();
            }
            else 
            {
                salary = base.computePay();
            }
            return salary;
        }


        public override void DoWork()
        {
            Console.WriteLine("Sales employee is doing his work");
        }
    }
}
