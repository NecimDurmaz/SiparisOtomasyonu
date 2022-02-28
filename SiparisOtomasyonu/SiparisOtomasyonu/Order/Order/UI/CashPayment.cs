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
    public partial class CashPayment : Form
    {
        public CashPayment()
        {
            InitializeComponent();
        }
        public int price;
        public int CashCustomerID;
        public int Quantity;
        DAL.DAL sql = new DAL.DAL();
        private void CashPayment_Load(object sender, EventArgs e)
        {
            int sale = price/10;

            label1.Text =price.ToString();
            label3.Text =sale.ToString();
            label6.Text =(price-sale).ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //int totalprice = Convert.ToInt32(label6.Text);
            //int cashtendered=Convert.ToInt32(textBox1.Text);
            //if (cashtendered<totalprice)
            //{
            //    label6.Text=" ";
            //    MessageBox.Show("value less than the amount cannot be entered ", caption:"ERROR");
            //}
            //else
            //{
            //    label9.Text=(cashtendered-totalprice).ToString();
            //}
          
        }

        private void button7_Click(object sender, EventArgs e)
        {
           Models.PaymentTips.Cash cash=new Models.PaymentTips.Cash();

            cash.Amount = Convert.ToInt32(label6.Text);
            cash.CashTendered = Convert.ToInt32(txtCashTendered.Text);
            if (cash.CashTendered<cash.Amount)
            {
                txtCashTendered.Text="0";
                MessageBox.Show("value less than the amount cannot be entered ", caption: "ERROR");
            }
            else
            {
                int payback = cash.CashTendered-cash.Amount;
                DialogResult dialog = new DialogResult();
                dialog = MessageBox.Show(payback+" your remaining money Do you want to confirm the order?  ", "ORDER", MessageBoxButtons.YesNo);
                if (dialog==DialogResult.Yes)
                {
                   SqlCommand cmd = new SqlCommand("delete from Basket where BasketCustomerID=@p1",sql.baglanti());
                    cmd.Parameters.AddWithValue("@p1",CashCustomerID);
                    cmd.ExecuteNonQuery();
                    sql.baglanti().Close();

                   
                    MessageBox.Show("The payment process has been completed. You are being redirected to the Main Menu.");
                    this.Hide();
                    



                }
                

            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(txtCashTendered.Text);
            x +=5;
            txtCashTendered.Text= x.ToString();
        }

        private void btn10_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(txtCashTendered.Text);
            x +=10;
            txtCashTendered.Text= x.ToString();
        }

        private void btn20_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(txtCashTendered.Text);
            x +=20;
            txtCashTendered.Text= x.ToString();
        }

        private void btn50_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(txtCashTendered.Text);
            x +=50;
            txtCashTendered.Text= x.ToString();
        }

        private void btn100_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(txtCashTendered.Text);
            x +=100;
            txtCashTendered.Text= x.ToString();
        }

        private void btn200_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(txtCashTendered.Text);
            x +=200;
            txtCashTendered.Text= x.ToString();
        }
    }
}
