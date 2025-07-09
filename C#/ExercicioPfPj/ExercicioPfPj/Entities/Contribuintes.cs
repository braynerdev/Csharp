using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioPfPj.Entities
{
    abstract internal class Contribuintes
    {
        public string Name { get; protected set; }
        public double RendaAnual { get; protected set; }

        protected Contribuintes(string name, double rendaAnual)
        {
            Name = name;
            RendaAnual = rendaAnual;
        }

        public abstract double CalcImposto();
        public override string ToString()
        {
            return $"{Name}: $ {CalcImposto().ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
