using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioInterfacePagamento.Entities
{
    internal class ContractTrab
    {
        public int Number { get; private set; }
        public DateTime Date { get; set; }
        public double TotalValue { get; set; }
        public List<Instaliment> Instaliments { get; set; }

        public ContractTrab(int number, DateTime date, double totalValue)
        {
            Number = number;
            Date = date;
            TotalValue = totalValue;
            Instaliments = new List<Instaliment>();
        }

        public void AddInstaliment(Instaliment instaliment)
        {
            Instaliments.Add(instaliment);
        }
    }
}
