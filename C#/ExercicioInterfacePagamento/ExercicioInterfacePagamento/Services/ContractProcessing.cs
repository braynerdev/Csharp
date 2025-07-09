using ExercicioInterfacePagamento.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioInterfacePagamento.Services
{
    internal class ContractProcessing
    {
        private OnlinePaymentService _onlinePaymentService;

        public ContractProcessing(OnlinePaymentService onlinePaymentService)
        {
            _onlinePaymentService = onlinePaymentService;
        }

        public void ProcessContract(Contract contract, int months)
        {
            double valuePerMouth = contract.TotalValue / months;
            for (int i = 1; i <= months; i++)
            {
                contract.Date.AddMonths(i);

            }
        }
    }
}
