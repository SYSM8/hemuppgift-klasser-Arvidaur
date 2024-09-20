using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    public class BankAccount
    {
        //properties
        public string accountNumber { get; set; }
        public string accountHolder { get; set; }
        public double balance {  get; set; }

        //Constructor
        public BankAccount(string accountNumber, string accountHolder, double balance) 
        { 
            this.accountNumber = accountNumber;
            this.accountHolder = accountHolder;
            this.balance = balance;
        }
        public void Deposit(double input)
        {
            balance += input;
            Console.WriteLine($"Deposited {input}kr. New balance is {balance}kr");
        }

        public void Withdraw(double amount)
        {
            if (amount <= balance)
            {
                balance -= amount;
                Console.WriteLine($"Withdrew {amount}. New balance is {balance}kr.");
            }
            else
            {
                Console.WriteLine($"You don't have {amount}kr on your account");
            }
        }

        public void DisplayBalance()
        {
            Console.WriteLine($"You have {balance}kr on your account");
        }   
    }   
}
