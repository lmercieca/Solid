namespace open_closed_after
{
    public abstract class Permit
    {
        public int Quantity { get; set; }

        public int Factor { get; set; }

        public abstract int Cost();
    }
}
