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
    public partial class FrmVeliLogin : Form
    {
        public FrmVeliLogin()
        {
            InitializeComponent();
        }
        SqlBaglantı bgl = new SqlBaglantı();
        public string tc;
        private void button1_Click(object sender, EventArgs e)
        {

            SqlCommand komut = new SqlCommand("SELECT *FROM Tbl_Ögrenci_Veli WHERE ÖgrenciVeliTc=@p1 AND ÖgrenciVeliSifre=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", msktxtTc.Text);
            komut.Parameters.AddWithValue("@p2", txtSifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                FrmVeliGirisPaneli fr = new FrmVeliGirisPaneli();
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
    }
}
