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
using System.Data.SqlClient;

namespace Order.UI
{
    public partial class ProductTransactions : Form
    {
        DAL.DAL sql = new DAL.DAL();
        public int TransasctionsID;
        public ProductTransactions()
        {
            InitializeComponent();
        }
        public void griddoldur()
        {
            SqlCommand komut = new SqlCommand("Select *  From Products  ", sql.baglanti());
            SqlDataAdapter adapter = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            sql.baglanti().Close();
            dataGridView1.DataSource=dt;
            sql.baglanti().Close();

        }

        private void ProductTransactions_Load(object sender, EventArgs e)
        {
            griddoldur();
        }
        public void Clear()
        {
            cmbType.Text="";
            cmbmaterial.Text="";
            cmbSize.Text="";
            txtQuantity.Clear();
            rchProductDesrciption.Clear();
        }
        

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int secilenindex = dataGridView1.SelectedCells[0].RowIndex;
            
            TransasctionsID=Convert.ToInt32( dataGridView1.Rows[secilenindex].Cells[0].Value);
            cmbType.Text = dataGridView1.Rows[secilenindex].Cells[1].Value.ToString();
            cmbmaterial.Text = dataGridView1.Rows[secilenindex].Cells[6].Value.ToString();
            cmbSize.Text = dataGridView1.Rows[secilenindex].Cells[4].Value.ToString();
            txtQuantity.Text = dataGridView1.Rows[secilenindex].Cells[5].Value.ToString();
            rchProductDesrciption.Text = dataGridView1.Rows[secilenindex].Cells[7].Value.ToString();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("delete From Products where ProductID=@p1 ", sql.baglanti());
            komut.Parameters.AddWithValue("@p1", TransasctionsID);
            komut.ExecuteNonQuery();
            sql.baglanti().Close();
            griddoldur();
            Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Models.Item item = new Models.Item();


            item.getWeight(cmbSize.Text,cmbType.Text);
            item.getPriceForQuantity(cmbmaterial.Text, cmbType.Text);


            item.ItemDescription=rchProductDesrciption.Text;
            item.ItemType=cmbType.Text;
            item.ItemMaterial=cmbmaterial.Text;
            item.ItemQuantity=txtQuantity.Text;
            item.ItemSize=cmbSize.Text;

            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show(item.ItemType+"\nAdet Fiyatı= "+item.Price+"\n"+"Adet Agirligi= "+item.ShippingWeight+"\n"+item.ItemQuantity+" Adet olarak güncelleniyor.", "Bilgilendirme", MessageBoxButtons.YesNo);
            if (dialog==DialogResult.Yes)
            {
                SqlCommand cmd = new SqlCommand("update  Products set ProductType=@p1,ProductWeight=@p2,ProductPrice=@p3,ProductSize=@p4,ProductDescription=@p5,ProductQuantity=@p6,ProductMaterial=@p7 where ProductId=@p8", sql.baglanti());
                cmd.Parameters.AddWithValue("@p1", item.ItemType);
                cmd.Parameters.AddWithValue("@p2", item.ShippingWeight);
                cmd.Parameters.AddWithValue("@p3", item.Price);
                cmd.Parameters.AddWithValue("@p4", item.ItemSize);
                cmd.Parameters.AddWithValue("@p5", item.ItemDescription);
                cmd.Parameters.AddWithValue("@p6", item.ItemQuantity);
                cmd.Parameters.AddWithValue("@p7", item.ItemMaterial);
                cmd.Parameters.AddWithValue("@p8", TransasctionsID);
                cmd.ExecuteNonQuery();
                sql.baglanti().Close();
                MessageBox.Show(item.ItemQuantity+" Adet "+item.ItemType+" olarak güncellendi.", "İNFORMATİON");
                griddoldur();
            }
        }

        private void btnIncrease_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(txtQuantity.Text);
            x+=1;
            txtQuantity.Text=x.ToString();
        }

        private void btnIncrease10_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(txtQuantity.Text);
            x+=10;
            txtQuantity.Text=x.ToString();
        }

        private void btnDecrement_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(txtQuantity.Text);
            x-=1;
            txtQuantity.Text=x.ToString();
        }

        private void btnDecrement10_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(txtQuantity.Text);
            x-=10;
            txtQuantity.Text=x.ToString();
        }
    }
}
