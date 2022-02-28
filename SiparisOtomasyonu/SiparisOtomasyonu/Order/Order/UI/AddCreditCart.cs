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
    public partial class AddCreditCart : Form
    {
        DAL.DAL sql= new DAL.DAL(); 
        public AddCreditCart()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Models.PaymentTips.Credit credit= new Models.PaymentTips.Credit();

            credit.CreditNumber=mskdCartNumber.Text.ToString();
            credit.expdate= txtExpDate.Text;
            credit.CVV=Convert.ToInt32(txtCVV.Text);
            credit.Password=Convert.ToInt32(txtPassword.Text);
            SqlCommand komut = new SqlCommand("insert into  CreditCart (CartNumber,CartCvv,CartTHRU,CartPassword) VALUES (@p1,@p2,@p3,@p4)", sql.baglanti());
            komut.Parameters.AddWithValue("@p1", credit.CreditNumber);
            komut.Parameters.AddWithValue("@p2",credit.CVV);
            komut.Parameters.AddWithValue("@p3", credit.expdate);
            komut.Parameters.AddWithValue("@p4",credit.Password);

            komut.ExecuteNonQuery();
            sql.baglanti().Close();
            MessageBox.Show("Add card.");
            this.Hide();
        }

        private void AddCreditCart_Load(object sender, EventArgs e)
        {

        }
    }
}
