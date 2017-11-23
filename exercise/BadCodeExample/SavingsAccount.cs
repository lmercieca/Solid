using System;
using System.Collections.Generic;
using System.Configuration;

namespace BadCodeExample
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

        public void AddRecurringPayment(Payment recurringPayment)
        {
            throw new InvalidOperationException("Recurring payments are not supported for a savings account");
        }

        public List<Payment> GetRecurringPayments()
        {
            throw new InvalidOperationException("Recurring payments are not supported for a savings account");
        }

        public void Deposit(decimal amount)
        {
            Balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            Balance -= amount;
        }
    }
}
