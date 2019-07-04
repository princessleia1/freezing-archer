using System;

namespace classes
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount("Princess Leia", 1000);
            // Console.WriteLine("Hello World!"); 
            Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance} initial balance.");
            account.MakeWithdrawal(500, DateTime.Now, "House Payment");
            Console.WriteLine(account.Balance);
            account.MakeDeposit(100, DateTime.Now, "Income Deposit");
            Console.WriteLine(account.Balance);
            // Log all transactions
            Console.WriteLine(account.GetAccountHistory());
        }
    }
}
