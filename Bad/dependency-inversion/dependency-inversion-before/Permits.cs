using System.Collections.Generic;

namespace dependency_inversion_before
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
