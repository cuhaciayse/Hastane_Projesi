using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Hastane_Projesi
{
    public partial class FrmHastaGiris : Form
    {
        public FrmHastaGiris()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void lnkUyeOl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmHastaKayit frm = new FrmHastaKayit();
            frm.Show();

        }

        private void btngiris_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("select * from Tbl_Hastalar where HastaTC=@p1 and HastaSifre=@p2", bgl.connection());
            command.Parameters.AddWithValue("@p1", mskdtxtTC.Text);
            command.Parameters.AddWithValue("@p2", txtsifre.Text);
            SqlDataReader reader = command.ExecuteReader();  //command dan gelen verileri oku
            if (reader.Read())
            {
                FrmHastaDetay frm = new FrmHastaDetay();  //hastadetay formuna git
                frm.tc = mskdtxtTC.Text;  //bu formdaki masked texte yazdırdığını tc değişkenine ata formlar arası geçiş yapıyoruz Hasta detaya
                frm.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Hatalı şifre ve TC girdiniz");
            }
            bgl.connection().Close();
            

        }
    }
}
