using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CsharpBasic_FAE_Main
{
    public partial class ilkFormum : Form
    {
        public ilkFormum()
        {
            InitializeComponent();
        }

       

        private void ilkFormum_Load(object sender, EventArgs e)
        {

        }
        void Temizle()
        {
            txtAd.Text = "";
            txtAdres.Text = "";
            txtSoyad.Clear();
        }
        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void btnGonder_Click(object sender, EventArgs e)
        {
            HedefFormum frmHedef = new HedefFormum();
            frmHedef.lblAd.Text = txtAd.Text;
            frmHedef.lblAdres.Text = txtAdres.Text;
            frmHedef.lblSoyad.Text = txtSoyad.Text;
            frmHedef.Show();
            Temizle();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
