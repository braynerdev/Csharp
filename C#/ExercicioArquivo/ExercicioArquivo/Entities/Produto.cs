using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioArquivo.Entities
{
    internal class Produto
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int  Quantity { get; set; }

        public Produto(string name, double price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        public double ValorTotalProd()
        {
            return Price * Quantity;
        }
    }
}
