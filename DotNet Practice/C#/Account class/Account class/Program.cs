using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account_class
{
    internal class Program
    {
        public class Account
        {
            public double Balance { get; private set; }
            public string AccountType { get; private set; }

            // Event declarations
            public event EventHandler<TransactionEventArgs> ProcessingTransaction;
            public event EventHandler<TransactionEventArgs> TransactionComplete;

            public Account(double balance, string accountType)
            {
                Balance = balance;
                AccountType = accountType;
            }

            public void ProcessTransaction(double amount)
            {
                // Raise the ProcessingTransaction event
                OnProcessingTransaction(new TransactionEventArgs(Balance, AccountType, amount));

                // Process the transaction (for simplicity, assuming a deposit if amount is positive, withdrawal if negative)
                Balance += amount;

                // Raise the TransactionComplete event
                OnTransactionComplete(new TransactionEventArgs(Balance, AccountType, amount));
            }

            protected virtual void OnProcessingTransaction(TransactionEventArgs e)
            {
                ProcessingTransaction?.Invoke(this, e);
            }

            protected virtual void OnTransactionComplete(TransactionEventArgs e)
            {
                TransactionComplete?.Invoke(this, e);
            }
        }

        public class TransactionEventArgs : EventArgs
        {
            public double Balance { get; private set; }
            public string AccountType { get; private set; }
            public double Amount { get; private set; }

            public TransactionEventArgs(double balance, string accountType, double amount)
            {
                Balance = balance;
                AccountType = accountType;
                Amount = amount;
            }
        }

        class Accountclass
        {
            static void Main()
            {
                Account account = new Account(1000, "Checking");

                // Subscribe to events
                account.ProcessingTransaction += OnProcessingTransaction;
                account.TransactionComplete += OnTransactionComplete;

                // Process a transaction
                account.ProcessTransaction(200);  // Deposit
                account.ProcessTransaction(-150); // Withdrawal
            }

            static void OnProcessingTransaction(object sender, TransactionEventArgs e)
            {
                Console.WriteLine($"Processing Transaction: {e.Amount} on {e.AccountType} account. Current balance: {e.Balance}");
            }

            static void OnTransactionComplete(object sender, TransactionEventArgs e)
            {
                Console.WriteLine($"Transaction Complete: New balance is {e.Balance} on {e.AccountType} account.");
            }
        }


    }
}
