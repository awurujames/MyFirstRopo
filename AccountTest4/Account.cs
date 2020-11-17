using System;
namespace AccountTest4
{
    public class Account
    {
        // creating an auto implented property
        public string Name { get; set; }
        public decimal Balance { get; set; }
        // creating a constructor
        public Account(string name, decimal balance)
        {
            Name = name;
            Balance = balance;
        }
        public void Deposit(decimal depositAmount)
        {
            if (depositAmount > 0.0M)
            {
                Balance = Balance + depositAmount;
                Console.WriteLine($"Deposit of {depositAmount:C} was succesful\n Your new balance is {Balance:C}");
            }
        }
        public void GetAccountDetails()
        {
            Console.WriteLine($"========Account Details======\nAccount holder name -{Name}\nCurrent balance - {Balance:C}");
        }
        public void Withdrawal(decimal withdrawalAmount)
        {
            Balance = Balance - withdrawalAmount;
            Console.WriteLine($"Withdrawal of {withdrawalAmount:C} was succesful\n Your new balance is {Balance:C}");
        }
    }



}