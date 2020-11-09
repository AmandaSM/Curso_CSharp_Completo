﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_Completo.Library.Cap.Enumeracao_Composicao.Order.Entities
{
    public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }
    }
}
