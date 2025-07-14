using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioInterfacePagamento.Services
{
    internal class PaypalService : IOnlinePaymentService
    {
        public const double TaxPerInstaliment = 0.01;
        public const double TaxPerPayment = 0.02;
        public double PaymentFee(double amount)
        {
            return TaxPerPayment * amount;
        }
        public double Interest(double amaount, int months)
        {
            return TaxPerInstaliment * amaount * months;
        }
    }
}
