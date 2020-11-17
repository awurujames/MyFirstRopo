using System;
namespace AccountTest4
{
    class Program
    {
        static void Main(string[] args)
        {
            // the m denotes decimal
            Account account = new Account("James Stuart", 5000M);
            account.Deposit(50000M);
            account.GetAccountDetails();
            account.Withdrawal(1000M);
        }
    }
}