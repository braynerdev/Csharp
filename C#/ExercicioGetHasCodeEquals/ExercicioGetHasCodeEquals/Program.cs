using ExercicioGetHasCodeEquals.Entities;
using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<Product> list = new HashSet<Product>();

            Product product = new Product("test1", 12.22);
            Product product2 = new Product("test2", 13.22);
            Product product3 = new Product("test3", 14.22);
            Product product4 = new Product("test4", 15.22);
            Product product5 = new Product("test5", 16.22);
            Product product6 = new Product("test6", 17.22);
            Product product7 = new Product("test7", 18.22);
            Product product8 = new Product("test8", 19.22);

            list.Add(product);
            list.Add(product2);
            list.Add(product3);
            list.Add(product4);
            list.Add(product5);
            list.Add(product6);
            list.Add(product7);
            list.Add(product8);

            Console.WriteLine(product8.GetHashCode());
            
            Console.WriteLine();
            foreach(Product p in list)
            {
                Console.WriteLine(p.Equals(product8));
            }
        }
    }
}