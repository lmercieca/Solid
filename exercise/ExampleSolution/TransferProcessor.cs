using System.Collections.Generic;

namespace ExampleSolution
{
    public class TransferProcessor
    {
        private ITransactionLogger transactionLogger;
        private INotificationSender notificationSender;

        public TransferProcessor(ITransactionLogger transactionLogger, INotificationSender notificationSender)
        {
            this.transactionLogger = transactionLogger;
            this.notificationSender = notificationSender;
        }

        public void Transfer(IAccount transferor, IAccount tranferee, decimal amount)
        {
            transferor.Withdraw(amount);
            tranferee.Deposit(amount);

            var transactionMessage = $"Transferred £{amount} from {transferor.AccountNumber} to {tranferee.AccountNumber}.";

            transactionLogger.Log(transactionMessage);

            notificationSender.SendNotification(
                "grad-academy-solid@sfwltd.co.uk",
                new List<string> {transferor.RetrieveNotificationEmail(),
                    tranferee.RetrieveNotificationEmail() },
                "Transfer notification",
                transactionMessage);
        }
    }
}
