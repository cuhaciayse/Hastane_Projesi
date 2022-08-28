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
    public partial class FrmDoktorGiris : Form
    {
        public FrmDoktorGiris()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();

        private void btngiris_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("select * from Tbl_Doktorlar where DoktorTC=@p1 and DoktorSifre=@p2", bgl.connection());
            command.Parameters.AddWithValue("@p1", mskdtxtTC.Text);
            command.Parameters.AddWithValue("@p2", txtsifre.Text);
            SqlDataReader dr = command.ExecuteReader();
            if (dr.Read())
            {
                FrmDoktorDetay frm = new FrmDoktorDetay();
                frm.TC = mskdtxtTC.Text;
                frm.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Hatalı giriş yaptınız");
            }
            bgl.connection().Close();
            
        }
    }
}
