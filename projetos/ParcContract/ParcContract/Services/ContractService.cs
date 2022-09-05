using System;
using ParcContract.Entities;

namespace ParcContract.Services
{
    class ContractService
    {
        private IOnlinePaymentService _onlinePaymentService;
        public ContractService(IOnlinePaymentService onlinePayService)
        {
            _onlinePaymentService = onlinePayService;
        }

        public void ProcessContract( Contract contract, int months)
        {
            double basicQuota = contract.TotalValue / months;
            for(int i = 1; i <= months; i++)
            {
                DateTime data = contract.Date.AddMonths(i);
                double updatedQuota = basicQuota + _onlinePaymentService.Interest(basicQuota, i);
                double fullQuota = updatedQuota + _onlinePaymentService.PaymentFee(updatedQuota);
                contract.addInstallmente(new Installment(data, fullQuota));

            }
        }
    }
}
