namespace Hastane_Projesi
{
    partial class FrmGirisler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGirisler));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.d = new System.Windows.Forms.Button();
            this.h = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(230, 296);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Hasta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(486, 296);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Doktor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(771, 296);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Sekreter";
            // 
            // d
            // 
            this.d.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("d.BackgroundImage")));
            this.d.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.d.Location = new System.Drawing.Point(427, 30);
            this.d.Name = "d";
            this.d.Size = new System.Drawing.Size(239, 205);
            this.d.TabIndex = 8;
            this.d.Text = ".";
            this.d.UseVisualStyleBackColor = true;
            this.d.Click += new System.EventHandler(this.d_Click);
            // 
            // h
            // 
            this.h.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("h.BackgroundImage")));
            this.h.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.h.Location = new System.Drawing.Point(152, 27);
            this.h.Name = "h";
            this.h.Size = new System.Drawing.Size(239, 205);
            this.h.TabIndex = 7;
            this.h.Text = ".";
            this.h.UseVisualStyleBackColor = true;
            this.h.Click += new System.EventHandler(this.h_Click);
            // 
            // button3
            // 
            this.button3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Location = new System.Drawing.Point(704, 30);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(239, 205);
            this.button3.TabIndex = 3;
            this.button3.Text = ".";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // FrmGirisler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1021, 391);
            this.Controls.Add(this.d);
            this.Controls.Add(this.h);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmGirisler";
            this.Text = "Girisler";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button h;
        private System.Windows.Forms.Button d;
    }
}

