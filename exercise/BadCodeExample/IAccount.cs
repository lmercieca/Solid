using System.Collections.Generic;

namespace BadCodeExample
{
    public interface IAccount
    {
        int AccountNumber { get; }

        decimal Balance { get; }

        void Withdraw(decimal amount);

        void Deposit(decimal amount);

        void AddRecurringPayment(Payment recurringPayment);

        List<Payment> GetRecurringPayments();

        string RetrieveNotificationEmail();
    }
}
