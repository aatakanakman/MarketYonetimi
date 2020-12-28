using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Proje
{
    public class Calisan:ICalisan
    {
        private const decimal asgariucret = 1000;
        private const int yillikizinmiktari = 14;

        public int ID { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Adres { get; set; }

        public Market Market { get; set; }

        public int  SubeNo { get; set; }

        public decimal maas { get; set; }

        public string izinGunu {get; set;}

        protected int yillikizin = 14;

        public int  departman { get; set; }

        public string BaslangicTarih { get; set; }

        public int zamOrani;

        int kullanilanIzin;


        sqlBaglanti db = new sqlBaglanti();

        public int YillikIzin
        {
            get
            {
                return yillikizin;
            }
            set
            {
                yillikizin = yillikizin - kullanilanIzin;
            }
        }
        public virtual void YillikIzinHesapla()
        {
            yillikizin = yillikizinmiktari;
        }

        public decimal Maas
        {
            get
            {
                return maas;
            }
            set
            {
                maas = maas + zamOrani;
            }
            
        }
        public Calisan()
        {
            this.maas = asgariucret;
            this.yillikizin = 14;
        }
        public virtual void MaasHesapla()
        {
            maas = asgariucret;
        }

        public void CalisanEkle(Calisan calisan)
        {
            
            db.baglanti();
            SqlCommand komut = new SqlCommand("INSERT INTO tbl_calisan(Ad,Soyad,Adres,baslangicT,izinGunu,yillikIzın,maas,departman_id,market_id) VALUES (@ad,@soyad,@adres,@baslangic,@izingunu,@yillik,@maas,@departman,@sube)", db.baglanti());
            
            komut.Parameters.AddWithValue("@ad", calisan.Ad);
            komut.Parameters.AddWithValue("@soyad", calisan.Soyad);
            komut.Parameters.AddWithValue("@adres", calisan.Adres);
            komut.Parameters.AddWithValue("@baslangic", calisan.BaslangicTarih);
            komut.Parameters.AddWithValue("@izingunu",calisan.izinGunu );
            komut.Parameters.AddWithValue("@yillik", calisan.YillikIzin);
            komut.Parameters.AddWithValue("@maas", calisan.maas);
            komut.Parameters.AddWithValue("@departman", calisan.departman);
            komut.Parameters.AddWithValue("@sube", calisan.SubeNo);
            komut.ExecuteNonQuery();
        }

        public void CalisanSil(Calisan calisan)
        {
            string sorgu = "DELETE FROM tbl_calisan WHERE Ad = @ad AND Soyad = @soyad";
            SqlCommand komut = new SqlCommand(sorgu, db.baglanti());
            komut.Parameters.AddWithValue("@ad", calisan.Ad);
            komut.Parameters.AddWithValue("@soyad", calisan.Soyad);
            //komut.Parameters.AddWithValue("@soyad", calisan.Soyad);
            komut.ExecuteNonQuery();
           
            
        }

        public void CalisanGuncelle(Calisan calisan)
        {
            string sorgu = "UPDATE tbl_calisan SET Ad=@ad,Soyad=@soyad,Adres=@adres,baslangicT=@baslangic,izinGunu = @izin,yillikIzın=@yillik," +
                "maas = @maas,departman_id = @departman,market_id = @sube WHERE ad = @ad AND soyad = @soyad" ;
             SqlCommand komut = new SqlCommand(sorgu, db.baglanti()); ;
            
            komut.Parameters.AddWithValue("@ad",calisan.Ad );
            komut.Parameters.AddWithValue("@soyad", calisan.Soyad);
            komut.Parameters.AddWithValue("@adres", calisan.Adres);
            komut.Parameters.AddWithValue("@baslangic", calisan.BaslangicTarih);
            komut.Parameters.AddWithValue("@izin", calisan.izinGunu);
            komut.Parameters.AddWithValue("@yillik",calisan.YillikIzin );
            komut.Parameters.AddWithValue("@maas", calisan.maas);
            komut.Parameters.AddWithValue("@departman",calisan.departman);
            komut.Parameters.AddWithValue("@sube",calisan.SubeNo );
            komut.ExecuteNonQuery();


        }

        public DataTable  CalisanGetir()
        {
            SqlDataAdapter da = new SqlDataAdapter("select c.Ad ,c.Soyad, c.Adres,c.baslangicT,c.izinGunu,c.yillikIzın,c.maas,c.departman_id,c.market_id,m.Ad from tbl_calisan C, tbl_market M where c.market_id = m.ID", db.baglanti());
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            return tablo;
            
        }

        //public void zamUygula(Calisan calisan)
        //{
        //    string sorgu = "UPDATE tbl_calisan SET Ad=@ad,Soyad=@soyad,maas = @maas WHERE ad = @ad AND soyad = @soyad";
        //    SqlCommand komut = new SqlCommand(sorgu, db.baglanti()); ;

        //    komut.Parameters.AddWithValue("@ad", calisan.Ad);
        //    komut.Parameters.AddWithValue("@soyad", calisan.Soyad);
        //    komut.Parameters.AddWithValue("@maas", calisan.maas);
        //    komut.ExecuteNonQuery();
        //}
    }
}
