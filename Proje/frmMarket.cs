using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje
{
    public partial class frmMarket : Form
    {
        public frmMarket()
        {
            InitializeComponent();
        }
        Market market = new Market();
        Calisan calisan = new Calisan();
       
        private void Form1_Load(object sender, EventArgs e)
        {
            
            MarketBilgiGetir();
        }

        

        void MarketEkle()
        {
            
            Market market = new Market();
            market.MarketAd = txtMarketAd.Text;
            market.MarketAdres = txtMarketAdres.Text;
            market.MarketEkle(market);
           
        }

        void MarketGuncelle()
        {
            //Market market = new Market();
            ////market.MarketAd = txtAd.Text;
            //market.MarketGuncelle(market);

        }
        void MarketBilgiGetir()
        {
            
            market.MarketGetir();
            DataTable tablo = new DataTable();
            tablo.Columns.Add("MarketAd", typeof(string));
            tablo.Columns.Add("MarketAdres", typeof(string));

            foreach (Market market in market.Marketler)
            {
                tablo.Rows.Add(market.MarketAd, market.MarketAdres);
                dataGridView1.DataSource = tablo;
            }
            market.Marketler.Clear();
            
        }

        private void ekleBtn_Click(object sender, EventArgs e)
        {
           
            MarketEkle();
            MarketBilgiGetir();
        }
    }
}
