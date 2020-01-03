using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentSubsidySystem.Controller
{
    class PaymentSubsidyController
    {
        private Data.pos13DataContext db = new Data.pos13DataContext(Settings.GetConnectionString());

        public List<Entities.TrnPaymentSubsidy> PaymentSubsidyList(DateTime filterDate, String searchString) {

            var paymentSubsidies = from d in db.TrnPaymentSubsidies.OrderByDescending(d => d.Id)
                                   where d.Date == filterDate
                                   && d.MstCustomer.IsLocked == true
                                   && (d.SubsidyCode.Contains(searchString)
                                   || d.MstCustomer.Customer.Contains(searchString)
                                   || d.Particulars.Contains(searchString)
                                   || d.MstUser.FullName.Contains(searchString))
                                   select new Entities.TrnPaymentSubsidy
                                   {
                                       Id = d.Id,
                                       CustomerId = d.CustomerId,
                                       Customer = d.MstCustomer.Customer,
                                       Date = d.Date.ToShortDateString(),
                                       SubsidyCode = d.SubsidyCode,
                                       DebitAmount = d.DebitAmount,
                                       CreditAmount = d.CreditAmount,
                                       Particulars = d.Particulars,
                                       UserId = d.UserId,
                                       User = d.MstUser.FullName,
                                       TimeStamp = d.TimeStamp.ToShortDateString()
                                   };

            return paymentSubsidies.ToList();
        }
    }
}
