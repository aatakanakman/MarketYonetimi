using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje
{
    public class Kasiyer: Calisan 
    {
        sqlBaglanti db = new sqlBaglanti();
             
        public Kasiyer()
        {
               
        }

        
        public override void MaasHesapla()
        {
            base.MaasHesapla();
            maas *= 1.5M;
        }

        public override void YillikIzinHesapla()
        {
            base.YillikIzinHesapla();
            
        }

        public DataTable KasiyerGetir()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from tbl_calisan where departman_id = 1", db.baglanti());
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            return tablo;

        }

        public void KasiyerGuncelle(Kasiyer kasiyer)
        {
            string sorgu = "UPDATE tbl_calisan SET Ad=@ad,Soyad=@soyad,Adres=@adres,izinGunu = @izin,yillikIzın=@yillik," +
                "maas = @maas,departman_id = @departman,market_id = @sube WHERE departman_id = @departman";
            SqlCommand komut = new SqlCommand(sorgu, db.baglanti()); ;

            komut.Parameters.AddWithValue("@ad", kasiyer.Ad);
            komut.Parameters.AddWithValue("@soyad", kasiyer.Soyad);
            komut.Parameters.AddWithValue("@adres", kasiyer.Adres);
            komut.Parameters.AddWithValue("@izin", kasiyer.izinGunu);
            komut.Parameters.AddWithValue("@yillik", kasiyer.YillikIzin);
            komut.Parameters.AddWithValue("@maas", kasiyer.maas);
            komut.Parameters.AddWithValue("@departman", kasiyer.departman);
            komut.Parameters.AddWithValue("@sube", kasiyer.SubeNo);
            komut.ExecuteNonQuery();


        }
    }

    
}
