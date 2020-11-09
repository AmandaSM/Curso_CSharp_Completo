using CSharp_Completo.Library.Cap.Enumeracao_Composicao.Order.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace CSharp_Completo.Library.Cap.Enumeracao_Composicao.Order.Entities
{
    public class Order
    {
        public DateTime Date { get; set; }
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }
        public List<OrdemItem> Items { get; set; } = new List<OrdemItem>();

        public Order()
        {

        }
        public Order( OrderStatus status, Client client)
        {
            Client = client;
            Date = DateTime.Now;
            Status = status;
        }

        public void AddItem(OrdemItem item)
        {
            Items.Add(item);
        }

        public void RemoveItem(OrdemItem item)
        {
            Items.Remove(item);
        }

        public Double Total()
        {
            double total = 0.0;
            foreach  (OrdemItem item in Items)
            {
                total += item.SubTotal();
            }
            return total;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Order momment: {Date.ToString("dd/MM/yyyy")}");
            sb.AppendLine($"Order status{Status}");
            sb.AppendLine($"Client: {Client}");
            sb.AppendLine($"Order items:");
            foreach (OrdemItem item in Items)
            {
                sb.AppendLine(item.ToString());
            }
            sb.AppendLine($"Total price: ${Total().ToString("F2", CultureInfo.InvariantCulture)}");

            return sb.ToString();

        }
    }
}
