namespace BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount account1 = new BankAccount("123456789", "John Doe", 1000);
            Console.WriteLine(account1.accountHolder);
            account1.Deposit(500);
            account1.Withdraw(200);
            account1.DisplayBalance();

            //Withdraw the precise amount that's on the account
            BankAccount account2 = new BankAccount("987654321", "Jane Doe", 2000);
            Console.WriteLine(account2.accountHolder);
            account2.Deposit(100);
            account2.Withdraw(2100);
            account2.DisplayBalance();

            //Attempt to withdraw more money then is on the account
            BankAccount account3 = new BankAccount("987654321", "Baby Doe", 20);
            Console.WriteLine(account3.accountHolder);
            account3.Deposit(50);
            account3.Withdraw(10000);
            account3.DisplayBalance();




            Employee employee1 = new Employee("Arvid", "Rönnkvist", 35000);
            Console.WriteLine($"Monthly salary: {employee1.salary}");
            Console.WriteLine($"Annual salary: {employee1.GetAnnualSalary()}");

            employee1.GiveRaise(10);

            Console.WriteLine($"New Monthly Salary: {employee1.salary}");
            Console.WriteLine($"New Annual Salary: {employee1.GetAnnualSalary()}");

            //Instansiera bankAccount klassen och testa den

        }
    }
}
