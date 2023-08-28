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
    public partial class FrmOgrenciGirisPaneli : Form
    {
        public FrmOgrenciGirisPaneli()
        {
            InitializeComponent();
        }
        SqlBaglantı bgl = new SqlBaglantı();
        private void btnnot_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select OgrenciSınav1,OgrenciSınav2,OgrenciSozlü,OgrenciNotOrtalaması from Tbl_OgrenciBilgi where OgrenciTC=@p1", bgl.baglanti());
            da.SelectCommand.Parameters.AddWithValue("@p1", lblTC.Text);
            da.Fill(dt);
            DTGRDWLİSTE.DataSource = dt;

        }
        public string tc;
        private void FrmOgrenciGirisPaneli_Load(object sender, EventArgs e)
        {
            lblTC.Text = tc;
            SqlCommand komut = new SqlCommand("select Ögrenciad_soyad from Tbl_Ögrenci_Veli where ÖgrenciTc=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", lblTC.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lblAdSOYAD.Text = dr[0].ToString();
            }
            bgl.baglanti().Close();



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
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Tbl_SınavTakvimi", bgl.baglanti());
            da.Fill(dt);
            DTGRDWLİSTE.DataSource = dt;
        }
        public string tc1;
        private void button2_Click(object sender, EventArgs e)
        {
            FrmOgrenciBilgiGuncelle fr = new FrmOgrenciBilgiGuncelle();
            fr.tc1 = lblTC.Text; 
            fr.Show();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DTGRDWLİSTE_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmOyunlar fr = new FrmOyunlar();
            fr.Show();
        }
    }
}
