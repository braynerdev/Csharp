using ExercicioFuncionarioLambda.Entities;
using System;
using System.Globalization;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\jbray\funcionarios.csv";

            List<Funcionarios> list = new List<Funcionarios>();

            using (StreamReader sr = File.OpenText(path))
            {
                while (!(sr.EndOfStream))
                {
                    string[] line = sr.ReadLine().Split(",");

                    string name = line[0];
                    string email = line[1];
                    double salary = double.Parse(line[2]);

                    list.Add(new Funcionarios(name, email, salary));
                }
            }

            double MediaSalary = 2000.00;

            Console.WriteLine($"Media Salarial:{MediaSalary.ToString("F2",CultureInfo.InvariantCulture)}");
            Console.WriteLine();


            var EmailPeopleSalarySmallMediaSalary =
                list
                .Where(p => p.Salary > MediaSalary)
                .OrderBy(p => p.Email)
                .Select(p => p.Email);

            Console.WriteLine($"Email of people whose salary is more than {MediaSalary.ToString("F2",CultureInfo.InvariantCulture)}");
            foreach (string item in EmailPeopleSalarySmallMediaSalary)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();



            var SumSalaryPeopleNameStartM = 
                list
                .Where(p => p.Name.ToUpper().StartsWith('M'))
                .Sum(p => p.Salary);

            Console.WriteLine($"Sum of salary of people whose name start with 'M': {SumSalaryPeopleNameStartM.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}