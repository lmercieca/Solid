using System.Collections.Generic;

namespace ExampleSolution
{
    public interface IPaymentAccount : IAccount
    {
        void AddRecurringPayment(Payment recurringPayment);

        List<Payment> GetRecurringPayments();
    }
}
