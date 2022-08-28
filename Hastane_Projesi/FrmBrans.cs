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
    public partial class FrmBrans : Form
    {
        public FrmBrans()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void FrmBrans_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("select * from Tbl_Branslar", bgl.connection());
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        void Listele()
        {
            SqlCommand command = new SqlCommand("select * from Tbl_Branslar", bgl.connection());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("insert into Tbl_Branslar (Bransid,BransAd) values (@p1, @p2)", bgl.connection());
            command.Parameters.AddWithValue("@p1", txtid.Text);
            command.Parameters.AddWithValue("@p2",txtad.Text);  
            command.ExecuteNonQuery();
            bgl.connection().Close();
            MessageBox.Show("Branş eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listele();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtad.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("delete from Tbl_Branslar where Bransid=@p1", bgl.connection());
            command.Parameters.AddWithValue("@p1", txtid.Text);
            command.Parameters.AddWithValue("@p2", txtad.Text);
            command.ExecuteNonQuery();
            bgl.connection();Close();
            MessageBox.Show("Branş silindi");
            Listele();
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("update Tbl_Branslar set BransAd=@p1 where Bransid=@p2", bgl.connection());
            command.Parameters.AddWithValue("@p1", txtad.Text);
            command.Parameters.AddWithValue("@p2", txtid.Text);
            command.ExecuteNonQuery();
            bgl.connection().Close();
            MessageBox.Show("Branş güncellendi");
            Listele();
        }
    }
}
