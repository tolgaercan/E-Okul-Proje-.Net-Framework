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
    public partial class FrmOgrenciBilgiGuncelle : Form
    {
        public FrmOgrenciBilgiGuncelle()
        {
            InitializeComponent();
        }
        SqlBaglantı bgl = new SqlBaglantı();
        public string tc1;
        private void FrmOgrenciBilgiGuncelle_Load(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select  Ögrenciid,Ögrenciad_soyad,ÖgrenciTc,ÖgrenciSifre from Tbl_Ögrenci_Veli where ÖgrenciTc=@p1",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",tc1);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                txtOgrenciİd.Text = dr[0].ToString();
                txtAdSoyad.Text = dr[1].ToString();
                msktxtogrenciTc.Text = dr[2].ToString();
                msktxtSifre.Text = dr[3].ToString();
            }
            bgl.baglanti().Close();

        }

      

        private void button3_Click(object sender, EventArgs e)
        {
            SqlCommand komutgüncelle = new SqlCommand("update Tbl_Ögrenci_Veli set Ögrenciad_soyad=@p1,ÖgrenciTc=@p2,ÖgrenciSifre=@p3 where Ögrenciid=@p4", bgl.baglanti());
            komutgüncelle.Parameters.AddWithValue("@p1", txtAdSoyad.Text);
            komutgüncelle.Parameters.AddWithValue("@p2", msktxtogrenciTc.Text);
            komutgüncelle.Parameters.AddWithValue("@p3", msktxtSifre.Text);
            komutgüncelle.Parameters.AddWithValue("@p4", txtOgrenciİd.Text);
            komutgüncelle.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kayıt Güncellendi.");
        }
    }
}
