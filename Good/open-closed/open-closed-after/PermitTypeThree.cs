namespace open_closed_after
{
    public class PermitTypeThree : Permit
    {
        public override int Cost()
        {
            return Quantity - Factor;
        }
    }
}
