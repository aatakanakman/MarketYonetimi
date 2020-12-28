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
    public partial class frmMudur : Form
    {
        Mudur mudur = new Mudur();
        public frmMudur()
        {
            InitializeComponent();
        }

        private void frmMudur_Load(object sender, EventArgs e)
        {
            MudurGetir();
        }

        void MudurGetir()
        {


            DataTable tablo = new DataTable();
            tablo = mudur.MudurGetir();
            dataGridView1.DataSource = tablo;
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtKullanici.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtSifre.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }

        private void guncelleBtn_Click(object sender, EventArgs e)
        {
            MudurGuncelle();
        }

        void MudurGuncelle()
        {
            Mudur mudur = new Mudur();
            mudur.ID = Convert.ToInt32(txtId.Text);
            mudur.Ad = txtKullanici.Text;
            mudur.Soyad = txtSifre.Text;
            mudur.MudurGuncelle(mudur);
            MudurGetir();
        }
    }
}
