using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje
{
    public class Tedarikci : ITedarilkci
    {
        sqlBaglanti db = new sqlBaglanti();
        public string TedarikciAd { get; set; }
        public int tedarikci_id { get; set; }
        public string TedarikciAdres { get; set; }
        public string Sektor { get; set; }

        public DataTable TedarikciGetir()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from tbl_tedarikci", db.baglanti());
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            return tablo;
        }
    }

    

}
