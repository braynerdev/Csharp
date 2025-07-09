using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioInterfacePagamento.Services
{
    internal class PaypalService : OnlinePaymentService
    {
        private const double FeePercentage = 0.02;
        private const double MonthlyInterest = 0.01;
        public double PaymentFee(double amount)
        {
            return  amount * FeePercentage;
        }
        public double Interest(double amount, int months)
        {
            return amount * MonthlyInterest * months;
        }
    }
}
