using System.Collections.Generic;
using System.Text;

namespace ExampleSolution
{
    public class RecurringPaymentProcessor
    {
        private ITransactionLogger transactionLogger;

        public RecurringPaymentProcessor(ITransactionLogger transactionLogger)
        {
            this.transactionLogger = transactionLogger;
        }

        public void ProcessPayments(List<IPaymentAccount> accounts)
        {
            foreach (var account in accounts)
            {
                StringBuilder builder = new StringBuilder();
                builder.AppendLine($"Account number: {account.AccountNumber}");
                builder.AppendLine("Payments: ");

                foreach (var payment in account.GetRecurringPayments())
                {
                    builder.AppendLine($"To: {payment.ToAccount.AccountNumber}, Amount: £{payment.Amount}, Instruction: {payment.Instruction}");
                }

                transactionLogger.Log(builder.ToString());
            }
        }
    }
}
