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
    public partial class VeriAlProp : Form
    {
        public List<ModelKisi> elist 
        {
            set { dataGridView1.DataSource = value; }
        }
        public VeriAlProp()
        {
            InitializeComponent();
        }

        private void VeriAlProp_Load(object sender, EventArgs e)
        {

        }
    }
}
