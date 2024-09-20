namespace BankAccount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee("Arvid", "Rönnkvist", 89 000);

            Console.WriteLine($"Annual salary: {employee1.getAnnualSalary()}");

            employee1.GiveRaise(10);

            Console.WriteLine($"New Monthly Salary: {employee1.Salary}");
            Console.WriteLine($"New Annual Salary: {employee1.GetAnnualSalary()}");

            //Instansiera bankAccount klassen och testa den

        }
    }
}
