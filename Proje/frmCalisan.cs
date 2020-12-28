using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Proje
{
    public partial class frmCalisan : Form
    {
        Calisan calisan = new Calisan();
        DataTable tablo = new DataTable();
        sqlBaglanti db = new sqlBaglanti();
        public frmCalisan()
        {
            InitializeComponent();
        }

        private void frmCalisan_Load(object sender, EventArgs e)
        {
            
            CalisanGetir();
        }

        void CalisanGetir()
        {


            DataTable tablo = new DataTable();
            tablo = calisan.CalisanGetir();
            dataGridView1.DataSource = tablo;
        }

        void CalisanSil()
        {
            Calisan calisan = new Calisan();
            calisan.Ad = txtAd.Text;
            calisan.Soyad = txtSoyad.Text;
            calisan.CalisanSil(calisan);


            //if (Convert.ToInt32(textBox9.Text) == 3)
            //{
            //    SqlCommand komut = new SqlCommand("DELETE FROM tbl_mudur WHERE kullanici_ad = @ad", db.Baglanti());
            //    komut.Parameters.AddWithValue("@ad", textBox2.Text);

            //    komut.ExecuteNonQuery();

            //    /*komut2 = new SqlCommand("DELETE FROM tbl_calisan WHERE departman_id = @id)", db.Baglanti());
            //    komut2.Parameters.AddWithValue("@id", textBox9.Text);*/



            //}
        }

        void CalisanGuncelle()
        {
            
            Calisan calisan = new Calisan();
            decimal yeniMaas = calisan.maas * calisan.zamOrani;
            string eskiMaas = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            if (Convert.ToInt32(txtMaas.Text) < Convert.ToInt32(eskiMaas))
            {
                MessageBox.Show("Maaş üzerinden düşürme yapamazsınız!");
            }
            else
            {
                calisan.Ad = txtAd.Text;
                calisan.Soyad = txtSoyad.Text;
                calisan.Adres = txtAdres.Text;
                calisan.BaslangicTarih = txtTarih.Text;
                calisan.izinGunu = txtIzinGun.Text;
                calisan.maas = Convert.ToInt32(txtMaas.Text);
                calisan.departman = Convert.ToInt32(txtDepartman.Text);
                calisan.SubeNo = Convert.ToInt32(txtSube.Text);

                if (Convert.ToInt32(txtDepartman.Text) == 3)
                {
                    SqlCommand komut = new SqlCommand("INSERT INTO tbl_mudur(kullanici_ad,sifre) VALUES(@ad,@sifre)", db.baglanti());
                    komut.Parameters.AddWithValue("@ad", txtAd.Text);
                    komut.Parameters.AddWithValue("@sifre", txtSoyad.Text);
                    komut.ExecuteNonQuery();



                    /*komut2 = new SqlCommand("DELETE FROM tbl_calisan WHERE departman_id = @id)", db.Baglanti());
                    komut2.Parameters.AddWithValue("@id", textBox9.Text);*/



                }

                calisan.CalisanGuncelle(calisan);
            }
            
            
        }

        void CalisanEkle()
        {
            if(txtAdres.Text == "")
            {
                MessageBox.Show("Adresi olmayan çalışana güvenilmez.");
            }
            else
            {
                Calisan calisan = new Calisan();
                calisan.Ad = txtAd.Text;
                calisan.Soyad = txtSoyad.Text;
                calisan.Adres = txtAdres.Text;
                calisan.BaslangicTarih = txtTarih.Text;
                calisan.izinGunu = txtIzinGun.Text;
                calisan.maas = Convert.ToInt32(txtMaas.Text);
                calisan.departman = Convert.ToInt32(txtDepartman.Text);
                calisan.SubeNo = Convert.ToInt32(txtSube.Text);


                if (Convert.ToInt32(txtDepartman.Text) == 3)
                {
                    SqlCommand komut = new SqlCommand("INSERT INTO tbl_mudur(kullanici_ad,sifre) VALUES(@ad,@sifre)", db.baglanti());
                    komut.Parameters.AddWithValue("@ad", txtAd.Text);
                    komut.Parameters.AddWithValue("@sifre", txtSoyad.Text);
                    komut.ExecuteNonQuery();



                    /*komut2 = new SqlCommand("DELETE FROM tbl_calisan WHERE departman_id = @id)", db.Baglanti());
                    komut2.Parameters.AddWithValue("@id", textBox9.Text);*/



                }

                calisan.CalisanEkle(calisan);
            }
            
        }

        

        private void ekleBtn_Click(object sender, EventArgs e)
        {
            CalisanEkle();
            
            CalisanGetir();
            
        }

        private void silBtn_Click(object sender, EventArgs e)
        {
            CalisanSil();

            CalisanGetir();
            
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtAd.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtSoyad.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtAdres.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtTarih.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtIzinGun.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtYillik.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtMaas.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            txtDepartman.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            txtSube.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
        }

        private void guncelleBtn_Click(object sender, EventArgs e)
        {
            CalisanGuncelle();
            CalisanGetir();
        }

       
    }
}
