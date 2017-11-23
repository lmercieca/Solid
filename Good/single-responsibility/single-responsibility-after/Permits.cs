using System.Collections.Generic;

namespace single_responsibility_after
{
    public class Permits
    {
        private static List<Permit> _Items = new List<Permit>();
        private MessageSender _messageSender = new MessageSender();

        public void Add(Permit permit)
        {
            _Items.Add(permit);

            _messageSender.Send(permit.Number);
        }
    }
}
