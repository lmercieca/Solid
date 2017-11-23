using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExampleSolution
{
    public class Payment
    {
        public Payment(IAccount toAccount, string instruction, decimal amount)
        {
            ToAccount = toAccount;
            Instruction = instruction;
            Amount = amount;
        }

        public IAccount ToAccount { get; }

        public decimal Amount { get; }

        public string Instruction { get; }
    }
}
