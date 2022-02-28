using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace Order.Models
{
    public class Order 
    {
        public int OrderId { get; set; }
        public string Date { get; set; }
        public string Status { get; set; }

        public const int shippingPrice = 10;

        public Payment Payment { get; set; }
        
        DAL.DAL sql=new DAL.DAL();

        public const decimal TAX = 0.05M;
        public decimal calcTax(int price)
        {
       decimal taxprice = price * TAX;

            return taxprice;
        
        }
        
        public  int calcTOTAL (int price,decimal taxprice)
        {
            
            int totalprice = Convert.ToInt32( price + taxprice+shippingPrice);
            return totalprice;  
            
        }

       



    }
}
