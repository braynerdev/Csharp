using ExercicioPortalAlunos.Entities;
using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Professor prof1 = new Professor(1,"jose joao");


            Cursos curs1 = new Cursos("aprewndendo c#",1,prof1);
            Cursos curs2 = new Cursos("aprewndendo java",2,prof1);
            Cursos curs3 = new Cursos("aprewndendo python",3,prof1);

            Alunos aluno1 = new Alunos(1,"joao brayner");
            Alunos aluno2 = new Alunos(2,"joao souza");
            Alunos aluno3 = new Alunos(3,"joao victor");
            Alunos aluno4 = new Alunos(4,"teste brayner");
            Alunos aluno5 = new Alunos(5,"joao teste");

            curs1.AddAluno(aluno1);
            curs1.AddAluno(aluno2);

            curs2.AddAluno(aluno1);
            curs2.AddAluno(aluno2);
            curs2.AddAluno(aluno3);
            curs2.AddAluno(aluno4);

            curs3.AddAluno(aluno2);
            curs3.AddAluno(aluno3);

            HashSet<Alunos> alunos = new HashSet<Alunos>(curs1.Alunos);

            alunos.UnionWith(curs2.Alunos);
            alunos.UnionWith(curs3.Alunos);


            Console.WriteLine(alunos.Count);


        }
    }
}