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
    public partial class FrmVeliBilgiGüncelleme : Form
    {
        public FrmVeliBilgiGüncelleme()
        {
            InitializeComponent();
        }
        SqlBaglantı bgl = new SqlBaglantı();
        public string tc1;
        private void FrmVeliBilgiGüncelleme_Load(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select  Ögrenciid,Ögrenciad_soyad,ÖgrenciVeliTc,ÖgrenciVeliSifre from Tbl_Ögrenci_Veli where ÖgrenciTc=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", tc1);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                txtVeliİd.Text = dr[0].ToString();
                txtAdSoyad.Text = dr[1].ToString();
                msktxtVeliTc.Text = dr[2].ToString();
                msktxtSifre.Text = dr[3].ToString();
            }
            bgl.baglanti().Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlCommand komutgüncelle = new SqlCommand("update Tbl_Ögrenci_Veli set ÖgrenciVeliSifre=@p1 where Ögrenciid=@p2", bgl.baglanti());
            komutgüncelle.Parameters.AddWithValue("@p1", msktxtSifre.Text);
            komutgüncelle.Parameters.AddWithValue("@p2", txtVeliİd.Text);
           
            komutgüncelle.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kayıt Güncellendi.");
        }
    }
}
