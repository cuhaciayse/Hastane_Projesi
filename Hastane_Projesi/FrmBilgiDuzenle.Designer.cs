namespace Hastane_Projesi
{
    partial class FrmBilgiDuzenle
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
            this.label6 = new System.Windows.Forms.Label();
            this.cmbcinsiyet = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.mskdtxtTelefon = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.mskdtxtTC = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtsifre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtsoyad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtad = new System.Windows.Forms.TextBox();
            this.btnBilgiGuncelle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(74, 277);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 21);
            this.label6.TabIndex = 29;
            this.label6.Text = "Cinsiyet:";
            // 
            // cmbcinsiyet
            // 
            this.cmbcinsiyet.FormattingEnabled = true;
            this.cmbcinsiyet.Location = new System.Drawing.Point(147, 277);
            this.cmbcinsiyet.Name = "cmbcinsiyet";
            this.cmbcinsiyet.Size = new System.Drawing.Size(137, 29);
            this.cmbcinsiyet.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(63, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 21);
            this.label5.TabIndex = 27;
            this.label5.Text = "Telefon:";
            // 
            // mskdtxtTelefon
            // 
            this.mskdtxtTelefon.Location = new System.Drawing.Point(147, 224);
            this.mskdtxtTelefon.Mask = "(999) 000-0000";
            this.mskdtxtTelefon.Name = "mskdtxtTelefon";
            this.mskdtxtTelefon.Size = new System.Drawing.Size(137, 28);
            this.mskdtxtTelefon.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(99, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 21);
            this.label4.TabIndex = 25;
            this.label4.Text = "T.C:";
            // 
            // mskdtxtTC
            // 
            this.mskdtxtTC.Location = new System.Drawing.Point(147, 163);
            this.mskdtxtTC.Mask = "00000000000";
            this.mskdtxtTC.Name = "mskdtxtTC";
            this.mskdtxtTC.Size = new System.Drawing.Size(137, 28);
            this.mskdtxtTC.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(83, 327);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 21);
            this.label3.TabIndex = 23;
            this.label3.Text = "Şifre:";
            // 
            // txtsifre
            // 
            this.txtsifre.Location = new System.Drawing.Point(147, 327);
            this.txtsifre.Name = "txtsifre";
            this.txtsifre.Size = new System.Drawing.Size(137, 28);
            this.txtsifre.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 21);
            this.label1.TabIndex = 21;
            this.label1.Text = "Soyad:";
            // 
            // txtsoyad
            // 
            this.txtsoyad.Location = new System.Drawing.Point(147, 107);
            this.txtsoyad.Name = "txtsoyad";
            this.txtsoyad.Size = new System.Drawing.Size(137, 28);
            this.txtsoyad.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 21);
            this.label2.TabIndex = 19;
            this.label2.Text = "Ad:";
            // 
            // txtad
            // 
            this.txtad.Location = new System.Drawing.Point(147, 46);
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(137, 28);
            this.txtad.TabIndex = 1;
            // 
            // btnBilgiGuncelle
            // 
            this.btnBilgiGuncelle.Location = new System.Drawing.Point(147, 387);
            this.btnBilgiGuncelle.Name = "btnBilgiGuncelle";
            this.btnBilgiGuncelle.Size = new System.Drawing.Size(137, 38);
            this.btnBilgiGuncelle.TabIndex = 30;
            this.btnBilgiGuncelle.Text = "Güncelle";
            this.btnBilgiGuncelle.UseVisualStyleBackColor = true;
            this.btnBilgiGuncelle.Click += new System.EventHandler(this.btnBilgiGuncelle_Click);
            // 
            // FrmBilgiDuzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(627, 513);
            this.Controls.Add(this.btnBilgiGuncelle);
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
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmBilgiDuzenle";
            this.Text = "Bilgi Düzenle";
            this.Load += new System.EventHandler(this.FrmBilgiDuzenle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbcinsiyet;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox mskdtxtTelefon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox mskdtxtTC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtsifre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtsoyad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtad;
        private System.Windows.Forms.Button btnBilgiGuncelle;
    }
}