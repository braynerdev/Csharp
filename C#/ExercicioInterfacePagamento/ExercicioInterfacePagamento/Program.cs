using ExercicioInterfacePagamento.Entities;
using ExercicioInterfacePagamento.Services;
using System;
using System.Diagnostics.Contracts;
using System.Globalization;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberContract = 8028;
            DateTime date = DateTime.ParseExact("25/06/2018","dd/MM/yyyy",CultureInfo.InvariantCulture);
            double Value = 600.00;
            int NInstallments = 3;

            ContractTrab contract = new ContractTrab(numberContract, date, Value);

            ContractProcessing contractProcessing = new ContractProcessing(new PaypalService());
            contractProcessing.Process(contract, NInstallments);

            Console.WriteLine("Installments:");
            foreach (Instaliment installment in contract.Instaliments)
            {
                Console.WriteLine(installment);
            }
        }
    }
}