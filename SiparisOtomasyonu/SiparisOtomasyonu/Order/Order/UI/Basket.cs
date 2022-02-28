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
    public partial class Basket : Form
    {
        public Basket()
        {
            InitializeComponent();
        }
        public void gridlist()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select BasketID,BasketItem,BasketBuyerPrice,BasketBuyerQuantity,BasketDate from Basket where BasketCustomerID=@p1 ", sql.baglanti());
            da.SelectCommand.Parameters.AddWithValue("@p1", basketCustomerID);
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
      public int basketCustomerID;
        DAL.DAL sql = new DAL.DAL();

        private void Basket_Load(object sender, EventArgs e)
        {
     

            gridlist();
          
           Models.OrderDetail od = new Models.OrderDetail();
            od.Order=new Models.Order();
          label1.Text = od.calcSubTotal(basketCustomerID).ToString();


            label5.Text=od.Order.calcTax(Convert.ToInt32(label1.Text)).ToString();
            label7.Text=od.Order.calcTOTAL( Convert.ToInt32(label1.Text),Convert.ToDecimal(label5.Text)).ToString();
        }


     

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (radioCredit.Checked==true)
            {
                CreditCardPayment creditCardPayment = new CreditCardPayment();
                creditCardPayment.price =  Convert.ToInt32(label7.Text);
                creditCardPayment.CreditCustomerID= basketCustomerID;
                creditCardPayment.Show();

            }
            else if (radioCash.Checked==true)
            {
                CashPayment cashPayment = new CashPayment();
                cashPayment.price =  Convert.ToInt32(label7.Text);
                cashPayment.CashCustomerID=basketCustomerID;
                cashPayment.Show();
          
            }
            else if (radioCheck.Checked==true)
            {
               CheckPayment checkPayment = new CheckPayment();
                checkPayment.price = Convert.ToInt32(label7.Text);
                checkPayment.CheckCustomerID= basketCustomerID;
                checkPayment.Show();

            }


        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int secilenindex = dataGridView1.SelectedCells[0].RowIndex;
           int BasketID=Convert.ToInt32(dataGridView1.Rows[secilenindex].Cells[0].Value);
            string basketname= dataGridView1.Rows[secilenindex].Cells[1].Value.ToString();

            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show("Do you want to delete the "+basketname+" from the basket?  ", "ORDER", MessageBoxButtons.YesNo);
            if (dialog==DialogResult.Yes)
            {
                SqlCommand cmd = new SqlCommand("delete from Basket where BasketID=@p1", sql.baglanti());
                cmd.Parameters.AddWithValue("@p1",BasketID);

                cmd.ExecuteNonQuery();
                sql.baglanti().Close();


                MessageBox.Show("The product you selected has been deleted from the basket.");

                gridlist();


            }

        }
    }
}
