using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ExercicioPortalAlunos.Entities
{
    internal class Professor : UserAbstract
    {
        public Professor(int id, string name, DateTime dataHora) : base(id, name, dataHora)
        {
        }

        public override string ToString()
        {
            return $"{Id} - {Name}";
        }
    }
}
