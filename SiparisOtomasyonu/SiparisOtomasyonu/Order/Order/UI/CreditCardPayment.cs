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
    public partial class CreditCardPayment : Form
    {
        public int price;
        public int CreditCustomerID;
        DAL.DAL sql = new DAL.DAL();
        public CreditCardPayment()
        {
            InitializeComponent();
        }
        public int KartId;
        private void button1_Click(object sender, EventArgs e)
        {
           Models.PaymentTips.Credit credit = new Models.PaymentTips.Credit();

            credit.CreditNumber = maskedTextBox1.Text.ToString();
            credit.CVV=Convert.ToInt32(txtCVV.Text);
            credit.expdate=txtSKT.Text;
            credit.Password=Convert.ToInt32(txtPassword.Text);
            credit.Amount=price;

            string information=credit.authorized(CreditCustomerID);

            if(information=="Your payment has been made successfully.")
            {
                MessageBox.Show(information, "İnformation");
                this.Hide();
            }
            else if (information=="Payment failed. Incorrect card information.")
            {
                MessageBox.Show(information, "İnformation");
            }
          

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddCreditCart addCreditCart = new AddCreditCart();
            addCreditCart.Show();
    
        }

        private void CreditCardPayment_Load(object sender, EventArgs e)
        {
            txtPrice.Text = price.ToString();
        }
    }
}
