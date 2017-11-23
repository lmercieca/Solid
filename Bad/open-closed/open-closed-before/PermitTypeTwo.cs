namespace open_closed_before
{
    public class PermitTypeTwo
    {
        public int Quantity { get; set; }

        public int Factor { get; set; }

        public int Cost()
        {
            return Quantity + Factor;
        }
    }
}
