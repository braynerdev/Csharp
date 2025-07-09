using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioInterfacePagamento.Entities
{
    internal class Contract
    {
        public int Number { get; set; }
        public DateTime Date { get; set; }
        public double TotalValue { get; set; }
        public List<Instaliment> Instaliment {  get; set; }

        public Contract(int number, DateTime date, double totalValue)
        {
            Number = number;
            Date = date;
            TotalValue = totalValue;
            Instaliment = new List<Instaliment>();
        }

        public void AddInstaliment(Instaliment instaliment)
        {
            Instaliment.Add(instaliment);
        }
    }
}
