using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Order.Models.PaymentTips
{
    public class Credit : Payment
    {
        DAL.DAL sql = new DAL.DAL();
        public string CreditNumber { get; set; }
        public string Type { get; set; }
        public int CVV { get; set; }
        public int Password { get; set; }
        public override int Amount { get; set; }
        public override int PaymentId { get; set; }

        public string expdate { get; set; } 

    
        public string authorized(int CreditCustomerID)
        {
            SqlCommand komut = new SqlCommand("select*from CreditCart Where CartNumber=@p1 and CartCvv=@p2 and CartTHRU=@p3 and CartPassword=@p4", sql.baglanti());
            komut.Parameters.AddWithValue("@p1", CreditNumber);
            komut.Parameters.AddWithValue("@p2", CVV);
            komut.Parameters.AddWithValue("@p3", expdate);
            komut.Parameters.AddWithValue("@p4", Password);

            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
               
              

                SqlCommand cmd = new SqlCommand("delete from Basket where BasketCustomerID=@p1", sql.baglanti());
                cmd.Parameters.AddWithValue("@p1", CreditCustomerID);
                cmd.ExecuteNonQuery();
                sql.baglanti().Close();

                return "Your payment has been made successfully.";
                sql.baglanti().Close(); 


            }
            else
            {
                return "Payment failed. Incorrect card information.";

            }
        }
    }
}
