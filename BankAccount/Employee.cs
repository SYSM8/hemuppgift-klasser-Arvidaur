using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    public class Employee
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int salary { get; set; }

        //Constructor
        public Employee(string firstName, string lastName, int salary)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.salary = salary;
        }

        public int GetAnnualSalary()
        {
            return salary * 12;
        }

        public void GiveRaise(double percentage)
        {
            double raisefactor = percentage / 100 + 1;
            salary = (int)(salary * raisefactor);
        }
    }
}
