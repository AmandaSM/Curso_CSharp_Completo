using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_Completo.Library.Cap.Interface.Entitite
{
    public class ContractService
    {
        private IOnlinePaymentService _onlinePaymentService;

        public ContractService(IOnlinePaymentService onlinePaymentService)
        {
            _onlinePaymentService = onlinePaymentService;
        }
        public void ProcessContract (Contract contract, int moths)
        {
            double basicQuota = contract.ValorContrato / moths;
            for (int moth = 0; moth <= moths; moth++)
            {
                DateTime date = contract.Date.AddMonths(moth);
                double updateQuota = basicQuota + _onlinePaymentService.Interest(basicQuota, moth);
                double fullQuota = updateQuota + _onlinePaymentService.PaymentFee(basicQuota);
                contract.AddItem(new Installment(date, fullQuota));
            }
        }
    }
}
