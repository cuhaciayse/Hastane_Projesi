namespace Hastane_Projesi
{
    partial class FrmHastaKayit
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtsoyad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtsifre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.mskdtxtTC = new System.Windows.Forms.MaskedTextBox();
            this.mskdtxtTelefon = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbcinsiyet = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnKayityap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(171, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "Ad:";
            // 
            // txtad
            // 
            this.txtad.Location = new System.Drawing.Point(229, 46);
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(137, 28);
            this.txtad.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(145, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 21);
            this.label1.TabIndex = 9;
            this.label1.Text = "Soyad:";
            // 
            // txtsoyad
            // 
            this.txtsoyad.Location = new System.Drawing.Point(229, 107);
            this.txtsoyad.Name = "txtsoyad";
            this.txtsoyad.Size = new System.Drawing.Size(137, 28);
            this.txtsoyad.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(165, 327);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 21);
            this.label3.TabIndex = 11;
            this.label3.Text = "Şifre:";
            // 
            // txtsifre
            // 
            this.txtsifre.Location = new System.Drawing.Point(229, 327);
            this.txtsifre.Name = "txtsifre";
            this.txtsifre.Size = new System.Drawing.Size(137, 28);
            this.txtsifre.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(181, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 21);
            this.label4.TabIndex = 13;
            this.label4.Text = "T.C:";
            // 
            // mskdtxtTC
            // 
            this.mskdtxtTC.Location = new System.Drawing.Point(229, 163);
            this.mskdtxtTC.Mask = "00000000000";
            this.mskdtxtTC.Name = "mskdtxtTC";
            this.mskdtxtTC.Size = new System.Drawing.Size(137, 28);
            this.mskdtxtTC.TabIndex = 3;
            // 
            // mskdtxtTelefon
            // 
            this.mskdtxtTelefon.Location = new System.Drawing.Point(229, 224);
            this.mskdtxtTelefon.Mask = "(999) 000-0000";
            this.mskdtxtTelefon.Name = "mskdtxtTelefon";
            this.mskdtxtTelefon.Size = new System.Drawing.Size(137, 28);
            this.mskdtxtTelefon.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(145, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 21);
            this.label5.TabIndex = 15;
            this.label5.Text = "Telefon:";
            // 
            // cmbcinsiyet
            // 
            this.cmbcinsiyet.FormattingEnabled = true;
            this.cmbcinsiyet.Items.AddRange(new object[] {
            "Kadın ",
            "Erkek"});
            this.cmbcinsiyet.Location = new System.Drawing.Point(229, 277);
            this.cmbcinsiyet.Name = "cmbcinsiyet";
            this.cmbcinsiyet.Size = new System.Drawing.Size(137, 29);
            this.cmbcinsiyet.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(156, 277);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 21);
            this.label6.TabIndex = 17;
            this.label6.Text = "Cinsiyet:";
            // 
            // btnKayityap
            // 
            this.btnKayityap.Location = new System.Drawing.Point(229, 391);
            this.btnKayityap.Name = "btnKayityap";
            this.btnKayityap.Size = new System.Drawing.Size(137, 38);
            this.btnKayityap.TabIndex = 18;
            this.btnKayityap.Text = "Kayıt Yap";
            this.btnKayityap.UseVisualStyleBackColor = true;
            this.btnKayityap.Click += new System.EventHandler(this.btnKayityap_Click);
            // 
            // FrmHastaKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(628, 497);
            this.Controls.Add(this.btnKayityap);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbcinsiyet);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.mskdtxtTelefon);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.mskdtxtTC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtsifre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtsoyad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtad);
            this.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmHastaKayit";
            this.Text = "Hasta Kayıt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtsoyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtsifre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox mskdtxtTC;
        private System.Windows.Forms.MaskedTextBox mskdtxtTelefon;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbcinsiyet;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnKayityap;
    }
}