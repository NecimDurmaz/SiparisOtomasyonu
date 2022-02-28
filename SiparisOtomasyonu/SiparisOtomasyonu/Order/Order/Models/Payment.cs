using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order.Models
{
    public abstract class Payment 
    {
        public abstract int PaymentId { get; set; }
        public abstract int Amount { get; set; }
        
        

       
    }
}
