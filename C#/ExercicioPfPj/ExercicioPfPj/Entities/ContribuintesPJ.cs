using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioPfPj.Entities
{
    internal class ContribuintesPJ : Contribuintes
    {
        public int NumFuncionario {  get; set; }

        public ContribuintesPJ(string name, double rendaAnual, int numFuncionario)
            : base(name, rendaAnual)
        {
            NumFuncionario = numFuncionario;
        }

        public override double CalcImposto()
        {
            if (NumFuncionario > 10)
            {
                return RendaAnual * 0.14;
            }
            else
            {
                return RendaAnual * 0.16;
            }
        }
    }
}
