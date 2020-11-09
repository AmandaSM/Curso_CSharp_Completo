using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_Completo.Library.Cap.Metodos_Abstratos.Imposto
{
     class PessoaFisica : TaxPayer
    {
        public double GastosSaude { get; set; }

        public PessoaFisica(double gastosSaude, string name, double anualIncome) : base(name, anualIncome)
        {
            GastosSaude = gastosSaude;
        }

        public override double Imposto()
        {
            double imposto = 0.0;
            if (GastosSaude != 0.0)
            {
                if (AnualIncome < 20000.00)
                {
                    return imposto = (AnualIncome * 0.15) - (GastosSaude * 0.50);
                }
                else
                {
                    return imposto = AnualIncome * 0.25 - (GastosSaude * 0.50);

                }
            }
            else
            {
                if (AnualIncome < 20000.00)
                {
                    return imposto = AnualIncome * 0.15;
                }
                else
                {
                    return imposto = AnualIncome * 0.25;
                }
            }
        }

    }
}
