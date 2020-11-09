using CSharp_Completo.Library.Cap.Tratamento_Execoes.Entitites.Exceptions;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection.PortableExecutable;
using System.Text;

namespace CSharp_Completo.Library.Cap.Tratamento_Execoes.Entitites
{
    public class Account1
    {
        public int Number { get; private set; }
        public string Holder { get; set; }
        public double WithdrawLimit { get; private set; }
        public double Balance { get; private set; }

        public Account1(int number, string holder, double withdrawLimit, double balance)
        {
            Number = number;
            Holder = holder;
            WithdrawLimit = withdrawLimit;
            Balance = balance;
        }

        public void Deposito (double amount)
        {
            Balance += amount;
        }
        public void WithDraw(double amount)
        {
            if (amount > WithdrawLimit)
            {
                throw new DomainException("withdraw error: The amount exceeds withdraw limit");
            }
            else if (amount > Balance)
            {
                throw new DomainException("withdraw error: Not enough balance");
            }
            Balance -= amount;
        }

        public override string ToString()
        {
            return $"{Holder}: number account({Number} -> Balance ${Balance.ToString("F2", CultureInfo.InvariantCulture)})";
        }
    }
}
