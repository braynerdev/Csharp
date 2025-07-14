using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ExercicioPortalAlunos.Entities
{
    internal class Alunos : UserAbstract
    {
        public Alunos(int id, string name) : base(id, name)
        {
        }


        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
        public override bool Equals(object? obj)
        {
            if (!(obj is Alunos))
            {
                return false;
            }
            Alunos other = obj as Alunos;
            return Id.Equals(other.Id);
        }

        public override string ToString()
        {
            return $"{Id} - {Name}";
        }


    }
}
