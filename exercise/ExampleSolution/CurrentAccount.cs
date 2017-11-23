using System;
using System.Collections.Generic;
using System.Configuration;

namespace ExampleSolution
{
    public class CurrentAccount : IAccount, IPaymentAccount
    {
        private List<Payment> recurringPayments = new List<Payment>();

        public CurrentAccount(int accountNumber, decimal balance)
        {
            AccountNumber = accountNumber;
            Balance = balance;
        }

        public int AccountNumber { get; }

        public decimal Balance { get; private set; }

        public string RetrieveNotificationEmail()
        {
            return ConfigurationManager.AppSettings["address"];
        }

        public void AddRecurringPayment(Payment recurringPayment)
        {
            recurringPayments.Add(recurringPayment);
        }

        public List<Payment> GetRecurringPayments()
        {
            return recurringPayments;
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
