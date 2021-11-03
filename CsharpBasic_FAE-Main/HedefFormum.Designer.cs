
namespace CsharpBasic_FAE_Main
{
    partial class HedefFormum
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Ad = new System.Windows.Forms.Label();
            this.Soyad = new System.Windows.Forms.Label();
            this.Adres = new System.Windows.Forms.Label();
            this.lblAd = new System.Windows.Forms.Label();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.lblAdres = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Ad
            // 
            this.Ad.Location = new System.Drawing.Point(73, 59);
            this.Ad.Name = "Ad";
            this.Ad.Size = new System.Drawing.Size(157, 25);
            this.Ad.TabIndex = 0;
            this.Ad.Text = "Ad";
            this.Ad.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Soyad
            // 
            this.Soyad.Location = new System.Drawing.Point(73, 103);
            this.Soyad.Name = "Soyad";
            this.Soyad.Size = new System.Drawing.Size(157, 25);
            this.Soyad.TabIndex = 0;
            this.Soyad.Text = "Soyad";
            this.Soyad.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Adres
            // 
            this.Adres.Location = new System.Drawing.Point(73, 148);
            this.Adres.Name = "Adres";
            this.Adres.Size = new System.Drawing.Size(157, 25);
            this.Adres.TabIndex = 0;
            this.Adres.Text = "Adres";
            this.Adres.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAd
            // 
            this.lblAd.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblAd.Location = new System.Drawing.Point(236, 59);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(157, 25);
            this.lblAd.TabIndex = 0;
            this.lblAd.Text = "label1";
            this.lblAd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSoyad
            // 
            this.lblSoyad.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblSoyad.Location = new System.Drawing.Point(236, 103);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(157, 25);
            this.lblSoyad.TabIndex = 0;
            this.lblSoyad.Text = "label1";
            this.lblSoyad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAdres
            // 
            this.lblAdres.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblAdres.Location = new System.Drawing.Point(236, 148);
            this.lblAdres.Name = "lblAdres";
            this.lblAdres.Size = new System.Drawing.Size(238, 150);
            this.lblAdres.TabIndex = 0;
            this.lblAdres.Text = "label1";
            // 
            // HedefFormum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 649);
            this.Controls.Add(this.Adres);
            this.Controls.Add(this.lblAdres);
            this.Controls.Add(this.lblSoyad);
            this.Controls.Add(this.Soyad);
            this.Controls.Add(this.lblAd);
            this.Controls.Add(this.Ad);
            this.Name = "HedefFormum";
            this.Text = "HedefFormum";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Ad;
        private System.Windows.Forms.Label Soyad;
        private System.Windows.Forms.Label Adres;
        public System.Windows.Forms.Label lblAd;
        public System.Windows.Forms.Label lblSoyad;
        public System.Windows.Forms.Label lblAdres;
    }
}