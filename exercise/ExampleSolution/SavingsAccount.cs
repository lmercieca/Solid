using System;
using System.Configuration;

namespace ExampleSolution
{
    public class SavingsAccount : IAccount
    {
        public SavingsAccount(int accountNumber, decimal balance)
        {
            AccountNumber = accountNumber;
            Balance = balance;
        }

        public int AccountNumber { get; }

        public decimal Balance { get; set; }

        public string RetrieveNotificationEmail()
        {
            return ConfigurationManager.AppSettings["address"];
        }

        public void Deposit(decimal amount)
        {
            Balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            if (Balance - amount < 0)
            {
                throw new InvalidOperationException("Overdrafts are not allowed for savings accounts");
            }

            Balance -= amount;
        }
    }
}
