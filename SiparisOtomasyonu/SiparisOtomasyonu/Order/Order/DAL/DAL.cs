using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Order.DAL
{



    public class DAL
    {
        


        public SqlConnection baglanti()
        {
            SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-O30S5K7\\SQLEXPRESS;Initial Catalog=Siparis;Integrated Security=True");
            baglanti.Open();
            return baglanti;
        }
        

    }
}
