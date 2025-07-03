using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioFuncionario.Entities
{
    internal class Outsource : Employee
    {
        public double AdditionalChange {  get; set; }

        public Outsource()
        {
        }

        public Outsource(string name, int hours, double valorPerHour, double additionalChange) 
            : base(name, hours, valorPerHour)
        { 
            AdditionalChange = additionalChange;
        }

        public sealed override double Payment()
        {
            return base.Payment() + (AdditionalChange / 100 * 110);
        }
    }
}
