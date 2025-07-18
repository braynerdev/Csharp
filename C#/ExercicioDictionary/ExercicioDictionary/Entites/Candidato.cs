using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioDictionary.Entites
{
    internal class Candidato
    {
        public string Name { get; set; }
        public int Votos { get; set; }

        public Candidato(string name, int votos)
        {
            Name = name;
            Votos = votos;
        }
    }
}
