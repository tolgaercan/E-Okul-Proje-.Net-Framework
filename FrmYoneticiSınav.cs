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
    public partial class FrmYoneticiSınav : Form
    {
        public FrmYoneticiSınav()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox6_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
        SqlBaglantı bgl = new SqlBaglantı();
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void FrmYoneticiSınav_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select Ogrenciİd,OgrenciTC,OgrenciAdSoyad,OgrenciSınav1,OgrenciSınav2,OgrenciSozlü,OgrenciNotOrtalaması from Tbl_OgrenciBilgi", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand komutekle = new SqlCommand("insert into Tbl_OgrenciBilgi(OgrenciTC,OgrenciAdSoyad,OgrenciSınav1,OgrenciSınav2,OgrenciSozlü,OgrenciNotOrtalaması) values (@p1,@p2,@p3,@p4,@p5,@p6)", bgl.baglanti());
            komutekle.Parameters.AddWithValue("@p1", msktxtogrenciTc.Text);
            komutekle.Parameters.AddWithValue("@p2", txtAdSoyad.Text);
            komutekle.Parameters.AddWithValue("@p3", msktxtSınav1.Text);
            komutekle.Parameters.AddWithValue("@p4", msktxtSınav2.Text);
            komutekle.Parameters.AddWithValue("@p5", msktxtSözlü.Text);
            komutekle.Parameters.AddWithValue("@p6", txtortalama.Text);
            komutekle.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kayıt Oluşturuldu.");
        }
        decimal Notortalama()
        {
            decimal ortalama = 0; 
            if (int.TryParse(msktxtSınav1.Text, out int sınav1) &&
                int.TryParse(msktxtSınav2.Text, out int sınav2) &&
                int.TryParse(msktxtSözlü.Text, out int sozlu))
            {
                ortalama = (sınav1 * 0.3m) + (sınav2 * 0.5m) + (sozlu * 0.2m);
            }
            else
            {
                MessageBox.Show("Lütfen Uygun Bir Sayı Giriniz.");
            }

            return ortalama; 
        }

        private void button5_Click(object sender, EventArgs e)
        {
            decimal ortalamaSonuc = Notortalama(); 
            txtortalama.Text = ortalamaSonuc.ToString(); 
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtOgrenciİd.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            msktxtogrenciTc.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtAdSoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            msktxtSınav1.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            msktxtSınav2.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            msktxtSözlü.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            txtortalama.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();   
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select Ogrenciİd,OgrenciTC,OgrenciAdSoyad,OgrenciSınav1,OgrenciSınav2,OgrenciSozlü,OgrenciNotOrtalaması from Tbl_OgrenciBilgi", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button3_Click(object sender, EventArgs e)
        {

            SqlCommand komutgüncelle = new SqlCommand("update Tbl_OgrenciBilgi set OgrenciTC=@p1,OgrenciAdSoyad=@p2,OgrenciSınav1=@p3,OgrenciSınav2=@p4,OgrenciSozlü=@p5,OgrenciNotOrtalaması=@p6 where Ogrenciİd=@p7", bgl.baglanti());
            komutgüncelle.Parameters.AddWithValue("@p1", msktxtogrenciTc.Text);
            komutgüncelle.Parameters.AddWithValue("@p2", txtAdSoyad.Text);
            komutgüncelle.Parameters.AddWithValue("@p3", msktxtSınav1.Text);
            komutgüncelle.Parameters.AddWithValue("@p4", msktxtSınav2.Text);
            komutgüncelle.Parameters.AddWithValue("@p5", msktxtSözlü.Text);
            komutgüncelle.Parameters.AddWithValue("@p6", txtortalama.Text);
            komutgüncelle.Parameters.AddWithValue("@p7", txtOgrenciİd.Text);
            komutgüncelle.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kayıt Güncellendi.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("delete from Tbl_OgrenciBilgi where Ogrenciİd=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtOgrenciİd.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kayıt Silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
