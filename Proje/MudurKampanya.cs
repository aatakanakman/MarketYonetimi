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
    public partial class MudurKampanya : Form
    {
        Urun urun = new Urun();
        public static string  indirimZamani;
        sqlBaglanti db = new sqlBaglanti();
        public MudurKampanya()
        {
            InitializeComponent();
        }

        private void MudurKampanya_Load(object sender, EventArgs e)
        {
            KampanyaUrunListele();
            
        }

        void KampanyaUrunListele()
        {
            DataTable tablo = new DataTable();
            tablo = urun.KampanyaUrunGetir();
            dataGridView1.DataSource = tablo;
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            
            txtAd.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtStok.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtTedarikci_id.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtFyt.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            
        }

        private void indirimKaydet_Click(object sender, EventArgs e)
        {
            Urun urun = new Urun();
            urun.UrunAd = txtAd.Text;
            urun.StokMiktari = Convert.ToInt32(txtStok.Text);
            urun.Fiyat = Convert.ToInt32(txtFyt.Text);
            urun.tedarikci_id = Convert.ToInt32(txtTedarikci_id.Text);
            urun.KampanyaUrunGuncelle(urun);
            indirimZamani = DateTime.Now.ToString();
            KampanyaUrunListele();
            MessageBox.Show("Kampanya Tarihi : " + indirimZamani);

            SqlCommand komut = new SqlCommand("INSERT INTO tbl_indirimZmn(indirimTarihi,urunId) VALUES (@zaman,@id)", db.baglanti());

            komut.Parameters.AddWithValue("@zaman", indirimZamani);
            komut.Parameters.AddWithValue("@id", dataGridView1.CurrentRow.Cells[0].Value.ToString());

            komut.ExecuteNonQuery();
        }

        private void MudurKampanya_FormClosed(object sender, FormClosedEventArgs e)
        {
            Giriş_Sayfası grs = new Giriş_Sayfası();
            grs.Show();
            this.Hide();
        }
    }
}
