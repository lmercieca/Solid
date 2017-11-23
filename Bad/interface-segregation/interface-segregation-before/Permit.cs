using System;

namespace interface_segregation_after
{
    public class Permit : IPermit
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
