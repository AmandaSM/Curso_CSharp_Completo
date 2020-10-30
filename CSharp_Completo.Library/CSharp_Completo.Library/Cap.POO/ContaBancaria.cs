using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace CSharp_Completo.Library.Cap.POO
{
    public class ContaBancaria
    {
        public int NumeroConta { get; private set; }

        public string Nome { get; set; }
        public double Saldo { get; private set; }

        private static double Taxa = 5.00;

        public ContaBancaria(int numero)
        {
            NumeroConta = numero;
        }
        public void Deposito(double deposito)
        {
            Saldo += deposito;
        }
        public void Saque(double saque)
        {
            Saldo -= saque + Taxa;
        }
        public override string ToString()
        {
            return $"Conta: {NumeroConta }, Titula:{Nome}, Saldo: R${Saldo.ToString("f2",CultureInfo.InvariantCulture)}";
        }
    }
}
