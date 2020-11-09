using System;
using System.Collections.Generic;

namespace CSharp_Completo.Library.Cap.Interface.Entitite
{
    public class Contract
    {
        public int Number { get; set; }
        public DateTime Date { get; set; }
        public double ValorContrato { get; set; }

        public List<Installment> Installments { get; set; }

        public Contract(int number, DateTime date, double totalValue)
        {
            Number = number;
            Date = date;
            ValorContrato = totalValue;
            Installments = new List<Installment>();
        }

        public void AddItem(Installment installment)
        {
            Installments.Add(installment);
        }

    }
}
