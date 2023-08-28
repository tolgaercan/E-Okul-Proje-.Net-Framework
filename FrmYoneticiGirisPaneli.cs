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
    public partial class FrmYoneticiGirisPaneli : Form
    {
        public FrmYoneticiGirisPaneli()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmYoneticiDersprogramı fr = new FrmYoneticiDersprogramı();
            fr.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmYoneticiSınav fr = new FrmYoneticiSınav();
            fr.Show();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmYoneticiSınavTakvimi fr = new FrmYoneticiSınavTakvimi();
            fr.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmYoneticiKullanıcıİslemleri fr = new FrmYoneticiKullanıcıİslemleri();
            fr.Show();
        }
        public string tc;
        SqlBaglantı bgl = new SqlBaglantı();

        private void FrmYoneticiGirisPaneli_Load(object sender, EventArgs e)
        {
            lblTC.Text = tc;
            SqlCommand komut = new SqlCommand("select YoneticiAd_Soyad from Tbl_Yonetici where YoneticTc=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", tc);
            SqlDataReader dr = komut.ExecuteReader();

            if (dr.Read())
            {
                lblAdSOYAD.Text = dr["YoneticiAd_Soyad"].ToString();
            }

            dr.Close(); 
            bgl.baglanti().Close();




        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
