using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }

        public string Password { get; set; }
        public string Address { get; set; }

        public Order Order { get; set; }

       
    }
}
