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
    public partial class frmKasiyer : Form
    {
        Kasiyer kasiyer = new Kasiyer();
        sqlBaglanti db = new sqlBaglanti();
        public frmKasiyer()
        {
            InitializeComponent();
        }

        private void frmKasiyer_Load(object sender, EventArgs e)
        {
          KasiyerGetir();
        }

        void KasiyerGetir()
        {


            DataTable tablo = new DataTable();
            tablo = kasiyer.KasiyerGetir();
            dataGridView1.DataSource = tablo;
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtAd.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtSoyad.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtAdres.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtIzinGun.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtYillik.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            txtMaas.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            txtDepartman.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            txtSube.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
        }
        void KasiyerGuncelle()
        {
            string eskiMaas = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            if (Convert.ToInt32(txtMaas.Text) < Convert.ToInt32(eskiMaas))
            {
                MessageBox.Show("Maaş üzerinden düşürme yapamazsınız!");
            }
            else
            {
                kasiyer.Ad = txtAd.Text;
                kasiyer.Soyad = txtSoyad.Text;
                kasiyer.Adres = txtAdres.Text;
                kasiyer.izinGunu = txtIzinGun.Text;
                kasiyer.maas = Convert.ToInt32(txtMaas.Text);
                kasiyer.departman = Convert.ToInt32(txtDepartman.Text);
                kasiyer.SubeNo = Convert.ToInt32(txtSube.Text);

                kasiyer.KasiyerGuncelle(kasiyer);
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if(Convert.ToInt32(txtDepartman.Text) == 3)
            {
                SqlCommand komut = new SqlCommand("INSERT INTO tbl_mudur(kullanici_ad,sifre) VALUES(@ad,@sifre)", db.baglanti());
                komut.Parameters.AddWithValue("@ad", txtAd.Text);
                komut.Parameters.AddWithValue("@sifre", txtSoyad.Text);
                komut.ExecuteNonQuery();

                string sorgu = "DELETE FROM tbl_calisan WHERE Ad = @ad AND Soyad = @soyad";
                SqlCommand komut2 = new SqlCommand(sorgu, db.baglanti());
                komut2.Parameters.AddWithValue("@ad", txtAd.Text);
                komut2.Parameters.AddWithValue("@soyad", txtSoyad.Text);


                komut2.ExecuteNonQuery();
            }
            KasiyerGuncelle();
            KasiyerGetir();
        }
    }
}
