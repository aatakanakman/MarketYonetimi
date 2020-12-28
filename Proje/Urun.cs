using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje
{
    public class Urun:IUrun
    {
        
        
        public string UrunAd { get; set; }
        public decimal Fiyat { get; set; }
        public int StokMiktari { get; set; }
        //public Tedarikci Tedarikci { get; set; }
        public int tedarikci_id { get; set; }
        public int IndirimMiktari { get; set; }
        public  string indirimZamani { get; set; }


        sqlBaglanti db = new sqlBaglanti();

        

        public void UrunEkle(Urun urun)
        {

            
                db.baglanti();
                SqlCommand komut = new SqlCommand("INSERT INTO tbl_urun(Ad,Stok,Fiyat,tedarikci_id) VALUES (@ad,@stok,@fiyat,@tedarikci_id)", db.baglanti());

                komut.Parameters.AddWithValue("@ad", urun.UrunAd);
                komut.Parameters.AddWithValue("@stok", urun.Fiyat);
                komut.Parameters.AddWithValue("@fiyat", urun.StokMiktari);
                komut.Parameters.AddWithValue("@tedarikci_id", urun.tedarikci_id);
                
                komut.ExecuteNonQuery();
            
        }
  
        public DataTable KampanyaUrunGetir()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from tbl_urun where tedarikci_id = 3", db.baglanti());
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            return tablo;
        }

        public DataTable UrunGetir()
        {
            SqlDataAdapter da = new SqlDataAdapter("select c.Ad , c.Fiyat ,c.Stok,c.tedarikci_id, m.Tedarikci_Ad ,m.Sektor from tbl_urun C,tbl_tedarikci M where c.tedarikci_id = m.ID", db.baglanti());
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            return tablo;
        }

        public void UrunGuncelle(Urun urun)
        {
            string sorgu = "UPDATE tbl_urun SET Ad=@ad,Stok=@stok,Fiyat=@fiyat,tedarikci_id=@tedarikci WHERE ad = @ad";
            SqlCommand komut = new SqlCommand(sorgu, db.baglanti()); ;

            komut.Parameters.AddWithValue("@ad", urun.UrunAd);
            komut.Parameters.AddWithValue("@stok", urun.StokMiktari);
            komut.Parameters.AddWithValue("@fiyat", urun.Fiyat);
            komut.Parameters.AddWithValue("@tedarikci", urun.tedarikci_id);
            komut.ExecuteNonQuery();
            indirimZamani = DateTime.Now.ToString();

            

        }

        public void KampanyaUrunGuncelle(Urun urun)
        {
            string sorgu = "UPDATE tbl_urun SET Ad=@ad,Stok=@stok,Fiyat=@fiyat,tedarikci_id=@tedarikci WHERE tedarikci_id = 3";
            SqlCommand komut = new SqlCommand(sorgu, db.baglanti()); ;

            komut.Parameters.AddWithValue("@ad", urun.UrunAd);
            komut.Parameters.AddWithValue("@stok", urun.StokMiktari);
            komut.Parameters.AddWithValue("@fiyat", urun.Fiyat);
            komut.Parameters.AddWithValue("@tedarikci", urun.tedarikci_id);
            komut.ExecuteNonQuery();

        }

        public void UrunSil(Urun urun)
        {
           
                string sorgu = "DELETE FROM tbl_urun WHERE Ad = @ad ";
                SqlCommand komut = new SqlCommand(sorgu, db.baglanti());
                komut.Parameters.AddWithValue("@ad", urun.UrunAd);
                //komut.Parameters.AddWithValue("@soyad", calisan.Soyad);
                komut.ExecuteNonQuery();


            
        }

        public void IndirimUygula(Urun urun)
        {
            string sorgu = "UPDATE tbl_urun SET Fiyat = @fiyat WHERE Ad = @ad";
            SqlCommand komut = new SqlCommand(sorgu, db.baglanti()); ;

            komut.Parameters.AddWithValue("@ad", urun.UrunAd);
            
            komut.Parameters.AddWithValue("@fiyat", urun.Fiyat);
            
            komut.ExecuteNonQuery();
        }


    }
}
