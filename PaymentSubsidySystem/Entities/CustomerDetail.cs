using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentSubsidySystem.Entities
{
    public class CustomerDetail
    {
        public Int32 Id { get; set; }
        public String Code { get; set; }
        public String Customer { get; set; }
        public String Department { get; set; }
        public Decimal Balance { get; set; }
        public Decimal Amount { get; set; }
    }
}
