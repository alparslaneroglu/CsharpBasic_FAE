﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CsharpBasic_FAE_Main
{
    public partial class AnaForm : Form
    {
        private bool Acik = false; // Orjinalde de false default değer false olarak gelir.
        public AnaForm()  
        {
            InitializeComponent();
        }

        private void AnaForm_Load(object sender, EventArgs e)
        {
            gbUst.Size = new Size(5, 5);
            
        }

        

        private void btnConsole_Click(object sender, EventArgs e)
        {
            //gbUst.Text = "Console Islemleri"; Alttaki ile aynı işlem yapılıyor.
            gbUst.Text = btnConsole.Text;
            ToggleBtn();
            pnl1.Visible = true;
            pnl2.Visible = false;
            pnl3.Visible = false;
            pnl4.Visible = false;
            pnl5.Visible = false;
            pnl6.Visible = false;
            pnl7.Visible = false;
        }

        private void btnForm_Click(object sender, EventArgs e)
        {
            gbUst.Text = btnForm.Text;
            ToggleBtn();
            pnl1.Visible = false;
            pnl2.Visible = true;
            pnl3.Visible = false;
            pnl4.Visible = false;
            pnl5.Visible = false;
            pnl6.Visible = false;
            pnl7.Visible = false;
        }
        private void ToggleBtn()
        {
            /*if (gbUst.Text != "***")
            {
                gbUst.Size = new Size(5, 70);       Butonlar arası groupbox'ı kapatmadan geçiş yapmayı çöz.
                Acik = true;
            }*/

            if (Acik == false)
            {
                gbUst.Size = new Size(5, 70);
                Acik = true;
            }
            else
            {
                gbUst.Size = new Size(5, 5);
                Acik = false;
                gbUst.Text = "***";


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            gbUst.Text = btn3.Text;
            ToggleBtn();
            pnl1.Visible = false;
            pnl2.Visible = false;
            pnl3.Visible = true;
            pnl4.Visible = false;
            pnl5.Visible = false;
            pnl6.Visible = false;
            pnl7.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            gbUst.Text = btn4.Text;
            ToggleBtn();
            pnl1.Visible = false;
            pnl2.Visible = false;
            pnl3.Visible = false;
            pnl4.Visible = true;
            pnl5.Visible = false;
            pnl6.Visible = false;
            pnl7.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            gbUst.Text = btn5.Text;
            ToggleBtn();
            pnl1.Visible = true;
            pnl2.Visible = false;
            pnl3.Visible = false;
            pnl4.Visible = false;
            pnl5.Visible = true;
            pnl6.Visible = false;
            pnl7.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            gbUst.Text = btn6.Text;
            ToggleBtn();
            pnl1.Visible = false;
            pnl2.Visible = false;
            pnl3.Visible = false;
            pnl4.Visible = false;
            pnl5.Visible = false;
            pnl6.Visible = true;
            pnl7.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            gbUst.Text = btn7.Text;
            ToggleBtn();
            pnl1.Visible = false;
            pnl2.Visible = false;
            pnl3.Visible = false;
            pnl4.Visible = false;
            pnl5.Visible = false;
            pnl6.Visible = false;
            pnl7.Visible = true;
        }

        #region Console Islemleri
        private void btnHello_Click(object sender, EventArgs e)
        {
            // C: \Users\Web ve Mobil Prog\source\repos\CsharpBasic_FAE\FirstConsoleApp\bin\Debug\net5.0\FirstConsoleApp.exe

            Process.Start(@"C:\Users\Web ve Mobil Prog\source\repos\CsharpBasic_FAE\FirstConsoleApp\bin\Debug\net5.0\FirstConsoleApp.exe");

        }

       
        #endregion
    }
}
