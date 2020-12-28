using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje
{
    public class Mudur:Calisan
    {
        sqlBaglanti db = new sqlBaglanti();
        public Mudur()
        {

        }
        public override void MaasHesapla()
        {
            base.MaasHesapla();
            maas *= 4M;
        }

        public DataTable MudurGetir()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from tbl_mudur", db.baglanti());
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            return tablo;

        }

        public void MudurGuncelle(Mudur mudur)
        {
            string sorgu = "UPDATE tbl_mudur SET kullanici_ad = @ad , sifre = @sifre WHERE ıd = @id";
            SqlCommand komut = new SqlCommand(sorgu, db.baglanti()); ;

            komut.Parameters.AddWithValue("@id", mudur.ID);
            komut.Parameters.AddWithValue("@ad", mudur.Ad);
            komut.Parameters.AddWithValue("@sifre", mudur.Soyad);


            komut.ExecuteNonQuery();


        }
    }
}
