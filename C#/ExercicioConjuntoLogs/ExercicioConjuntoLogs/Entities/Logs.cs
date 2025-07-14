using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioConjuntoLogs.Entities
{
    internal class Logs
    {
        public string Name { get; set; }
        public DateTime DataHora { get; set; }

        public Logs(string name, DateTime dataHora)
        {
            Name = name;
            DataHora = dataHora;
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }

        public override bool Equals(object? obj)
        {
            if (! (obj is Logs))
            {
                throw new ArgumentException("obj não é um log1");
            }
            Logs other = obj as Logs;
            return Name.Equals(other.Name);
        }

        public override string ToString()
        {
            return $"{Name} - {DataHora.ToString("dd/MM/yyyy HH:mm:ss")}";
        }
    }
}
