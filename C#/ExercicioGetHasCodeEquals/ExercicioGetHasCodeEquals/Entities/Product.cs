using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioGetHasCodeEquals.Entities
{
    internal class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public override bool Equals(object? obj)
        {
            if(!(obj is Product))
            {
                throw new ArgumentException("obj não é um Product");
            }
            Product other = obj as Product;
            return Name.Equals(other.Name);
        }
        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }
    }
}
