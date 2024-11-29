using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDesignPatternExample
{
    public class PaymentContext
    {
        private IPaymentStrategy _paymentStrategy;

        // Allow the strategy to be set at runtime
        public void SetPaymentStrategy(IPaymentStrategy paymentStrategy)
        {
            _paymentStrategy = paymentStrategy;
        }

        public void ProcessPayment(decimal amount)
        {
            if (_paymentStrategy == null)
            {
                Console.WriteLine("Payment method not set.");
                return;
            }

            _paymentStrategy.Pay(amount);
        }
    }

}
