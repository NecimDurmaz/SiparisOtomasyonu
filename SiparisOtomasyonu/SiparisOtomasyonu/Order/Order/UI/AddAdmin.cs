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
    public partial class AddAdmin : Form
    {
        DAL.DAL sql = new DAL.DAL();
        public AddAdmin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into  Admin (AdminName,AdminPassword) VALUES (@1,@2)", sql.baglanti());
            komut.Parameters.AddWithValue("@1",txtID.Text);
            komut.Parameters.AddWithValue("@2",txtSifre.Text);
            komut.ExecuteNonQuery();
            sql.baglanti().Close();
            MessageBox.Show(" registration has taken place.");
        }
    }
}
