using ExercicioInterfacePagamento.Entities;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioInterfacePagamento.Services
{
    internal class ContractProcessing
    {
        private IOnlinePaymentService _iOnlinePaymentService;

        public ContractProcessing(IOnlinePaymentService iOnlinePaymentService)
        {
            _iOnlinePaymentService = iOnlinePaymentService;
        }

        public void Process(ContractTrab contract, int months)
        {
            double InstalimentSimple = contract.TotalValue / months;

            for (int i = 1; i <= months; i++)
            {
                DateTime date = contract.Date.AddMonths(i);
                double TaxPerInstaliment = InstalimentSimple +  _iOnlinePaymentService.Interest(InstalimentSimple, i);
                double TaxPerPayment = TaxPerInstaliment + _iOnlinePaymentService.PaymentFee(TaxPerInstaliment);
                contract.AddInstaliment(new Instaliment(date, TaxPerPayment));
            }
        }
    }
}
