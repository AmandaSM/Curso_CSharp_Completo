using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_Completo.Library.Cap.Interface.Entitite
{
    public class PaypalService : IOnlinePaymentService
    {
        private const double _jurosSimples = 0.01;//Monthly insterest
        private const double _taxaPagamento = 0.02;//FeePercentage
        public double Interest(double amount, int months)
        {//calculo  juro 
               return amount * _jurosSimples + months;
           
        }

        public double PaymentFee(double amount)
        {//calculo taxa
            return amount * _taxaPagamento;
        }
    }
}
