using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace CSharp_Completo.Library.Cap.introducaoPOO
{
    public class ConversorMoeda
    {
        //ex04

        private static double Iof = 6.0;
        public static double Pagar(double cotacao, double qtd)
        {
            double valorBruto = cotacao * qtd; //valor a pagar bruto
            double valorLiquido= valorBruto *Iof / 100;
            return valorBruto + valorLiquido;
        }
    }
}
