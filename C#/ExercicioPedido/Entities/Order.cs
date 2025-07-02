using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioPedido.Entities
{
    internal class Order
    {
        public List<OrderItem> Items { get; private set; } = new List<OrderItem>();

        public Client Client { get; private set; }

        public DateTime Moment {  get; private set; }

        public OrderStatus Status { get; private set; }


        public Order()
        {
        }

        public Order(Client client, DateTime moment, OrderStatus status)
        {
            Client = client;
            Moment = moment;
            Status = status;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Client: {Client.Name} ({Client.BirthDay.ToString("dd/MM/yyyy")}) - {Client.Email}");
            sb.AppendLine($"Status: {Status.ToString()}");
            sb.AppendLine();
            sb.AppendLine("Items:");

            foreach (OrderItem item in Items)
            {
                sb.AppendLine(item.ToString());
            }
            sb.AppendLine();
            sb.AppendLine($"Total: {ValueTotal().ToString("F2", CultureInfo.InvariantCulture)}");
            return sb.ToString();
        }

        public void AddItem(OrderItem item) {
            Items.Add(item);
        }
        public void RemoveItem(OrderItem item)
        {
            Items.Remove(item);
        }
        public double ValueTotal()
        {
            double total = 0.0;
            foreach (OrderItem item in Items)
            {
                total += item.SubTotal();
            }
            return total;
        }
    }
}
