using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Order.UI
{
    public partial class CustomerMenu : Form
    {
        public int CustomerMenuCustomerID;
        public CustomerMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void bilgilerimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewOrder f1 = new NewOrder();
            f1.MdiParent=this;
            f1.CustomerId=this.CustomerMenuCustomerID;
            f1.Show(); 
        }

        private void CustomerMenu_Load(object sender, EventArgs e)
        {

        }

        private void sepetimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Basket basket = new Basket();
            basket.MdiParent=this;
            basket.basketCustomerID=this.CustomerMenuCustomerID;
            basket.Show();
        }


        private void aktifSiparişlerimToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            OnlineOrder onlineOrder = new OnlineOrder();
            onlineOrder.orderID =this.CustomerMenuCustomerID;
            onlineOrder.MdiParent=this;
            onlineOrder.Show();
        }

        private void kargoDurumuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void geçmişSiparişlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PassiveOrder passiveOrder = new PassiveOrder();
            passiveOrder.orderID=this.CustomerMenuCustomerID;
            passiveOrder.MdiParent=this;    
            passiveOrder.Show();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
