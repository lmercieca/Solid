using System.Collections.Generic;

namespace dependency_inversion_after
{
    public class Permits
    {
        private static List<Permit> _Items = new List<Permit>();
        private IMessageSender _messageSender;

        public Permits(IMessageSender messageSender)
        {
            _messageSender = messageSender;
        }

        public void Add(Permit permit)
        {
            _Items.Add(permit);

            _messageSender.Send(permit.Number);
        }
    }
}
