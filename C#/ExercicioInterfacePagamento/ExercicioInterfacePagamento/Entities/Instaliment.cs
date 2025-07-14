using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioInterfacePagamento.Entities
{
    internal class Instaliment
    {
        public DateTime dueDate {  get; set; }
        public double amount { get; set; }

        public Instaliment(DateTime dueDate, double amount)
        {
            this.dueDate = dueDate;
            this.amount = amount;
        }

        public override string ToString()
        {
            return $"{dueDate.ToString("dd/MM/yyyy")} - {amount.ToString("F2",CultureInfo.InvariantCulture)}";
        }
    }
}
