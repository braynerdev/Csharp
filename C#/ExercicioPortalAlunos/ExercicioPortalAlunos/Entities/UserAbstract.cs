using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioPortalAlunos.Entities
{
    abstract internal class UserAbstract
    {
        public int Id { get; protected set; }
        public string Name { get; protected set; }
        public DateTime DataHora { get; protected set; }


        public UserAbstract(int id, string name, DateTime dataHora)
        {
            Id = id;
            Name = name;
            DataHora = dataHora;
        }

        public override string ToString()
        {
            return $"{Id} - {Name}";
        }
    }
}
