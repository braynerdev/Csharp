using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosGenerics.Entities
{
    internal class Product : IComparable
    {
        public string ProductName { get; set; }
        public double Price { get; set; }

        public Product(string productName, double price)
        {
            ProductName = productName;
            Price = price;
        }

        public int CompareTo(object? obj)
        {
            if (!(obj is Product))
            {
                throw new ArgumentException("Parametro não é um Product!");
            }
            Product other = obj as Product;
            return Price.CompareTo(other.Price);
        }

        public override string ToString()
        {
            return  $"{ProductName} - R$ {Price.ToString("F2",CultureInfo.InvariantCulture)}";
        }
    }
}
