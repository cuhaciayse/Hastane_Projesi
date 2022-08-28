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
    public partial class FrmDoktorDetay : Form
    {
        public FrmDoktorDetay()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        public string TC;
       

        private void FrmDoktorDetay_Load(object sender, EventArgs e)
        {
            labelTC.Text = TC;

            // Doktor ad soyad çekme
            SqlCommand command = new SqlCommand("select DoktorAd,DoktorSoyad from Tbl_Doktorlar where DoktorTC=@p1 ", bgl.connection());
            command.Parameters.AddWithValue("@p1", labelTC.Text);
            command.Parameters.AddWithValue("@p2", labeladsoyad.Text);
            SqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                labeladsoyad.Text = dr[0] + "" + dr[1];
            }
            bgl.connection().Close();

            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("select * from Tbl_Randevular where RandevuDoktor='" + labeladsoyad.Text + "'", bgl.connection());
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            bgl.connection().Close();
        }

        private void btnbilgiduzenle_Click(object sender, EventArgs e)
        {
            DoktorBilgiDuzenle frm = new DoktorBilgiDuzenle();
            frm.TCNO =labelTC.Text;
            frm.Show();
            this.Hide();
        }

        private void btnduyurular_Click(object sender, EventArgs e)
        {
            FrmDuyurular frm = new FrmDuyurular();
            frm.Show();
        }

        private void btncikis_Click(object sender, EventArgs e)
        {
            Application.Exit(); //Programı kapattım
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            rchSikayet.Text=dataGridView1.Rows[secilen].Cells[7].Value.ToString();

        }
    }
}
