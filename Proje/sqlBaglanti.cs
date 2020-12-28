using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje
{
    public class sqlBaglanti
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-FUMRB92\\SQLEXPRESS01;Initial Catalog=MarketYonetim;Integrated Security=True");
            baglan.Open();

            return baglan;
        }
    }
}
