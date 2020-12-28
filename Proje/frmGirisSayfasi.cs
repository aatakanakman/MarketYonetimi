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
    public partial class Giriş_Sayfası : Form
    {
        sqlBaglanti db = new sqlBaglanti();
        public Giriş_Sayfası()
        {
            
            InitializeComponent();
            sifreText.PasswordChar = '*';
        }

        private void yoneticiGiris_Click(object sender, EventArgs e)
        {
            //AnaSayfa anasayfa = new AnaSayfa();
            //anasayfa.Show();
            //this.Hide();

            SqlCommand komut = new SqlCommand("SELECT * FROM tbl_yonetici where kullanici_ad = @kullaniciAd AND sifre = @sifre", db.baglanti());
            komut.Parameters.AddWithValue("@kullaniciAd", kullanıcıAdText.Text);
            komut.Parameters.AddWithValue("@sifre", sifreText.Text);
            komut.ExecuteNonQuery();
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("Tebrikler! Başarılı bir şekilde giriş yaptınız.");
                AnaSayfa anasayfa = new AnaSayfa();
                anasayfa.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adını ve şifrenizi kontrol ediniz.");
            }

        }

        private void mudurGiris_Click(object sender, EventArgs e)
        {
            //MudurKampanya mdr = new MudurKampanya();
            //mdr.ShowDialog();
            //this.Hide();

            SqlCommand komut = new SqlCommand("SELECT * FROM tbl_mudur where kullanici_ad = @kullaniciAd AND sifre = @sifre", db.baglanti());
            komut.Parameters.AddWithValue("@kullaniciAd", kullanıcıAdText.Text);
            komut.Parameters.AddWithValue("@sifre", sifreText.Text);
            komut.ExecuteNonQuery();
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("Tebrikler! Başarılı bir şekilde giriş yaptınız.");
                MudurKampanya mdr = new MudurKampanya();
                mdr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adını ve şifrenizi kontrol ediniz.");
            }
        }

        private void Giriş_Sayfası_Load(object sender, EventArgs e)
        {

        }
    }
}
