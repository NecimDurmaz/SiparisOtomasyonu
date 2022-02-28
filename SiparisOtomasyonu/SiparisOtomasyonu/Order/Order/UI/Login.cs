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
using Order.UI;

namespace Order
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100,0,0,0);
          
        }


        DAL.DAL sql = new DAL.DAL();
        public int Id;

        private void bttnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

      

        private void bttnLogin_Click(object sender, EventArgs e)
        {
            if (radioCustomer.Checked==true)
            {
                SqlCommand komut = new SqlCommand("Select * From Tbl_Customer Where CustomerName=@p1 and CustomerPassword=@p2", sql.baglanti());
                komut.Parameters.AddWithValue("@p1", txtID.Text);
                komut.Parameters.AddWithValue("@p2", txtSifre.Text);

                SqlDataReader dr = komut.ExecuteReader();
                if (dr.Read())
                {
                    Id = Convert.ToInt32(dr["CustomerID"]);
                    UI.CustomerMenu cm = new UI.CustomerMenu();
                    cm.CustomerMenuCustomerID=Id;
                    cm.Show();
                    this.Hide();




                }
                else 
                {
                    MessageBox.Show("Wrong username or password", "Information");

                }
            }
            else if (radioAdmin.Checked==true)
            {
                SqlCommand komut = new SqlCommand("Select * From Admin Where AdminName=@p1 and AdminPassword=@p2", sql.baglanti());
                komut.Parameters.AddWithValue("@p1", txtID.Text);
                komut.Parameters.AddWithValue("@p2", txtSifre.Text);

                SqlDataReader dr = komut.ExecuteReader();
                if (dr.Read())
                {
                    Id = Convert.ToInt32(dr["AdminID"]);
                    UI.AdminMenu adminMenu = new UI.AdminMenu();
                    
                    adminMenu.Show();
                    this.Hide();




                }
                else
                {
                    MessageBox.Show("Wrong username or password", "Information");

                }
            }
            else
            {
                // radiobutton seçilmezse
                MessageBox.Show("please select entry from button. ");
            }

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            CustomerSign customerSign = new CustomerSign();
            customerSign.Show();
        }

     
    }

       
    
}
