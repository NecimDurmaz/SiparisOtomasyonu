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
namespace Order.UI
{
    public partial class CheckPayment : Form
    {
        DAL.DAL sql = new DAL.DAL();
        public int price;
        public int CheckCustomerID;

        public CheckPayment()
        {
            InitializeComponent();
        }

        private void CheckPayment_Load(object sender, EventArgs e)
        {
            lblPrice.Text =price.ToString();

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            groupBox1.Visible = true;
        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            Models.PaymentTips.Check check = new Models.PaymentTips.Check();
            check.BankID = txtADDBankID.Text;
            check.HoldersName=txtAddHoldersName.Text;



            SqlCommand cmd = new SqlCommand("insert into CheckPayment(CheckHolderName,CheckBankName,CheckCustomerID) values (@p1,@p2,@p3) ",sql.baglanti());
            cmd.Parameters.AddWithValue("@p1",check.HoldersName);
            cmd.Parameters.AddWithValue("@p2",check.BankID);
            cmd.Parameters.AddWithValue("@p3", CheckCustomerID);
            cmd.ExecuteNonQuery();
            sql.baglanti().Close();
            MessageBox.Show("The check has been successfully added.");
            groupBox1.Visible=false;

        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            Models.PaymentTips.Check check = new Models.PaymentTips.Check();
            check.BankID = txtBankID.Text;
            check.HoldersName=txtHoldersName.Text;
            check.Amount=price;
           string information =check.authorized(CheckCustomerID);

            if (information=="Your payment has been made successfully.")
            {
                MessageBox.Show(information, "İnformation");
                this.Hide();
            }
            else if (information=="Your payment has not been made. Incorrect Check Information.")
            {
                MessageBox.Show(information, "İnformation");
            }

        }
    }
}
