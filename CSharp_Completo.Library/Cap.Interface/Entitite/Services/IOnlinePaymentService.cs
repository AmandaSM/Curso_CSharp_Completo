using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_Completo.Library.Cap.Interface.Entitite
{
   public interface IOnlinePaymentService
    {
        public Double PaymentFee(double amount);
        public double Interest(double amount, int months);

    }
}
