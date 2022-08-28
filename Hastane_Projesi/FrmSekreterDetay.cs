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
    public partial class FrmSekreterDetay : Form
    {
        public FrmSekreterDetay()
        {
            InitializeComponent();
        }
        public string TCNO;
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void FrmSekreterDetay_Load(object sender, EventArgs e)
        {
            lblTC.Text=TCNO;

            SqlCommand command = new SqlCommand("select * from Tbl_Sekreterler where SekreterTC=@p1", bgl.connection());
            command.Parameters.AddWithValue("@p1", lblTC.Text);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                lbladsoyad.Text = reader[1].ToString();
            }
            bgl.connection().Close();

            //Branşları Datagridviewe aktarma

            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("select * from Tbl_Branslar", bgl.connection());
            adapter.Fill(dt);
            dataGridView2.DataSource=dt;

            //Doktorları listeye aktarma

            DataTable dt2 = new DataTable();
            SqlDataAdapter adapter2 = new SqlDataAdapter("select (DoktorAd +' '+ DoktorSoyad) as Doktorlar, DoktorBrans from Tbl_Doktorlar ", bgl.connection());
            adapter2.Fill(dt2);
            dataGridView3.DataSource = dt2;

            //Branşı comboboxa aktarma

            SqlCommand command2 = new SqlCommand("select BransAd from Tbl_Branslar",bgl.connection());
            SqlDataReader reader2=command2.ExecuteReader();
            while (reader2.Read())
            {
                cmbbrans.Items.Add(reader2[0]);
            }



        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("insert into Tbl_Randevular(RandevuTarih,RandevuSaat, RandevuBrans,RandevuDoktor) values (@p1,@p2,@p3,@p4)", bgl.connection());
            command.Parameters.AddWithValue("@p1", mskdTarih.Text);
            command.Parameters.AddWithValue("@p2", mskdsaat.Text);
            command.Parameters.AddWithValue("@p3", cmbbrans.SelectedIndex);
            command.Parameters.AddWithValue("@p4", cmbdoktor.SelectedIndex);
            command.ExecuteNonQuery();
            bgl.connection().Close();
            MessageBox.Show("Randevu Oluşturuldu");



        }

        private void cmbbrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbdoktor.Items.Clear();

            SqlCommand command = new SqlCommand("select DoktorAd, DoktorSoyad from Tbl_Doktorlar where DoktorBrans=@p1", bgl.connection());
            command.Parameters.AddWithValue("@p1", cmbbrans.Text);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                cmbdoktor.Items.Add(reader[0] + " " + reader[1]);
            }
            bgl.connection().Close();
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("update Tbl_Randevular set RandevuSaat=@p1, RandevuTarih=@p2 where HastaTC=@p3", bgl.connection());
            command.Parameters.AddWithValue("@p1", mskdsaat.Text);
            command.Parameters.AddWithValue("@p2", mskdsaat.Text);
            command.Parameters.AddWithValue("@p3", mskdTC.Text);
            command.ExecuteNonQuery();
            bgl.connection().Close();

        }

        private void btnolustur_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("insert into Tbl_Duyurular (duyuru) values (@d1)", bgl.connection());
            command.Parameters.AddWithValue("@d1", richTextBox1.Text);
            command.ExecuteNonQuery();
            bgl.connection().Close();
            MessageBox.Show("Duyuru Oluşturuldu");

        }

        private void btndoktorpaneli_Click(object sender, EventArgs e)
        {
            FrmDoktorPaneli frm = new FrmDoktorPaneli();
            frm.Show();
        }

        private void btnbranspaneli_Click(object sender, EventArgs e)
        {
            FrmBrans frm = new FrmBrans();
            frm.Show();
        }

        private void btnlisele_Click(object sender, EventArgs e)
        {
            FrmRandevuListesi frm = new FrmRandevuListesi();
            frm.Show();
        }

        private void btnDuyurular_Click(object sender, EventArgs e)
        {
            FrmDuyurular frm = new FrmDuyurular();
            frm.Show();
        }
    }
}
