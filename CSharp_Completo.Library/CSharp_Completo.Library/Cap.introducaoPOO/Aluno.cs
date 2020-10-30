using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;

namespace CSharp_Completo.Library.Cap.POO
{
    public class Aluno
    {
        //ex 03 
        private string _nome;
        public double Nota01 { get; set; }
        public double Nota02 { get; set; }
        public double Nota03 { get; set; }
        public string GetNome()
        {
            return _nome;
        }
        public void SetNome(string nome)
        {
            if (nome != null && nome.Length > 1)
            {
                _nome = nome;
            }
            else
            {
                _nome = "nome";
            }

        }
        public double NotaFinal()
        {
            return Nota01 + Nota02 + Nota03;
        }
        public string Aprovado()
        {
            if (NotaFinal() >= 60.00)
            {
                return "APROVADO";
            }
            return "REPROVADO";
        }
        public double Faltaram()
        {
            double x = NotaFinal();
            return 60.00 - x;
        }
        public override string ToString()
        {
            return $"Nota Final: {NotaFinal().ToString("f2", CultureInfo.InvariantCulture)}";
        }

    }
}
