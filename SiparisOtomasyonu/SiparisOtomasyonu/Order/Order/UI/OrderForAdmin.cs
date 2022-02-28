using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Order.UI
{
    public partial class OrderForAdmin : Form
    {
        public int orderID;
        public string orderName;
        DAL.DAL sql = new DAL.DAL();
        public OrderForAdmin()
        {
            InitializeComponent();
        }
        public void griddoldur()
        {
            SqlCommand komut = new SqlCommand("Select OrderID As [İD], OrderName , OrderAddress, OrderItem,OrderBuyerPrice as [Item Price],OrderBuyerQuantity as [Quantity],OrderStatus From OnlineOrder ", sql.baglanti());
            komut.Parameters.AddWithValue("@p1", orderID);
            SqlDataAdapter adapter = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            sql.baglanti().Close();
            dataGridView1.DataSource=dt;
            sql.baglanti().Close();

        }
        private void OrderForAdmin_Load(object sender, EventArgs e)
        {
            griddoldur();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int secilenindex = dataGridView1.SelectedCells[0].RowIndex;
            orderID=Convert.ToInt32(dataGridView1.Rows[secilenindex].Cells[0].Value);
            orderName=dataGridView1.Rows[secilenindex].Cells[1].Value.ToString();
            int orderstatus = Convert.ToInt32(dataGridView1.Rows[secilenindex].Cells[6].Value);
            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show(orderName+" Ürününün kargo durumunu değiştirmek istiyor musunuz?","ONAY",MessageBoxButtons.YesNo);
            if (dialog==DialogResult.Yes)
            {
                 if(orderstatus==0)
                    orderstatus = 1;
                 else if (orderstatus==1)
                    orderstatus = 0;
                SqlCommand komut = new SqlCommand("Update OnlineOrder Set OrderStatus=@p2 where OrderID=@p1", sql.baglanti());
                komut.Parameters.AddWithValue("@p1",orderID);
               komut.Parameters.AddWithValue("@p2",orderstatus);

                komut.ExecuteNonQuery();
               sql.baglanti().Close();
                griddoldur();
            }
            else
            {
              
            }
           
        }
    }
}
