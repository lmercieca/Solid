using System.Collections.Generic;

namespace open_closed_before
{
    public class PermitCostCalculator
    {
        public int TotalCost(IEnumerable<object> permits)
        {
            var total = 0;

            foreach(var permit in permits)
            {
                if (permit is PermitTypeOne)
                {
                    total += ((PermitTypeOne)permit).Cost();
                }
                else if (permit is PermitTypeTwo)
                {
                    total += ((PermitTypeTwo)permit).Cost();
                }
            }

            return total;
        }
    }
}
