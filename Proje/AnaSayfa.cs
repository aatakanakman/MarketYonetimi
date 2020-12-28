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
    public partial class AnaSayfa : Form
    {
        public AnaSayfa()
        {
            InitializeComponent();
        }

        frmCalisan calisan;
        frmMarket market;
        frmKasiyer kasiyer;
        frmMudur mudur;
        frmUrun urun;
        frmTedarikci tedarikci;

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(calisan == null)
            {
                calisan = new frmCalisan();
                calisan.MdiParent = this;
                calisan.Show();
                
            }
            
        }

        private void AnaSayfa_Load(object sender, EventArgs e)
        {

        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (market == null)
            {
                market = new frmMarket();
                market.MdiParent = this;
                market.Show();

            }
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (kasiyer == null)
            {
                kasiyer = new frmKasiyer();
                kasiyer.MdiParent = this;
                kasiyer.Show();

            }
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (mudur == null)
            {
                mudur = new frmMudur();
                mudur.MdiParent = this;
                mudur.Show();

            }
        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (urun == null)
            {
                urun = new frmUrun();
                urun.MdiParent = this;
                urun.Show();

            }
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (tedarikci == null)
            {
                tedarikci = new frmTedarikci();
                tedarikci.MdiParent = this;
                tedarikci.Show();

            }
        }

        private void AnaSayfa_FormClosed(object sender, FormClosedEventArgs e)
        {
            Giriş_Sayfası grs = new Giriş_Sayfası();
            grs.Show();
            this.Hide();
        }
    }
}
