using System;
namespace AccountTest3
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account();

            Console.Write("please enter the account name: ");
            account.Name = Console.ReadLine();

            Console.Write("please enter initial balance: ");
            account.Balance = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine($"Account name - {account.Name}");
            Console.WriteLine($"Account balance - {account.Balance:C}");
        }
    }
}
