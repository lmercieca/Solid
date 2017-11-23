using System;

namespace interface_segregation_after
{
    public class FreePermit : IPermit
    {
        public Site Site
        {
            get
            {
                return new Site() { Address = "freeAddress", Name = "freeName" };
            }
        }
    }
}
