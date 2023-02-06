using System;
using System.Text;
using System.Globalization;
using System.Collections.Generic;
using projeto1.Entities.Enums;

namespace projeto1.Entities
{
    internal class Order
    {
        public DateTime Moment { get; private set; }
        public OrderStatus Status { get; private set; }
        public Client Client { get; private set; }
        public List<OrdeItem> Items { get; private set; } = new List<OrdeItem>();

        public Order()
        {

        }

        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
            Client = client;
        }
        public void AddItem(OrdeItem item)
        {
            Items.Add(item);
        }

        public void RemoveItem(OrdeItem item)
        {
            Items.Remove(item);
        }

        public double Total()
        {
            double sum = 0.0;
            foreach (OrdeItem item in Items)
            {
                sum += item.SubTotal();
            }
            return sum;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Order moment: " + Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine("Order status: " + Status);
            sb.AppendLine("Client: " + Client);
            sb.AppendLine("Order items:");
            foreach (OrdeItem item in Items)
            {
                sb.AppendLine(item.ToString());
            }
            sb.AppendLine("Total price: $" + Total().ToString("F2", CultureInfo.InvariantCulture));
            return sb.ToString();
        }
    }
}

