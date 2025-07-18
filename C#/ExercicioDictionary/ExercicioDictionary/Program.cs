using ExercicioDictionary.Entites;
using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\jbray\testee.txt";

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {

                    Dictionary<string, int> votos = new Dictionary<string, int>();

                    while (!(sr.EndOfStream))
                    {
                        string[] lineSplit = sr.ReadLine().Split(',');

                        string name = lineSplit[0];
                        int votosPerCandidato = int.Parse(lineSplit[1]);



                        if (votos.ContainsKey(name))
                        {
                            votos[name] += votosPerCandidato;
                        }
                        else
                        {
                            votos.Add(name, votosPerCandidato);
                        }
                    }
                    foreach (var item in votos)
                    {
                        Console.WriteLine($"{item.Key} - {item.Value}");
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}