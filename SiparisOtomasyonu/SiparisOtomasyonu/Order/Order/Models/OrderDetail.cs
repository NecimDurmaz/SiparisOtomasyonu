using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace Order.Models
{
    public class OrderDetail
    {
        public int Quantity { get; set; }
        public int Taxstatus { get; set; }
        public int TotalWeight { get; set; }
        public int Weight { get; set; }

        public Order Order { get; set; }

        DAL.DAL sql=new DAL.DAL();

        public OrderDetail()
        {
        TotalWeight = 0;
         Order order = new Order();
        }




        public decimal calcSubTotal(int basketCustomerID)
        {
            //VERGİSİZ FİYAT HESAPLAMA
            SqlCommand cmd = new SqlCommand("Select BasketBuyerPrice from Basket where BasketCustomerID=@p1", sql.baglanti());
            cmd.Parameters.AddWithValue("@p1", basketCustomerID);
            SqlDataReader dr = cmd.ExecuteReader();
            int ItemPrice;
           
            decimal totalPrice = 0;
            while (dr.Read())
            {
                int temp = 1;
                ItemPrice=(int)dr[0];
                temp =ItemPrice;
                totalPrice+=temp;

            }
            sql.baglanti().Close();
            return totalPrice;
        }
        public int calcWeight(int basketCustomerID)
        {//TÜM ÜRÜNLERİN AGIRLIGI
            SqlCommand cmd = new SqlCommand("Select BasketItemWeight,BasketBuyerQuantity from Basket where BasketCustomerID=@p1", sql.baglanti());
            cmd.Parameters.AddWithValue("@p1", basketCustomerID);
            SqlDataReader dr = cmd.ExecuteReader();
            

         
            while (dr.Read())
            {
                int temp = 1;
                Weight=(int)dr[0];
                Quantity=(int)dr[1];
                temp =Weight*Quantity;

                TotalWeight+=temp;

            }
            sql.baglanti().Close();
            return TotalWeight;

        }
        public  int calcTotalWeight(int basketCustomerID)
        {
            SqlCommand cmd = new SqlCommand("Select BasketItemWeight,BasketBuyerQuantity from Basket where BasketCustomerID=@p1", sql.baglanti());
            cmd.Parameters.AddWithValue("@p1", basketCustomerID);
            SqlDataReader dr = cmd.ExecuteReader();
            

            decimal totalPrice = 0;
            while (dr.Read())
            {
                int temp = 1;
                temp=(int)dr[0]*(int)dr[1];

                this.TotalWeight+=temp ;

            }
            sql.baglanti().Close();
            return TotalWeight;

        }


    }
}
