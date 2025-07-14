using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioPortalAlunos.Entities
{
    internal class Cursos
    {
        public string  Name { get; set; }
        public int Id { get; set; }
        public Professor Professor { get; set; }
        public HashSet<Alunos> Alunos{ get; set; }

        public Cursos(string name, int id, Professor professor)
        {
            Name = name;
            Id = id;
            Professor = professor;
            Alunos = new HashSet<Alunos>();
        }

        public void AddAluno(Alunos aluno)
        {
            Alunos.Add(aluno);
        }
    }
}
