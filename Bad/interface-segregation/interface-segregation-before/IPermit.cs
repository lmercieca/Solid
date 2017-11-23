namespace interface_segregation_after
{
    interface IPermit
    {
        int Cost();

        Site Site { get; }
    }
}
