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
    public partial class AdminMenu : Form
    {
       
        public AdminMenu()
        {
            InitializeComponent();
        }

        private void kullanıcılarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerForAdmin customerForAdmin = new CustomerForAdmin();
            customerForAdmin.MdiParent=this;
            customerForAdmin.Show();
        }

        private void ürünİslemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductTransactions transaction = new ProductTransactions();    
            transaction.MdiParent = this;   
            transaction.Show(); 
        }

        private void ürünEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewItem newItem = new NewItem();
            newItem.MdiParent = this;   
            newItem.Show();
        }

        private void aDMİNEKLEMEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddAdmin addAdmin = new AddAdmin();
            addAdmin.MdiParent = this;
            addAdmin.Show();
        }

        private void AdminMenu_Load(object sender, EventArgs e)
        {

        }

        private void siparişlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrderForAdmin orderForAdmin = new OrderForAdmin();
            orderForAdmin.MdiParent = this; 
            orderForAdmin.Show();   
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
