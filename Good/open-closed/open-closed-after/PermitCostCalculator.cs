using System.Collections.Generic;

namespace open_closed_after
{
    public class PermitCostCalculator
    {
        public int TotalCost(IEnumerable<Permit> permits)
        {
            var total = 0;

            foreach(var permit in permits)
            {
                total += permit.Cost();
            }

            return total;
        }
    }
}
