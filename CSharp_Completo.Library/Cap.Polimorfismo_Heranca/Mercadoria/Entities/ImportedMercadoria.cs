using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace CSharp_Completo.Library.Cap.Polimorfismo_Heranca.Mercadoria.Entities
{
    public class ImportedMercadoria:Mercadoria
    {
        public  Double CustomsFree { get; set; }

        public ImportedMercadoria(double customsFree, string name, double price) : base (name, price)
        {
            CustomsFree = customsFree;
        }
        public double CustomsFee()
        {
            return Price + CustomsFree;
        }
        public override String PriceTag()
        {
            return $"{Name},$ {Price.ToString("F2", CultureInfo.InvariantCulture)}, Customs fee :{CustomsFee().ToString("F2", CultureInfo.InvariantCulture)}";
        }

    }
}
