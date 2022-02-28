using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Order.UI
{
    public partial class OnlineOrder : Form
    {
        public int orderID;    
        DAL.DAL sql = new DAL.DAL();
        public OnlineOrder()
        {
            InitializeComponent();
        }
        public void griddoldur()
        {
            SqlCommand komut = new SqlCommand("Select OrderName , OrderAddress, OrderItem,OrderBuyerPrice as [Item Price],OrderBuyerQuantity as [Quantity],OrderDate From OnlineOrder where OrderCustomerID=@p1 and OrderStatus=1  ", sql.baglanti());
            komut.Parameters.AddWithValue("@p1",orderID);
            SqlDataAdapter adapter = new SqlDataAdapter(komut);
            DataTable dt = new DataTable(); 
            adapter.Fill(dt);
            sql.baglanti().Close();
            dataGridView1.DataSource=dt;
           
        }
        private void OnlineOrder_Load(object sender, EventArgs e)
        {
            griddoldur();
        }
    }
}
