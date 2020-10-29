using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_Completo.Library.Cap.POO
{
    public class Retangulo
    {
        //ex01
        public double Largura { get; set; }
        public double Altura { get; set; }

        public double Area()
        {
            return Largura * Altura;
        }
        public double Perimetro()
        {
            return 2 * (Largura + Altura);
        }
        public double Diagonal()
        {
            return Math.Sqrt(Largura * Largura + Altura * Altura);
        }

    }
}
