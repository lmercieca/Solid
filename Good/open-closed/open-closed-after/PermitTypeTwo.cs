namespace open_closed_after
{
    public class PermitTypeTwo : Permit
    {
        public override int Cost()
        {
            return Quantity + Factor;
        }
    }
}
