using System;

namespace interface_segregation_after
{
    public class Permit : IPermit, ICostPermit
    {
        public Site Site
        {
            get
            {
                return new Site() { Address = "address", Name = "name" };
            }
        }

        public int Cost()
        {
            return 999;
        }
    }
}
