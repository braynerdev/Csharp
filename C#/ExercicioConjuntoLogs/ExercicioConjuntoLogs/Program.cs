using ExercicioConjuntoLogs.Entities;
using System;
using System.Globalization;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o caminho da pasta que o arquivo se encontra:");
            string rota = Console.ReadLine();

            HashSet<Logs> logs = new HashSet<Logs>();

            try
            {
                using StreamReader sr = File.OpenText(rota);

                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    string[] lineVet = line.Split(" ");
                    logs.Add(new Logs(lineVet[0], DateTime.ParseExact(lineVet[1],"yyyy-MM-ddTHH:mm:ss",CultureInfo.InvariantCulture)));
                }
                foreach (Logs log in logs)
                {
                    Console.WriteLine(log);
                }
                Console.WriteLine($"User dif: {logs.Count}");
            }
            catch (IOException e)
            {
                Console.WriteLine($"erro: {e}");
            }
        }
    }
}