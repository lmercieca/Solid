using System.Collections.Generic;
using System.Configuration;
using System.Net.Mail;

namespace single_responsibility_before
{
    public class Permits
    {
        private static List<Permit> _Items = new List<Permit>();

        public void Add(Permit permit)
        {
            _Items.Add(permit);

            var message = new MailMessage();
            message.To.Add(ConfigurationManager.AppSettings["address"]);
            message.From = new MailAddress(ConfigurationManager.AppSettings["address"]);
            message.Subject = string.Format("Add Order {0}", permit.Number);

            SmtpClient client = new SmtpClient("ms02.main.sfwltd.co.uk");
            client.Send(message);
        }
    }
}
