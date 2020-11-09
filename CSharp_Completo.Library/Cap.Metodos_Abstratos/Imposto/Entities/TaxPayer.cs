using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_Completo.Library.Cap.Metodos_Abstratos.Imposto
{
    abstract class TaxPayer
    {
        public string Name { get; set; }
        public double AnualIncome { get; set; }

        public TaxPayer(string name, double anualIncome)
        {
            Name = name;
            AnualIncome = anualIncome;
        }

        public abstract  double Imposto();
        
    }
}
