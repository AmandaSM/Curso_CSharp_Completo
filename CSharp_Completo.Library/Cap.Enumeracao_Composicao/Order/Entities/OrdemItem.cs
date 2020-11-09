using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace CSharp_Completo.Library.Cap.Enumeracao_Composicao.Order.Entities
{
   public  class OrdemItem
    {
        public int Quantity { get; set; }
        public Product Product { get; set; }

        public OrdemItem(int quantity,Product product)
        {
            Quantity = quantity;
            Product = product;
            
        }

        public Double SubTotal()
        {
            return Quantity * Product.Price;
        }
        public override string ToString()
        {
            return $" {Product.Name} ,$ {Product.Price}, Quantity: {Quantity}, SubTotal:{SubTotal().ToString("F2", CultureInfo.InvariantCulture)} ";
        }

    }
}
