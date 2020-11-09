using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace CSharp_Completo.Library.Cap.Polimorfismo_Heranca.Mercadoria.Entities
{
    public class UsedMercadoria : Mercadoria
    {
        public DateTime ManufactureDate { get; set; }

        public UsedMercadoria(DateTime manufactureDate, string name, double price) : base(name, price)
        {
            ManufactureDate = manufactureDate;
        }

        public override String PriceTag()
        {
              return $"{Name},$ {Price.ToString("F2", CultureInfo.InvariantCulture)}, {ManufactureDate.ToString("dd/MM/YYYY")}";
   
        }

    }
}
