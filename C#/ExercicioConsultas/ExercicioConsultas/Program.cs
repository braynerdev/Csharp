using ExercicioConsultas.Entities;
using System.Globalization;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\jbray\testee.txt";

            List<Product> list = new List<Product>();

            using( StreamReader  sr = File.OpenText(path))
            {

                while (!(sr.EndOfStream))
                {
                    string[] line = sr.ReadLine().Split(",");
                    string Name = line[0];
                    double Price = double.Parse(line[1], CultureInfo.InvariantCulture);

                    list.Add(new Product(Name, Price));
                }
            }

            var AveragePrice = 
                (from p in list
                select p.Price).DefaultIfEmpty(0.0).Average();

            Console.WriteLine($"Average Price: {AveragePrice.ToString("F2")}");
            Console.WriteLine();

            var NameProductPriceSmall =
                from p in list
                where p.Price < AveragePrice
                orderby p.Name descending
                select p.Name;

            foreach (string p in NameProductPriceSmall)
            {
                Console.WriteLine(p);
            }

            Console.WriteLine();

            Console.WriteLine("lambda:");

            var AveragePriceLambda = list.Select(p => p.Price).DefaultIfEmpty(0.0).Average();
            Console.WriteLine($"Average Price: {AveragePriceLambda.ToString("F2")}");
            Console.WriteLine();


            var NameProductPriceSmallLambda = 
                list
                .Where(p => p.Price < AveragePriceLambda)
                .OrderByDescending(p => p.Name).Select(p => p.Name);
            foreach (string p in NameProductPriceSmallLambda)
            {
                Console.WriteLine(p);
            }
        }
    }
}