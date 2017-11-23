using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;

namespace BadCodeExample
{
    public class TransferProcessor
    {
        private TransactionLogger transactionLogger = new TransactionLogger();

        public void Transfer(IAccount transferor, IAccount tranferee, decimal amount)
        {
            if (transferor is SavingsAccount &&
                transferor.Balance - amount < 0)
            {
                throw new InvalidOperationException("Overdrafts are not allowed for savings accounts");
            }

            transferor.Withdraw(amount);
            tranferee.Deposit(amount);

            var transactionMessage = $"Transferred £{amount} from {transferor.AccountNumber} to {tranferee.AccountNumber}.";

            transactionLogger.Log(transactionMessage);

            using (var message = new MailMessage())
            using (var client = new SmtpClient("ms02.main.sfwltd.co.uk"))
            {
                message.To.Add(tranferee.RetrieveNotificationEmail());
                message.To.Add(transferor.RetrieveNotificationEmail());

                message.From = new MailAddress("grad-academy-solid@sfwltd.co.uk");
                message.Subject = "Transfer notification";
                message.Body = transactionMessage;

                client.Send(message);
            }
        }
    }
}
