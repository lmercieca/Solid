using System;
using System.Collections.Generic;

namespace BadCodeExample
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

            var transferProcessor = new TransferProcessor();
            transferProcessor.Transfer(currentAccount, savingsAccount, 10);
        }

        static void RecurringPaymentsExample()
        {
            Console.WriteLine("Recurring payments example");

            var savingsAccount = new SavingsAccount(111, 100);
            var currentAccount = new CurrentAccount(222, 20);

            currentAccount.AddRecurringPayment(new Payment(savingsAccount, "Monthly savings", 10));

            var accounts = new List<IAccount>() { savingsAccount, currentAccount };

            var recurringPaymentProcessor = new RecurringPaymentProcessor();
            recurringPaymentProcessor.ProcessPayments(accounts);
        }
    }
}
