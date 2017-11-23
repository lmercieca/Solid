using System;
using System.Collections.Generic;
using System.Linq;

namespace ExampleSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            TransferExample();
            RecurringPaymentsExample();

            Console.ReadKey();
        }

        static void TransferExample()
        {
            Console.WriteLine("Transfer example");

            var savingsAccount = new SavingsAccount(111, 100);
            var currentAccount = new CurrentAccount(222, 20);

            var transactionLogger = new TransactionLogger();
            var notificationSender = new NotificationSender();

            var transferProcessor = new TransferProcessor(transactionLogger, notificationSender);
            transferProcessor.Transfer(currentAccount, savingsAccount, 10);
        }

        static void RecurringPaymentsExample()
        {
            Console.WriteLine("Recurring payments example");

            var savingsAccount = new SavingsAccount(111, 100);
            var currentAccount = new CurrentAccount(222, 20);

            currentAccount.AddRecurringPayment(new Payment(savingsAccount, "Monthly savings", 10));

            // Savings account no longer allowed in the list as it's not an IPaymentAccount
            var paymentAccounts = new List<IPaymentAccount>() { currentAccount };

            var transactionLogger = new TransactionLogger();

            var recurringPaymentProcessor = new RecurringPaymentProcessor(transactionLogger);

            // Must filter by IPaymentAccount before processing as this is not correctly enforced.
            recurringPaymentProcessor.ProcessPayments(paymentAccounts);
        }
    }
}
