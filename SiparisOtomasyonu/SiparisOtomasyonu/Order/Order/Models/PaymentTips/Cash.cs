using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order.Models.PaymentTips
{
    public class Cash : Payment
    {
        public int CashTendered { get; set; }
        public override int Amount { get; set; }
        public override int PaymentId { get; set; }
    }
}
