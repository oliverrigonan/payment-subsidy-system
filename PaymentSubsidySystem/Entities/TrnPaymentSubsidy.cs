using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentSubsidySystem.Entities
{
    class TrnPaymentSubsidy
    {
        public Int32 Id { get; set; }
        public Int32 CustomerId { get; set; }
        public String Customer { get; set; }
        public String Date { get; set; }
        public String SubsidyCode { get; set;}
        public Decimal DebitAmount { get; set; }
        public Decimal CreditAmount { get; set; }
        public String Particulars { get; set; }
        public Int32 UserId { get; set; }
        public String User { get; set; }
        public String TimeStamp { get; set; }
    }
}
