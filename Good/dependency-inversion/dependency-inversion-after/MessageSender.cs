using System.Configuration;
using System.Net.Mail;

namespace dependency_inversion_after
{
    public class MessageSender : IMessageSender
    {
        public void Send(string number)
        {
            var message = new MailMessage();
            message.To.Add(ConfigurationManager.AppSettings["address"]);
            message.From = new MailAddress(ConfigurationManager.AppSettings["address"]);
            message.Subject = string.Format("Add Order {0}", number);

            SmtpClient client = new SmtpClient("ms02.main.sfwltd.co.uk");
            client.Send(message);
        }
    }
}
