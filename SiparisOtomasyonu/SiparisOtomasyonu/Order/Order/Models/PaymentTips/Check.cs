using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Order.Models.PaymentTips
{
    public class Check : Payment
    {
        DAL.DAL sql = new DAL.DAL();
        public string HoldersName { get; set; }
        public string BankID { get; set; }

        public override int Amount { get; set; }
        public override int PaymentId { get; set; }
        public string authorized(int CheckCustomerID)
        {
            SqlCommand komut = new SqlCommand("Select * From CheckPayment Where CheckHolderName=@p1 and CheckBankName=@p2 and CheckCustomerID=@p3", sql.baglanti());
            komut.Parameters.AddWithValue("@p1",HoldersName);
            komut.Parameters.AddWithValue("@p2",BankID);
            komut.Parameters.AddWithValue("@p3", CheckCustomerID);
            komut.ExecuteNonQuery();
            sql.baglanti().Close();
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                SqlCommand cmd = new SqlCommand("delete from Basket where BasketCustomerID=@p1", sql.baglanti());
                cmd.Parameters.AddWithValue("@p1", CheckCustomerID);
                cmd.ExecuteNonQuery();
                sql.baglanti().Close();
                return "Your payment has been made successfully.";
            }
            else
            {
                return "Your payment has not been made. Incorrect Check Information.";
            }
        }
    }
}
