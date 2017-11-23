namespace ExampleSolution
{
    public interface IAccount
    {
        int AccountNumber { get; }

        decimal Balance { get; }

        void Withdraw(decimal amount);

        void Deposit(decimal amount);

        string RetrieveNotificationEmail();
    }
}
