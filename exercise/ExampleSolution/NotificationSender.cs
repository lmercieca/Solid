using System.Collections.Generic;
using System.Net.Mail;

namespace ExampleSolution
{
    public class NotificationSender : INotificationSender
    {
        public void SendNotification(string sender, List<string> recipients, string subject, string contents)
        {
            using (var message = new MailMessage())
            using (var client = new SmtpClient("ms02.main.sfwltd.co.uk"))
            {
                foreach (var recipient in recipients)
                {
                    message.To.Add(recipient);
                }

                message.From = new MailAddress(sender);
                message.Subject = subject;
                message.Body = contents;

                client.Send(message);
            }
        }
    }
}
