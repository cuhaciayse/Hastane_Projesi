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
    public partial class FrmBilgiDuzenle : Form
    {
        public FrmBilgiDuzenle()
        {
            InitializeComponent();
        }
        public string TCno;
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void FrmBilgiDuzenle_Load(object sender, EventArgs e)
        {
            mskdtxtTC.Text = TCno;  //TCno dan gelen veriyi masked a yazdır 
            SqlCommand command = new SqlCommand("select * from Tbl_Hastalar  where HastaTC=@p1", bgl.connection());
            command.Parameters.AddWithValue("@p1", mskdtxtTC.Text);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                txtad.Text = reader[1].ToString();
                txtsoyad.Text = reader[2].ToString();
                mskdtxtTC.Text = reader[3].ToString();
                mskdtxtTelefon.Text = reader[4].ToString();
                txtsifre.Text = reader[5].ToString();
                cmbcinsiyet.Text = reader[6].ToString();

            }
            bgl.connection().Close();


        }

        private void btnBilgiGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand command2 = new SqlCommand("update Tbl_Hastalar set HastaTelefon=@p1, HastaSifre=@p2 where HastaTC=@p3", bgl.connection());
            command2.Parameters.AddWithValue("@p1", mskdtxtTelefon.Text);
            command2.Parameters.AddWithValue("@p2", txtsifre.Text);
            command2.Parameters.Add("@p3", mskdtxtTC.Text);
            command2.ExecuteNonQuery();
            bgl.connection().Close();
            MessageBox.Show("Bilgileriniz güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
