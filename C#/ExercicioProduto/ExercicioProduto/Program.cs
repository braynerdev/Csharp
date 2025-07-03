using System;
using System.Globalization;
using ExercicioProduto.Entities;


namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();

            Product product1 = new ImportedProduct("Tablet", 260.00, 20.00);
            products.Add(product1);
            Product product2 = new Product("Notbook", 1100.00);
            products.Add(product2);
            Product product3 = new UsedProduct("Iphone", 400.00, 
                DateTime.ParseExact("26/08/2004","dd/MM/yyyy", CultureInfo.InvariantCulture));
            products.Add(product3);

            foreach (Product product in products)
            {
                Console.WriteLine(product.PriceTag());
            }
        }
    }
}