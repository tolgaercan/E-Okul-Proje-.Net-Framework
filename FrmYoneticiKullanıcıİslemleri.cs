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
    public partial class FrmYoneticiKullanıcıİslemleri : Form
    {
        public FrmYoneticiKullanıcıİslemleri()
        {
            InitializeComponent();
        }
        SqlBaglantı bgl = new SqlBaglantı();
        private void FrmYoneticiKullanıcıİslemleri_Load(object sender, EventArgs e)
        {
            //Öğrenci_veli Bilgi
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select Ögrenciid,Ögrenciad_soyad,ÖgrenciTc,ÖgrenciVeliTc,ÖgrenciSifre,ÖgrenciVeliSifre from Tbl_Ögrenci_Veli", bgl.baglanti());
            da.Fill(dt);
            dtgrdvOgrenciBilgi.DataSource = dt;
            //Yönetici Bilgi
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("select id,YoneticiAd_Soyad,YoneticTc,YoneticiSifre from Tbl_Yonetici", bgl.baglanti());
            da1.Fill(dt1);
            dtgrdwYoneticiBılgi.DataSource = dt1;
        }

        private void dtgrdvOgrenciBilgi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Öğrenci_veli bİLGİ panelinde Herhangi bir hücreye tıklandığında
            int secilen = dtgrdvOgrenciBilgi.SelectedCells[0].RowIndex;
            txtOgrenciİd.Text = dtgrdvOgrenciBilgi.Rows[secilen].Cells[0].Value.ToString();
            txtAdSoyad.Text = dtgrdvOgrenciBilgi.Rows[secilen].Cells[1].Value.ToString();
            msktxtogrenciTc.Text = dtgrdvOgrenciBilgi.Rows[secilen].Cells[2].Value.ToString();
            msktxtvelitc.Text = dtgrdvOgrenciBilgi.Rows[secilen].Cells[3].Value.ToString();
            msktxtSifre.Text = dtgrdvOgrenciBilgi.Rows[secilen].Cells[4].Value.ToString();
            msktxtvelisifre.Text = dtgrdvOgrenciBilgi.Rows[secilen].Cells[5].Value.ToString();
          
        }

        private void dtgrdwYoneticiBılgi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Yönetici bİLGİ panelinde Herhangi bir hücreye tıklandığında
            int secilen = dtgrdwYoneticiBılgi.SelectedCells[0].RowIndex;
            TXTYoneticiid.Text = dtgrdwYoneticiBılgi.Rows[secilen].Cells[0].Value.ToString();
            txtYoneticiAdSoyad.Text = dtgrdwYoneticiBılgi.Rows[secilen].Cells[1].Value.ToString();
            msktxtYoneticiTC.Text = dtgrdwYoneticiBılgi.Rows[secilen].Cells[2].Value.ToString();
            msktxtyoneticisifre.Text = dtgrdwYoneticiBılgi.Rows[secilen].Cells[3].Value.ToString();
           
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dtgrdvOgrenciBilgi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void msktxtyoneticiadsoyad_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand komutekle = new SqlCommand("insert into Tbl_Ögrenci_Veli(ÖgrenciTc,Ögrenciad_soyad,ÖgrenciSifre,ÖgrenciVeliTc,ÖgrenciVeliSifre) values (@p1,@p2,@p3,@p4,@p5)", bgl.baglanti());
            komutekle.Parameters.AddWithValue("@p1", msktxtogrenciTc.Text);
            komutekle.Parameters.AddWithValue("@p2", txtAdSoyad.Text);
            komutekle.Parameters.AddWithValue("@p3", msktxtSifre.Text);
            komutekle.Parameters.AddWithValue("@p4",msktxtvelitc.Text);
            komutekle.Parameters.AddWithValue("@p5", msktxtvelisifre.Text);
            komutekle.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kayıt Oluşturuldu.");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlCommand komutgüncelle = new SqlCommand("update Tbl_Ögrenci_Veli set ÖgrenciTC=@p1,Ögrenciad_soyad=@p2,ÖgrenciSifre=@p3,ÖgrenciVeliTc=@p4,ÖgrenciVeliSifre=@p5 where Ögrenciİd=@p6", bgl.baglanti());
            komutgüncelle.Parameters.AddWithValue("@p1", msktxtogrenciTc.Text);
            komutgüncelle.Parameters.AddWithValue("@p2", txtAdSoyad.Text);
            komutgüncelle.Parameters.AddWithValue("@p3", msktxtSifre.Text);
            komutgüncelle.Parameters.AddWithValue("@p4", msktxtvelitc.Text);
            komutgüncelle.Parameters.AddWithValue("@p5", msktxtvelisifre.Text);
            komutgüncelle.Parameters.AddWithValue("@p6", txtOgrenciİd.Text);
            komutgüncelle.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kayıt Güncellendi.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("delete from Tbl_Ögrenci_Veli where Ögrenciİd=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtOgrenciİd.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kayıt Silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SqlCommand komutekle = new SqlCommand("insert into Tbl_Yonetici(YoneticiAd_Soyad,YoneticTc,YoneticiSifre) values (@p1,@p2,@p3)", bgl.baglanti());
            komutekle.Parameters.AddWithValue("@p1", txtYoneticiAdSoyad.Text);
            komutekle.Parameters.AddWithValue("@p2", msktxtYoneticiTC.Text);
            komutekle.Parameters.AddWithValue("@p3", msktxtyoneticisifre.Text);
            komutekle.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kayıt Oluşturuldu.");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SqlCommand komutgüncelle = new SqlCommand("update Tbl_Yonetici set YoneticiAd_Soyad=@p1,YoneticTc=@p2,YoneticiSifre=@p3 where id=@p4", bgl.baglanti());
            komutgüncelle.Parameters.AddWithValue("@p1", txtYoneticiAdSoyad.Text);
            komutgüncelle.Parameters.AddWithValue("@p2", msktxtYoneticiTC.Text);
            komutgüncelle.Parameters.AddWithValue("@p3", msktxtyoneticisifre.Text);
            komutgüncelle.Parameters.AddWithValue("@p4", TXTYoneticiid.Text);
            komutgüncelle.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kayıt Güncellendi.");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            SqlCommand komutsil = new SqlCommand("delete from Tbl_Yonetici where id=@p1", bgl.baglanti());
            komutsil.Parameters.AddWithValue("@p1",TXTYoneticiid.Text);
            komutsil.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kayıt Silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Öğrenci_veli Bilgi
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select Ögrenciid,Ögrenciad_soyad,ÖgrenciTc,ÖgrenciVeliTc,ÖgrenciSifre,ÖgrenciVeliSifre from Tbl_Ögrenci_Veli", bgl.baglanti());
            da.Fill(dt);
            dtgrdvOgrenciBilgi.DataSource = dt;
            //Yönetici Bilgi
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("select id,YoneticiAd_Soyad,YoneticTc,YoneticiSifre from Tbl_Yonetici", bgl.baglanti());
            da1.Fill(dt1);
            dtgrdwYoneticiBılgi.DataSource = dt1;
        }
    }
}
