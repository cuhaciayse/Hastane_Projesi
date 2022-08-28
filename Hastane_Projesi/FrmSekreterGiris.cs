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
    public partial class FrmSekreterGiris : Form
    {
        public FrmSekreterGiris()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl=new sqlbaglantisi();  
        private void btngiris_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("select * from  Tbl_Sekreterler where SekreterTC=@p1 and SekreterSifre=@p2", bgl.connection());
            command.Parameters.AddWithValue("@p1", mskdtxtTC.Text);
            command.Parameters.AddWithValue("@p2", txtsifre.Text);
            SqlDataReader reader=command.ExecuteReader();
            if (reader.Read())
            {
                FrmSekreterDetay frm = new FrmSekreterDetay();
                frm.TCNO = mskdtxtTC.Text;
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı TC veya Şifre girdiniz");
            }
            bgl.connection().Close();
        }
    }
}
