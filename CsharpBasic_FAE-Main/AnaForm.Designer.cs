
namespace CsharpBasic_FAE_Main
{
    partial class AnaForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlUst = new System.Windows.Forms.Panel();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btnForm = new System.Windows.Forms.Button();
            this.btnConsole = new System.Windows.Forms.Button();
            this.gbUst = new System.Windows.Forms.GroupBox();
            this.pnl7 = new System.Windows.Forms.Panel();
            this.pnl6 = new System.Windows.Forms.Panel();
            this.pnl5 = new System.Windows.Forms.Panel();
            this.pnl4 = new System.Windows.Forms.Panel();
            this.pnl3 = new System.Windows.Forms.Panel();
            this.pnl2 = new System.Windows.Forms.Panel();
            this.pnl1 = new System.Windows.Forms.Panel();
            this.btnHello = new System.Windows.Forms.Button();
            this.pnlUst.SuspendLayout();
            this.gbUst.SuspendLayout();
            this.pnl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlUst
            // 
            this.pnlUst.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlUst.Controls.Add(this.btn7);
            this.pnlUst.Controls.Add(this.btn6);
            this.pnlUst.Controls.Add(this.btn5);
            this.pnlUst.Controls.Add(this.btn4);
            this.pnlUst.Controls.Add(this.btn3);
            this.pnlUst.Controls.Add(this.btnForm);
            this.pnlUst.Controls.Add(this.btnConsole);
            this.pnlUst.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUst.Location = new System.Drawing.Point(0, 0);
            this.pnlUst.Name = "pnlUst";
            this.pnlUst.Size = new System.Drawing.Size(1392, 70);
            this.pnlUst.TabIndex = 0;
            
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn7.Location = new System.Drawing.Point(785, 12);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(118, 52);
            this.btn7.TabIndex = 6;
            this.btn7.Text = "btn7";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.button5_Click);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn6.Location = new System.Drawing.Point(651, 12);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(118, 52);
            this.btn6.TabIndex = 5;
            this.btn6.Text = "btn6";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.button4_Click);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.Color.Aqua;
            this.btn5.Location = new System.Drawing.Point(518, 12);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(118, 52);
            this.btn5.TabIndex = 4;
            this.btn5.Text = "btn5";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.Lime;
            this.btn4.Location = new System.Drawing.Point(384, 12);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(118, 52);
            this.btn4.TabIndex = 3;
            this.btn4.Text = "btn4";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn3.Location = new System.Drawing.Point(251, 12);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(118, 52);
            this.btn3.TabIndex = 2;
            this.btn3.Text = "btn3";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnForm
            // 
            this.btnForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnForm.Location = new System.Drawing.Point(127, 12);
            this.btnForm.Name = "btnForm";
            this.btnForm.Size = new System.Drawing.Size(109, 52);
            this.btnForm.TabIndex = 1;
            this.btnForm.Text = "Form İslemleri";
            this.btnForm.UseVisualStyleBackColor = false;
            this.btnForm.Click += new System.EventHandler(this.btnForm_Click);
            // 
            // btnConsole
            // 
            this.btnConsole.BackColor = System.Drawing.Color.Red;
            this.btnConsole.Location = new System.Drawing.Point(12, 12);
            this.btnConsole.Name = "btnConsole";
            this.btnConsole.Size = new System.Drawing.Size(109, 52);
            this.btnConsole.TabIndex = 0;
            this.btnConsole.Text = "Console İslemleri";
            this.btnConsole.UseVisualStyleBackColor = false;
            this.btnConsole.Click += new System.EventHandler(this.btnConsole_Click);
            // 
            // gbUst
            // 
            this.gbUst.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.gbUst.Controls.Add(this.pnl7);
            this.gbUst.Controls.Add(this.pnl6);
            this.gbUst.Controls.Add(this.pnl5);
            this.gbUst.Controls.Add(this.pnl4);
            this.gbUst.Controls.Add(this.pnl3);
            this.gbUst.Controls.Add(this.pnl2);
            this.gbUst.Controls.Add(this.pnl1);
            this.gbUst.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbUst.Location = new System.Drawing.Point(0, 70);
            this.gbUst.Name = "gbUst";
            this.gbUst.Size = new System.Drawing.Size(1392, 75);
            this.gbUst.TabIndex = 0;
            this.gbUst.TabStop = false;
            this.gbUst.Text = "*******";
            this.gbUst.UseWaitCursor = true;
            
            // 
            // pnl7
            // 
            this.pnl7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.pnl7.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl7.Location = new System.Drawing.Point(3, 323);
            this.pnl7.Name = "pnl7";
            this.pnl7.Size = new System.Drawing.Size(1386, 50);
            this.pnl7.TabIndex = 9;
            this.pnl7.UseWaitCursor = true;
            this.pnl7.Visible = false;
            // 
            // pnl6
            // 
            this.pnl6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnl6.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl6.Location = new System.Drawing.Point(3, 273);
            this.pnl6.Name = "pnl6";
            this.pnl6.Size = new System.Drawing.Size(1386, 50);
            this.pnl6.TabIndex = 8;
            this.pnl6.UseWaitCursor = true;
            this.pnl6.Visible = false;
            // 
            // pnl5
            // 
            this.pnl5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.pnl5.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl5.Location = new System.Drawing.Point(3, 223);
            this.pnl5.Name = "pnl5";
            this.pnl5.Size = new System.Drawing.Size(1386, 50);
            this.pnl5.TabIndex = 7;
            this.pnl5.UseWaitCursor = true;
            this.pnl5.Visible = false;
            // 
            // pnl4
            // 
            this.pnl4.BackColor = System.Drawing.Color.Aqua;
            this.pnl4.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl4.Location = new System.Drawing.Point(3, 173);
            this.pnl4.Name = "pnl4";
            this.pnl4.Size = new System.Drawing.Size(1386, 50);
            this.pnl4.TabIndex = 6;
            this.pnl4.UseWaitCursor = true;
            this.pnl4.Visible = false;
            // 
            // pnl3
            // 
            this.pnl3.BackColor = System.Drawing.Color.Lime;
            this.pnl3.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl3.Location = new System.Drawing.Point(3, 123);
            this.pnl3.Name = "pnl3";
            this.pnl3.Size = new System.Drawing.Size(1386, 50);
            this.pnl3.TabIndex = 4;
            this.pnl3.UseWaitCursor = true;
            this.pnl3.Visible = false;
            // 
            // pnl2
            // 
            this.pnl2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.pnl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl2.Location = new System.Drawing.Point(3, 73);
            this.pnl2.Name = "pnl2";
            this.pnl2.Size = new System.Drawing.Size(1386, 50);
            this.pnl2.TabIndex = 3;
            this.pnl2.UseWaitCursor = true;
            this.pnl2.Visible = false;
            // 
            // pnl1
            // 
            this.pnl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.pnl1.Controls.Add(this.btnHello);
            this.pnl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl1.Location = new System.Drawing.Point(3, 23);
            this.pnl1.Name = "pnl1";
            this.pnl1.Size = new System.Drawing.Size(1386, 50);
            this.pnl1.TabIndex = 2;
            this.pnl1.UseWaitCursor = true;
            this.pnl1.Visible = false;
            // 
            // btnHello
            // 
            this.btnHello.Location = new System.Drawing.Point(9, 15);
            this.btnHello.Name = "btnHello";
            this.btnHello.Size = new System.Drawing.Size(142, 29);
            this.btnHello.TabIndex = 0;
            this.btnHello.Text = "Hello World!";
            this.btnHello.UseVisualStyleBackColor = true;
            this.btnHello.Click += new System.EventHandler(this.btnHello_Click);
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1392, 753);
            this.Controls.Add(this.gbUst);
            this.Controls.Add(this.pnlUst);
            this.Name = "AnaForm";
            this.Text = "AnaSayfa";
            this.Load += new System.EventHandler(this.AnaForm_Load);
            this.pnlUst.ResumeLayout(false);
            this.gbUst.ResumeLayout(false);
            this.pnl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlUst;
        private System.Windows.Forms.GroupBox gbUst;
        private System.Windows.Forms.Button btnConsole;
        private System.Windows.Forms.Button btnForm;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Panel pnl7;
        private System.Windows.Forms.Panel pnl6;
        private System.Windows.Forms.Panel pnl5;
        private System.Windows.Forms.Panel pnl4;
        private System.Windows.Forms.Panel pnl3;
        private System.Windows.Forms.Panel pnl2;
        private System.Windows.Forms.Panel pnl1;
        private System.Windows.Forms.Button btnHello;
    }
}

