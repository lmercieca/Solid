using System.Collections.Generic;
using System.Text;

namespace BadCodeExample
{
    public class RecurringPaymentProcessor
    {
        private TransactionLogger transactionLogger = new TransactionLogger();

        public void ProcessPayments(List<IAccount> accounts)
        {
            foreach (var account in accounts)
            {
                if (account is CurrentAccount)
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
}
