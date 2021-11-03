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
    public partial class VeriGonderProp : Form
    {
        public VeriGonderProp()
        {
            InitializeComponent();
        }

        private void btnGonder_Click(object sender, EventArgs e)
        {
            NorthwindDataContext db = new NorthwindDataContext();
            VeriAlProp frm = new VeriAlProp();
            
        }

    }
}
