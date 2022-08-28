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
    public partial class FrmHastaDetay : Form
    {
        public FrmHastaDetay()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();

        public string tc;

       

        private void FrmHastaDetay_Load(object sender, EventArgs e)
        {
            lblTC.Text= tc;

            // Ad soyad çekme
            SqlCommand command = new SqlCommand("select HastaAd, HastaSoyad from Tbl_Hastalar where HastaTC=@p1", bgl.connection());
            command.Parameters.AddWithValue("@p1", lblTC.Text);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                lbladsoyad.Text = reader[0] + "" + reader[1];
            }
            bgl.connection().Close();

            //randevu geçmişi
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("select * from Tbl_Randevular where HastaTC=" + tc, bgl.connection());
            adapter.Fill(dt);   //data adapter içini doldur tabledan gelen verilerle
            dataGridView1.DataSource = dt;

            //branşları çekme
            SqlCommand command2 = new SqlCommand("select BransAd from Tbl_Branslar ", bgl.connection());
            SqlDataReader reader2 = command2.ExecuteReader();
            while (reader2.Read())
            {
                cmbxbrans.Items.Add(reader2[0]);
            }


        }

        private void cmbxbrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            // branşa tıklandığında doktorları getirme 
            cmbxdoktor.Items.Clear();
            SqlCommand command3 = new SqlCommand("select DoktorAd, DoktorSoyad from Tbl_Doktorlar where DoktorBrans=@p1", bgl.connection());

           command3.Parameters.AddWithValue("@p1",cmbxbrans.Text);
            SqlDataReader reader3=command3.ExecuteReader();
            while (reader3.Read())
            {
                cmbxdoktor.Items.Add(reader3[0] + " " + reader3[1]);
            }
            
            bgl.connection().Close();


        }

        private void cmbxdoktor_SelectedIndexChanged(object sender, EventArgs e)
        {
            //doktoru seçtikten sonra datagridviewe verileri çekeceğiz
            DataTable dt = new DataTable();
            SqlDataAdapter adapter=new SqlDataAdapter("select * from Tbl_Randevular where RandevuBrans='"+ cmbxbrans.Text+ "'"+ "and RandevuDoktor='"+cmbxdoktor.Text+"'and RandevuDurum=0", bgl.connection()); //c# tek tırnak kullanılmaz o yüzde çift tırnağın içine yazıyoruz sql de tek tırnak ile kelime bazlı aratma yaparken kullandıımız için
            adapter.Fill(dt);
            dataGridView2.DataSource = dt;

        }

        private void lnkbilgiduzenle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmBilgiDuzenle frm = new FrmBilgiDuzenle();
            frm.TCno = lblTC.Text;
            frm.Show();
            this.Hide();
        }

        private void btnRandevual_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("update Tbl_Randevular set RandevuDurum=1, HastaTC=@p2, HastaSikayet=@p3 where Randevuid=@p4", bgl.connection());
            command.Parameters.AddWithValue("@p2",lblTC.Text);
            command.Parameters.AddWithValue("@p3",rchSikayet.Text);
            command.Parameters.AddWithValue("@p4", txtid.Text);
            command.ExecuteNonQuery();
            bgl.connection().Close();
            MessageBox.Show("Randevu alındı", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            

        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView2.SelectedCells[0].RowIndex;
            txtid.Text = dataGridView2.Rows[secilen].Cells[0].Value.ToString();
        }
    }
}
