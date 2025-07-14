using ExerciciosGenerics.Entities;
using ExerciciosGenerics.Service;
using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();

            Product product = new Product("Computer",2800.00);
            Product product2 = new Product("Iphone",14700.00);
            Product product3 = new Product("Tablete",2550.00);

            products.Add(product);
            products.Add(product2);
            products.Add(product3);

            CalculationService calculationService = new CalculationService();

            Product max = calculationService.Comparable(products);

            Console.WriteLine(max);
        }
    }
}