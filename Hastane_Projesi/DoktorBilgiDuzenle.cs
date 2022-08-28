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
    public partial class DoktorBilgiDuzenle : Form
    {
        public DoktorBilgiDuzenle()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        public string TCNO;
        private void DoktorBilgiDuzenle_Load(object sender, EventArgs e)
        {
            mskdtxtTC.Text = TCNO;
            SqlCommand command = new SqlCommand("select * from Tbl_Doktorlar where DoktorTC=@p1", bgl.connection());
            command.Parameters.AddWithValue("@p1", mskdtxtTC.Text);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                txtad.Text = reader[1].ToString();
                txtsoyad.Text = reader[2].ToString();
                cmbxBrans.Text = reader[3].ToString();
                mskdtxtTelefon.Text = reader[4].ToString();
                txtsifre.Text = reader[5].ToString();
            }
            bgl.connection().Close();
        }

        private void btnBilgiGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("update Tbl_Doktorlar set DoktorAd=@p1, DoktorSoyad=@p2,DoktorBrans=@p3, DoktorSifre=@p4 where DoktorTC=@p5", bgl.connection());
            command.Parameters.AddWithValue("@p1", txtad.Text);
            command.Parameters.AddWithValue("@p2", txtsoyad.Text);
            command.Parameters.AddWithValue("@p3", cmbxBrans.Text);
            command.Parameters.AddWithValue("@p4", txtsifre.Text);
            command.Parameters.AddWithValue("@p5", mskdtxtTC.Text);
            command.ExecuteNonQuery();
            bgl.connection().Close();
            MessageBox.Show("Kayıt güncellendi");
        }
    }
}
