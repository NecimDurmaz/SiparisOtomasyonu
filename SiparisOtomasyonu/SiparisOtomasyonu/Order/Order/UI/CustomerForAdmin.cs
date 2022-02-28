using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Order.UI
{
    public partial class CustomerForAdmin : Form
    {
        DAL.DAL sql = new DAL.DAL();
        public CustomerForAdmin()
        {
            InitializeComponent();
        }
        public void griddoldur()
        {
            SqlCommand komut = new SqlCommand("Select *  From Tbl_Customer", sql.baglanti());
            SqlDataAdapter adapter = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            sql.baglanti().Close();
            dataGridView1.DataSource=dt;
            sql.baglanti().Close();

        }

        private void CustomerForAdmin_Load(object sender, EventArgs e)
        {
            griddoldur();
        }
    }
}
