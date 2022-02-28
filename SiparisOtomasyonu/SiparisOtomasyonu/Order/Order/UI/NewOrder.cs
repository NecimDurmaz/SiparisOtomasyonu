using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Order.UI
{
    public partial class NewOrder : Form
    {
        public NewOrder()
        {
            InitializeComponent();
        }
        DAL.DAL SQL = new DAL.DAL();
        public string Adres;
        public int CustomerId;
        public int ProductsId;
        public int price;
        public int weight;
        public void ComboList()
        {
            SqlCommand cmd = new SqlCommand("select ProductID ,([ProductType] + ' ' + [ProductSize]) As Veri from Products WHERE ProductQuantity>=1", SQL.baglanti());
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            cmd.ExecuteNonQuery();
            SQL.baglanti().Close();
            cmbItem.DataSource=dt;
            cmbItem.DisplayMember="Veri";
            cmbItem.ValueMember="ProductId";

        }
        public void ItemPullValues()
        {
            SqlCommand cmd = new SqlCommand("select ProductQuantity,ProductDescription,ProductPrice,ProductWeight from Products where ProductID=@p1", SQL.baglanti());
            cmd.Parameters.AddWithValue("@p1", ProductsId);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                label8.Text = dr[0].ToString();
                rchDescription.Text=dr[1].ToString();
                lblPrice.Text = dr[2].ToString();
                price = (int)dr[2];
                weight = Convert.ToInt32(dr[3]);

            }
            SQL.baglanti().Close();

        }
        public void Adress()
        {
            
            SqlCommand cmd = new SqlCommand("select CustomerAddress from Tbl_Customer where CustomerID=@p1", SQL.baglanti());
            cmd.Parameters.AddWithValue("@p1",CustomerId);
            SqlDataReader dr = cmd.ExecuteReader(); 
            if (dr.Read())
            {
                Adres = dr[0].ToString();
            }
            SQL.baglanti().Close();

        }
        private void NewOrder_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(180, 231, 76, 60);
            Adress();
            ComboList();
            

        }

       
        private void button4_Click(object sender, EventArgs e)
        {
            rchBuyerAddress.Text=Adres;
        }

       

        private void comboBox3_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ProductsId=Convert.ToInt32(cmbItem.SelectedValue);
            ItemPullValues();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(txtQuantity.Text);
            x+=1;
            txtQuantity.Text=x.ToString();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(txtQuantity.Text);
        
            x-=1;
            txtQuantity.Text=x.ToString();
        }
  
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            

            int y =Convert.ToInt32(txtQuantity.Text);
            int temp = price*y;
            lblPrice.Text=temp.ToString();
            
            //ALINAN MİKTARI 0'IN ALTINA DÜŞÜRMEYİ ENGELLEME
            if (Convert.ToInt32(txtQuantity.Text)==0)
            {
                btnDecrease.Enabled=false;
            }
            else
            {
                btnDecrease.Enabled=true;
            }
            // ALINAN MİKTARI STOKTAN FAZLA YAPMAYI ENGELLEME
            if (Convert.ToInt32(txtQuantity.Text)==Convert.ToInt32(label8.Text))
            {
                btnIncrease.Enabled=false;
            }
            else
            {
                btnIncrease.Enabled = true;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int TotalItemWeight = weight*Convert.ToInt32(txtQuantity.Text);
            SqlCommand cmd = new SqlCommand("Insert Into Basket (BasketBuyerName,BasketBuyerAddress,BasketBuyerPrice,BasketBuyerQuantity,BasketCustomerID,BasketItem,BasketItemWeight,BasketProductID,BasketDate) VALUES (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9)", SQL.baglanti());
            cmd.Parameters.AddWithValue("@p1", txtBuyerName.Text);
            cmd.Parameters.AddWithValue("@p2", rchBuyerAddress.Text);
            cmd.Parameters.AddWithValue("@p3", lblPrice.Text);
            cmd.Parameters.AddWithValue("@p4", txtQuantity.Text);
            cmd.Parameters.AddWithValue("@p5", CustomerId);
            cmd.Parameters.AddWithValue("@p6", cmbItem.Text);
            cmd.Parameters.AddWithValue("@p7",TotalItemWeight);
            cmd.Parameters.AddWithValue("@p8", ProductsId);
            cmd.Parameters.AddWithValue("@p9", DateTime.Now.ToString("dd-MMM-yyyy"));


            cmd.ExecuteNonQuery();
            SQL.baglanti().Close();
            MessageBox.Show(txtQuantity.Text+" Adet "+cmbItem.Text+"Eklendi.",caption:"İnformation");
        
        }

       
    }
}
