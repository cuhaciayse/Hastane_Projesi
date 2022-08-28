namespace Hastane_Projesi
{
    partial class FrmHastaGiris
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
            this.mskdtxtTC = new System.Windows.Forms.MaskedTextBox();
            this.txtsifre = new System.Windows.Forms.TextBox();
            this.lnkUyeOl = new System.Windows.Forms.LinkLabel();
            this.btngiris = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mskdtxtTC
            // 
            this.mskdtxtTC.Location = new System.Drawing.Point(259, 115);
            this.mskdtxtTC.Mask = "00000000000";
            this.mskdtxtTC.Name = "mskdtxtTC";
            this.mskdtxtTC.Size = new System.Drawing.Size(129, 28);
            this.mskdtxtTC.TabIndex = 0;
            // 
            // txtsifre
            // 
            this.txtsifre.Location = new System.Drawing.Point(259, 170);
            this.txtsifre.Name = "txtsifre";
            this.txtsifre.Size = new System.Drawing.Size(129, 28);
            this.txtsifre.TabIndex = 1;
            this.txtsifre.UseSystemPasswordChar = true;
            // 
            // lnkUyeOl
            // 
            this.lnkUyeOl.AutoSize = true;
            this.lnkUyeOl.Location = new System.Drawing.Point(412, 173);
            this.lnkUyeOl.Name = "lnkUyeOl";
            this.lnkUyeOl.Size = new System.Drawing.Size(57, 21);
            this.lnkUyeOl.TabIndex = 2;
            this.lnkUyeOl.TabStop = true;
            this.lnkUyeOl.Text = "Üye Ol";
            this.lnkUyeOl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkUyeOl_LinkClicked);
            // 
            // btngiris
            // 
            this.btngiris.Location = new System.Drawing.Point(275, 228);
            this.btngiris.Name = "btngiris";
            this.btngiris.Size = new System.Drawing.Size(113, 33);
            this.btngiris.TabIndex = 3;
            this.btngiris.Text = "Giriş Yap";
            this.btngiris.UseVisualStyleBackColor = true;
            this.btngiris.Click += new System.EventHandler(this.btngiris_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(211, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "T.C:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(201, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Şifre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Corbel", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(209, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(226, 35);
            this.label3.TabIndex = 6;
            this.label3.Text = "Hasta Giriş Paneli";
            // 
            // FrmHastaGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(606, 306);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btngiris);
            this.Controls.Add(this.lnkUyeOl);
            this.Controls.Add(this.txtsifre);
            this.Controls.Add(this.mskdtxtTC);
            this.Font = new System.Drawing.Font("Corbel", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmHastaGiris";
            this.Text = "Hasta Giris";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mskdtxtTC;
        private System.Windows.Forms.TextBox txtsifre;
        private System.Windows.Forms.LinkLabel lnkUyeOl;
        private System.Windows.Forms.Button btngiris;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}