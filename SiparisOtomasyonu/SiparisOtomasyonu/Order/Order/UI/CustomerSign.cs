using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Order
{
    public partial class CustomerSign : Form
    {
        public CustomerSign()
        {
            InitializeComponent();
        }

 
        private void CustomerSign_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);

        }
        DAL.DAL sql = new DAL.DAL();

        
        

        private void bttnLogin_Click(object sender, EventArgs e)
        {
            Models.Customer sign = new Models.Customer();
            sign.Name = txtID.Text;
            sign.Password = txtSifre.Text;
            sign.Address=rchAddress.Text;

            SqlCommand cmd = new SqlCommand("insert into Tbl_Customer(CustomerName,CustomerPassword,CustomerAddress) values(@p1,@p2,@p3)", sql.baglanti());

            cmd.Parameters.AddWithValue("@p1", sign.Name);
            cmd.Parameters.AddWithValue("@p2", sign.Password);
            cmd.Parameters.AddWithValue("@p3", sign.Address);
            cmd.ExecuteNonQuery();
            sql.baglanti().Close();
            MessageBox.Show("Kayit Olundu.", "Information");
        }

        private void bttnExit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
