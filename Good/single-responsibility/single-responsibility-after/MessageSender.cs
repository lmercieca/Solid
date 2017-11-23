using System.Configuration;
using System.Net.Mail;

namespace single_responsibility_after
{
    public class MessageSender
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
