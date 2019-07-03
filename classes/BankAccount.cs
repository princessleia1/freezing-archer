using System;
using System.Collections.Generic;

namespace classes
{
    public class BankAccount
    // Define behaviour of class members
    {
        // Declare properties of data elements
        public string Number { get; }
        public string Owner { get; set; }
        public decimal Balance { get; }
        private static int accountNumberSeed = 1234567890;

        //private List<Transaction> allTransactions = new List<Transaction>();

        // Define methods perform single function of reading names
        public void MakeDeposit(decimal amount, DateTime date, string note)
        {
        }

        public void MakeWithdrawal(decimal amount, DateTime date, string note)
        {
        }

        public BankAccount(string name, decimal initialBalance)
        {
            this.Owner = name;
            this.Balance = initialBalance;
            // Increment 10 digit account number with each new account created
            this.Number = accountNumberSeed.ToString();
            accountNumberSeed++;
        }
    }
    
}