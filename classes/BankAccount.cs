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
        //public decimal Balance { get; }
        private static int accountNumberSeed = 1234567890;

        public decimal Balance
        {
            get
            {
                decimal balance = 0;
                foreach (var item in allTransactions)
                {
                    balance += item.Amount;
                }

                return balance;
            }
        }

        private List<Transaction> allTransactions = new List<Transaction>();

        // Define methods perform single function of reading names
        public void MakeDeposit(decimal amount, DateTime date, string note)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of Deposit must be Positive");
            }
            var deposit = new Transaction(amount, date, note);
            allTransactions.Add(deposit);
        }
        // Define method for withdrawal and create exceptions
        public void MakeWithdrawal(decimal amount, DateTime date, string note)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of Withdrawal must be Positive");
            }
            if (Balance - amount < 0)
            {
                throw new InvalidOperationException("No Sufficient Funds for this Withdrawal");
            }
            var withdrawal = new Transaction(-amount, date, note);
            allTransactions.Add(withdrawal);
        }
        // Define method for incrementing account number and owner name
        public BankAccount(string name, decimal initialBalance)
        {
            this.Number = accountNumberSeed.ToString();
            accountNumberSeed++;

            this.Owner = name;
            MakeDeposit(initialBalance, DateTime.Now, "Initial Balance");
        }
        // Define method to log all transactions
        public string GetAccountHistory()
        {
            var report = new System.Text.StringBuilder();

            report.AppendLine("Date\tAmount\tNote");
            foreach (var item in allTransactions)
            {
                report.AppendLine($"{item.Date.ToShortDateString()}\t{item.Amount}\t{item.Notes}");
            }

            return report.ToString();
        }
    }
}