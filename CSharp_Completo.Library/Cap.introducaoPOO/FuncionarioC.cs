using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace CSharp_Completo.Library.Cap.POO
{
    public class FuncionarioC
    {
        //ex2
        public string Nome { get; set; }
        public double SalarioBruto { get; set; }
        public double Imposto { get; set; }
        public double Porcentagem { get; set; }

        public double SalarioLiquido()
        {
            return SalarioBruto - Imposto;
        }
        public void AumentarSalario(double porcentagem)
        {
            SalarioBruto += (SalarioBruto * porcentagem) / 100;
        }
        public override string ToString()
        {
            return $"{Nome } , R${SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
