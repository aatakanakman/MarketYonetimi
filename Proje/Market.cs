using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje
{
    public class Market:IMarket
    {
        sqlBaglanti connect = new sqlBaglanti();
        public string MarketAd { get; set; }
        public string MarketAdres { get; set; }

        public List<Market> Marketler { get; set; }

        public List<Urun> Urunler { get; set; }

        public List<Calisan> Calisanlar { get; set; }
        public Market()
        {
            this.Calisanlar = new List<Calisan>();
            this.Urunler = new List<Urun>();
            this.Marketler = new List<Market>();
        }

        public void MarketEkle(Market market)
        {
            SqlCommand Ekle = new SqlCommand("insert into tbl_market (Ad,Adres) values (@p1,@p2)", connect.baglanti());
            Ekle.Parameters.AddWithValue("@p1", market.MarketAd);
            Ekle.Parameters.AddWithValue("@p2", market.MarketAdres);
       
            Ekle.ExecuteNonQuery();
            connect.baglanti().Close();
        }

        public void MarketGetir()
        {
        //    SqlCommand MarketBilgiGetir = new SqlCommand("Select * From Tbl_Market", connect.baglanti());
        //    SqlDataReader dr = MarketBilgiGetir.ExecuteReader();
        //    if (dr.Read())
        //    {
        //        MarketAd = dr[1].ToString();
        //        MarketAdres = dr[2].ToString();
        //        Marketler.Add()
        //    }
        //    connect.baglanti().Close();

            SqlCommand select = new SqlCommand("select * from tbl_market", connect.baglanti());
            SqlDataReader Dtr = select.ExecuteReader();
                while (Dtr.Read())
                {

                Market market = new Market()
                {
                MarketAd = Dtr[1].ToString(),
                MarketAdres = Dtr[2].ToString()
                };
                
                Marketler.Add(market);
            }

            }

        public void MarketGuncelle(Market market)
        {
            SqlCommand MarketBilgiGuncelle = new SqlCommand("update Tbl_Market set MarketAd=@a1,MarketAdres=@a2", connect.baglanti());
            MarketBilgiGuncelle.Parameters.AddWithValue("@a1", MarketAd);
            MarketBilgiGuncelle.Parameters.AddWithValue("@a2", MarketAdres);

            MarketBilgiGuncelle.ExecuteNonQuery();
            connect.baglanti().Close();
        }

        public void MarketSil(Market market)
        {
            SqlCommand delete = new SqlCommand("delete from Tbl_Market where MarketAd=@a1", connect.baglanti());
            delete.Parameters.AddWithValue("@a1", MarketAd);
            delete.ExecuteNonQuery();
            connect.baglanti().Close();
        }
    }
}
