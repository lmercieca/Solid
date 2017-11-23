using System.Collections.Generic;

namespace ExampleSolution
{
    public interface INotificationSender
    { 
        void SendNotification(string sender, List<string> recipients,
            string subject, string contents);
    }
}
