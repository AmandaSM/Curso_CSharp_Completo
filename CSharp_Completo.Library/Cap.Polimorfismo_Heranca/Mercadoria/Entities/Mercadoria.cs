using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_Completo.Library.Cap.Polimorfismo_Heranca.Mercadoria.Entities
{
    public class Mercadoria
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Mercadoria(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public virtual String PriceTag ()
        {
            return $"{Name},$ {Price}";
        }
         
    }
}
