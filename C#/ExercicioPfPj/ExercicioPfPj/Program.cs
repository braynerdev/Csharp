using ExercicioPfPj.Entities;
using System;
using System.Globalization;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Contribuintes> contribuintes = new List<Contribuintes>();
            Double total = 0;

            Contribuintes contribuinte1 = new ContribuintesPF("Alex", 50000.00, 2000.00);
            contribuintes.Add(contribuinte1);
            Contribuintes contribuinte2 = new ContribuintesPJ("Softech", 400000.00, 25);
            contribuintes.Add(contribuinte2);
            Contribuintes contribuinte3 = new ContribuintesPF("Bob", 120000.00, 1000.00);
            contribuintes.Add(contribuinte3);

            Console.WriteLine("TAXES PAID:");
            foreach (Contribuintes contribuinte in contribuintes)
            {
                Console.WriteLine(contribuinte);
                total += contribuinte.CalcImposto();
            }
            Console.WriteLine();
            Console.WriteLine(total.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}