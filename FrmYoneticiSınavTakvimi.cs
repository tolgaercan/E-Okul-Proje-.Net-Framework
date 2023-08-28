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

namespace E_Okul_Proje
{
    public partial class FrmYoneticiSınavTakvimi : Form
    {
        public FrmYoneticiSınavTakvimi()
        {
            InitializeComponent();
        }
        SqlBaglantı bgl = new SqlBaglantı();
        private void FrmYoneticiSınavTakvimi_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Tbl_SınavTakvimi", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtdersad.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            msktxtsınavtarih.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            msktxtsınavsaat.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand komutekle = new SqlCommand("insert into Tbl_SınavTakvimi(SINAV_ADI,SINAV_TARİHİ,SINAV_SAATİ) values (@p1,@p2,@p3)",bgl.baglanti());
            komutekle.Parameters.AddWithValue("@p1", txtdersad.Text);
            komutekle.Parameters.AddWithValue("@p2", msktxtsınavtarih.Text);
            komutekle.Parameters.AddWithValue("@p3", msktxtsınavsaat.Text);
            komutekle.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kayıt Oluşturuldu.");


        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("delete from Tbl_SınavTakvimi where sınavid=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtid.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kayıt Silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlCommand komutgüncelle = new SqlCommand("update Tbl_SınavTakvimi set SINAV_ADI=@p1,SINAV_TARİHİ=@p2,SINAV_SAATİ=@p3 where sınavid=@p4", bgl.baglanti());
            komutgüncelle.Parameters.AddWithValue("@p1", txtdersad.Text);
            komutgüncelle.Parameters.AddWithValue("@p2", msktxtsınavtarih.Text);
            komutgüncelle.Parameters.AddWithValue("@p3", msktxtsınavsaat.Text);
            komutgüncelle.Parameters.AddWithValue("@p4", txtid.Text);
            komutgüncelle.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kayıt Güncellendi.");

        }

        private void button4_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Tbl_SınavTakvimi", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
