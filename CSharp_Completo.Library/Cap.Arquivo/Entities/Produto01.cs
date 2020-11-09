using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace CSharp_Completo.Library.Cap.Arquivo.Entities
{
    public class Produto01
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }

        public Produto01(string name, double price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }

    
        public double Total()
        {
            return Price * Quantity;
        }
        public override string ToString()
        {
            return $"Produto: {Name} -> ${Total().ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
