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
    public partial class FrmVeliGirisPaneli : Form
    {
        public FrmVeliGirisPaneli()
        {
            InitializeComponent();
        }
        SqlBaglantı bgl = new SqlBaglantı();
        public string tc;
        private void btnnot_Click(object sender, EventArgs e)
        {
            lblTC.Text = tc;
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select OgrenciSınav1,OgrenciSınav2,OgrenciSozlü,OgrenciNotOrtalaması from Tbl_OgrenciBilgi where  OgrenciTC=@p1", bgl.baglanti());
            da.SelectCommand.Parameters.AddWithValue("@p1", tc);
            da.Fill(dt);
            DTGRDWLİSTE.DataSource = dt;
        }

        private void tndersprog_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select*from Tbl_DersProgramı", bgl.baglanti());
            da.Fill(dt);
            DTGRDWLİSTE.DataSource = dt;
        }

        private void btnsınavtakvim_Click(object sender, EventArgs e)
        {
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("SELECT * FROM Tbl_SınavTakvimi", bgl.baglanti());
            da1.Fill(dt1);
            DTGRDWLİSTE.DataSource = dt1;
        }
        public string tc1;
        private void button2_Click(object sender, EventArgs e)
        {
            FrmVeliBilgiGüncelleme fr = new FrmVeliBilgiGüncelleme();
            fr.tc1 = lblTC.Text;
            fr.Show();
        }

        private void FrmVeliGirisPaneli_Load(object sender, EventArgs e)
        {
            
            SqlCommand komut = new SqlCommand("select Ögrenciad_soyad,ÖgrenciTc from Tbl_Ögrenci_Veli where ÖgrenciVeliTc=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", tc);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lblAdSOYAD.Text = dr[0].ToString();
                lblTC.Text = dr[1].ToString();
            }
            bgl.baglanti().Close();

        }
    }
}
