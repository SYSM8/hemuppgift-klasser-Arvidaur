using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    public class Employee
    {
        public string firstName = { get; set; }
        public string lastName = { get; set; }
        public int salary = { get; set; }

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
            percentage = percentage / 100 + 1;
            Console.WriteLine($"Percentage {percentage}");
            salary *= percentage;
        }
}
