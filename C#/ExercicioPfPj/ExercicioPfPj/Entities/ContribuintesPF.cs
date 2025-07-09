using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioPfPj.Entities
{
    internal class ContribuintesPF : Contribuintes
    {
        public double GastoSaude {  get; set; }

        public ContribuintesPF(string name, double rendaAnual, double gastoSaude)
            : base(name,rendaAnual)
        {
            GastoSaude = gastoSaude;
        }

        public override double CalcImposto()
        {
            if (RendaAnual < 20000.00)
            {
                return RendaAnual * 0.15 - GastoSaude * 0.5;
            } 
            else
            {
                return RendaAnual * 0.25 - GastoSaude * 0.5;
            }
        }
    }
}
