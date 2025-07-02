using ExercicoPedido.Entities;
using System;
using System.Globalization;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product("Shampoo", 25.89);
            Product product2 = new Product("Sabonete", 11.23);
            Product product3 = new Product("Creme", 67.12);
            Product product4 = new Product("Desodorante", 27.19);

            OrderItem item1 = new OrderItem(product1, 2, product1.Price);
            OrderItem item2 = new OrderItem(product2, 6, product2.Price);
            OrderItem item3 = new OrderItem(product3, 1, product3.Price);
            OrderItem item4 = new OrderItem(product4, 3, product4.Price);

            Client client1 = new Client("João Brayner", "jbrayner04@gmail.com", DateTime.ParseExact("26/08/2004", "dd/MM/yyyy", CultureInfo.InvariantCulture));


            Order order = new Order(client1, DateTime.Now, OrderStatus.Processing);

            order.AddItem(item1);
            order.AddItem(item2);
            order.AddItem(item3);
            order.AddItem(item4);

            Console.WriteLine(order);
        }
    }
}