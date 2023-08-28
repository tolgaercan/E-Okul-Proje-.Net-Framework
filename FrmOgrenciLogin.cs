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
    public partial class FrmOgrenciLogin : Form
    {
        public FrmOgrenciLogin()
        {
            InitializeComponent();
        }
        SqlBaglantı bgl = new SqlBaglantı();
        public string tc;
        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select*from Tbl_Ögrenci_Veli where ÖgrenciTc=@p1 and ÖgrenciSifre=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", msktxtTc.Text);
            komut.Parameters.AddWithValue("@p2", txtSifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                FrmOgrenciGirisPaneli fr = new FrmOgrenciGirisPaneli();
                fr.tc = msktxtTc.Text;
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı TC&Şifre");
            }

            bgl.baglanti().Close();
        }

        private void msktxtTc_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtSifre_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
