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
    public partial class frmTedarikci : Form
    {

        public frmTedarikci()
        {
            InitializeComponent();
        }

        private void frmTedarikci_Load(object sender, EventArgs e)
        {
            tedarikciGetir();
        }
        
        void tedarikciGetir()
        {
            Tedarikci tedarikci = new Tedarikci();
            DataTable tablo = new DataTable();
            tablo = tedarikci.TedarikciGetir();
            dataGridView1.DataSource = tablo;
        }

    }
}
