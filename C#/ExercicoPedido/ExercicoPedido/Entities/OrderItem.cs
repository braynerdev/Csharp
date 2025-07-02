using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicoPedido.Entities
{
    internal class OrderItem
    {
        public Product Product { get; private set; }
        public int Quantity { get; private set; }
        public double Price { get; private set; }


        public OrderItem()
        {
        }

        public OrderItem(Product product, int quantity, double price)
        {
            Product = product;
            Quantity = quantity;
            Price = price;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(
                $"Name: {Product.Name}, " +
                $"Price: {Product.Price}, " +
                $"Quantity: {Quantity}, " +
                $"Subtotal: {Price.ToString("F2", CultureInfo.InvariantCulture)}"
            );

            return sb.ToString();
        }

        public double SubTotal()
        {
            return Price * Quantity;

        }
    }
}
