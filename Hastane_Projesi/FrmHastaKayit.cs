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
    public partial class FrmHastaKayit : Form
    {
        public FrmHastaKayit()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();

        private void btnKayityap_Click(object sender, EventArgs e)
        {
            SqlCommand command= new SqlCommand("insert into Tbl_Hastalar (HastaAd,HastaSoyad,HastaTC,HastaTelefon, HastaSifre,HastaCinsiyet) values (@p1,@p2,@p3,@p4,@p5,@p6)", bgl.connection());
            command.Parameters.AddWithValue("@p1", txtad.Text);
            command.Parameters.AddWithValue("@p2", txtsoyad.Text);
            command.Parameters.AddWithValue("@p3", mskdtxtTC.Text);
            command.Parameters.AddWithValue("@p4", mskdtxtTelefon.Text);
            command.Parameters.AddWithValue("@p5", txtsifre.Text);
            command.Parameters.AddWithValue("@p6", cmbcinsiyet.Text);
            command.ExecuteNonQuery();
            bgl.connection().Close();
            MessageBox.Show("Kaydınız gerçekleşmiştir  Şifreniz:"+ txtsifre.Text, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }
    }
}
