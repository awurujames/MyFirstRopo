using System;

namespace AccountTest2
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account();

            Console.Write("Please enter your account name: ");
            string name = Console.ReadLine();

            account.SetName(name);

            Console.Write("Please enter your initial balance: ");
            decimal balance = Convert.ToDecimal(Console.ReadLine());

            account.SetBalance(balance);

            Console.WriteLine($"Account name - {account.GetName()}\nAccount balance - {account.GetBalance():C}");

        }
    }
}
