using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioInterfacePagamento.Entities
{
    internal class Instaliment
    {
        public DateTime DueDate { get; set; }
        public double Amount { get; set; }

        public Instaliment(DateTime dueDate, double amount)
        {
            DueDate = dueDate;
            Amount = amount;
        }
    }
}
