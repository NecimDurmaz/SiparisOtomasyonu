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

namespace Order
{
    public partial class NewItem : Form
    {
        DAL.DAL SQL = new DAL.DAL();

        public NewItem()
        {
            InitializeComponent();
        }
     
    
        private void Item_Load(object sender, EventArgs e)
        {
           
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
            dialog = MessageBox.Show("Piece Price= "+item.Price+"\n"+"Piece Weight = "+item.ShippingWeight+"\n"+"Adding "+item.ItemQuantity+" pieces.", "Information", MessageBoxButtons.YesNo);
            if (dialog==DialogResult.Yes)
            {
                SqlCommand cmd = new SqlCommand("Insert Into Products (ProductType,ProductWeight,ProductPrice,ProductSize,ProductDescription,ProductQuantity,ProductMaterial) VALUES (@p1,@p2,@p3,@p4,@p5,@p6,@p7)", SQL.baglanti());
                cmd.Parameters.AddWithValue("@p1",item.ItemType );
                cmd.Parameters.AddWithValue("@p2",item.ShippingWeight );
                cmd.Parameters.AddWithValue("@p3",item.Price );
                cmd.Parameters.AddWithValue("@p4",item.ItemSize);
                cmd.Parameters.AddWithValue("@p5",item.ItemDescription);
                cmd.Parameters.AddWithValue("@p6",item.ItemQuantity );
                cmd.Parameters.AddWithValue("@p7", item.ItemMaterial);
                cmd.ExecuteNonQuery();
                SQL.baglanti().Close();
                MessageBox.Show(" Added "+item.ItemQuantity+" "+item.ItemType,"INFORMATION");

            }
           


           

        }

      
     

        private void btnIncrease10_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(txtQuantity.Text);
            x+=10;
            txtQuantity.Text=x.ToString();

        }

        private void btnDecrement10_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(txtQuantity.Text);
            x-=10;
            txtQuantity.Text=x.ToString();
        }

        private void btnDecrement_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(txtQuantity.Text);
            x-=1;
            txtQuantity.Text=x.ToString();

        }

        private void btnIncrease_Click_1(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(txtQuantity.Text);
            x+=1;
            txtQuantity.Text=x.ToString();
        }
    }
}
