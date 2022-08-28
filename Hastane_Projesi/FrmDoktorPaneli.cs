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
    public partial class FrmDoktorPaneli : Form
    {
        public FrmDoktorPaneli()
        {
            InitializeComponent();
        }
         sqlbaglantisi bgl= new sqlbaglantisi();
        private void FrmDoktorPaneli_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("select * from Tbl_Doktorlar", bgl.connection());
            adapter.Fill(dt);   
            dataGridView1.DataSource= dt;


            // Branşları comboboxa aktarma 

            SqlCommand command2 = new SqlCommand("select BransAd from Tbl_Branslar", bgl.connection());
            SqlDataReader reader2 = command2.ExecuteReader();
            while (reader2.Read())
            {
                cmbBrans.Items.Add(reader2[0]);
            }
        }
       public  void Listele()
        {
            SqlCommand command = new SqlCommand("select * from Tbl_Doktorlar", bgl.connection());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;


        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("insert into Tbl_Doktorlar (DoktorAd, DoktorSoyad,DoktorBrans,DoktorTC,DoktorSifre) values (@p1,@p2,@p3,@p4,@p5)", bgl.connection());
            command.Parameters.AddWithValue("@p1", txtad.Text);
            command.Parameters.AddWithValue("@p2", txtsoyad.Text);
            command.Parameters.AddWithValue("@p3", cmbBrans.Text);
            command.Parameters.AddWithValue("@p4", mskdtxtTC.Text);
            command.Parameters.AddWithValue("@p5", txtsifre.Text);
            command.ExecuteNonQuery();
            bgl.connection().Close();
            MessageBox.Show("Doktor eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listele();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtad.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtsoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            cmbBrans.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            mskdtxtTC.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            txtsifre.Text= dataGridView1.Rows[secilen].Cells[5].Value.ToString();   

        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("delete from Tbl_Doktorlar where DoktorTC=@p1", bgl.connection());
            command.Parameters.AddWithValue("@p1", mskdtxtTC.Text);
            command.ExecuteNonQuery();
            bgl.connection().Close();
            MessageBox.Show("Kayıt silindi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            Listele();
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("update Tbl_Doktorlar set DoktorAd=@p1, DoktorSoyad=@p2, DoktorBrans=@p3, DoktorSifre=@p5 where DoktorTC=@p4", bgl.connection());

            command.Parameters.AddWithValue("@p1", txtad.Text);
            command.Parameters.AddWithValue("@p2", txtsoyad.Text);
            command.Parameters.AddWithValue("@p3", cmbBrans.Text);
            command.Parameters.AddWithValue("@p4", mskdtxtTC.Text);
            command.Parameters.AddWithValue("@p5", txtsifre.Text);
            command.ExecuteNonQuery();
            bgl.connection().Close();
            MessageBox.Show("Doktor güncellendi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listele();


        }
    }
}
