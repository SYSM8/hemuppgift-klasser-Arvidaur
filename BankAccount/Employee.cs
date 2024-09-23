using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    public class Employee
    {
        private string firstName;
        private string lastName;
        private double salary;
        private int age;

        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
            }
        }

        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value > 0)
                {
                    age = value;
                }
                else
                {
                    Console.WriteLine("Age cannot be a negative number");
                }
            }
        }

        public double Salary
        {
            get
            {
                return salary;
            }
            set
            {
                if (value > 0)
                {
                    salary = value;
                }
                else
                {
                    Console.WriteLine("Salary must be positive");
                }
            }
        }

        //Constructor
        public Employee(string firstName, string lastName, double salary, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            Salary = salary;
            Age = age;
        }

        public double GetAnnualSalary()
        {
            return Salary * 12;
        }

        public void GiveRaise(double percentage)
        {
            Salary = Salary * (percentage / 100 + 1);
        }

        public void DisplayEmployeeInfo()
        {
            Console.WriteLine($"Employee's name is {firstName} {lastName}. Mr/ms {lastName} is {age} years old.");
        }
    }
}
