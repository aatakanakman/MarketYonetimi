using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje
{
    public partial class frmUrun : Form
    {
        Urun urun = new Urun();
        sqlBaglanti db = new sqlBaglanti();
        decimal indirim;
        string kampanyaZamani = MudurKampanya.indirimZamani;
        string zaman;


        public frmUrun()
        {
            InitializeComponent();
        }

        private void frmUrun_Load(object sender, EventArgs e)
        {
           // label8.Text = MudurKampanya.indirimZamani;
          UrunnGetir();
        }

        void UrunnGetir()
        {
            DataTable tablo = new DataTable();
            tablo = urun.UrunGetir();
            dataGridView1.DataSource = tablo;
        }

        void sonIndirimGoster()
        {
            
            SqlDataAdapter da = new SqlDataAdapter("select i.indirimTarihi,u.Ad from tbl_urun U , tbl_indirimZmn i where u.ID = i.urunId order by i.indirimTarihi DESC", db.baglanti());
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView2.DataSource = tablo;
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtAd.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtFiyat.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtStok.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtTedarikci_id.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtTedarikci.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtSektör.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            
        }

        private void ekleBtn_Click(object sender, EventArgs e)
        {
            Urun urun = new Urun();
            urun.UrunAd = txtAd.Text;
            urun.StokMiktari = Convert.ToInt32( txtStok.Text);
            urun.Fiyat = Convert.ToInt32(txtFiyat.Text);
            urun.tedarikci_id = Convert.ToInt32(txtTedarikci_id.Text);
            urun.UrunEkle(urun);
            UrunnGetir();
        }

        private void silBtn_Click(object sender, EventArgs e)
        {
            Urun urun = new Urun();
            urun.UrunAd = txtAd.Text;
            urun.UrunSil(urun);
            UrunnGetir();
        }

        private void guncelleBtn_Click(object sender, EventArgs e)
        {
            
            Urun urun = new Urun();
            indirimZamaniLbl.Text = DateTime.Now.ToString();
            //zaman = indirimZamaniLbl.Text;
            urun.UrunAd = txtAd.Text;
            urun.StokMiktari = Convert.ToInt32(txtStok.Text);
            urun.Fiyat = Convert.ToInt32(txtFiyat.Text);
            urun.tedarikci_id = Convert.ToInt32(txtTedarikci_id.Text);
            urun.UrunGuncelle(urun);
            UrunnGetir();
        }

        private void indirimBtn_Click(object sender, EventArgs e)
        {
            sonIndirimGoster();
        }

        private void yntcIndirim_Click(object sender, EventArgs e)
        {

        }
    }

}
