using System;

namespace ExampleSolution
{
    public class TransactionLogger : ITransactionLogger
    {
        public void Log(string transactionMessage)
        {
            Console.WriteLine(transactionMessage);
        }
    }
}