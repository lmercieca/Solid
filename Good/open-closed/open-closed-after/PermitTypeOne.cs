namespace open_closed_after
{
    public class PermitTypeOne : Permit
    {
        public override int Cost()
        {
            return Quantity * Factor;
        }
    }
}
