using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Okul_Proje
{
    public partial class FrmAnaGirisPaneli : Form
    {
        public FrmAnaGirisPaneli()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmOgrenciLogin fr = new FrmOgrenciLogin();
            fr.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmVeliLogin fr = new FrmVeliLogin();
            fr.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmYoneticiLogin fr = new FrmYoneticiLogin();
            fr.Show();
        }

        private void FrmAnaGirisPaneli_Load(object sender, EventArgs e)
        {

        }
    }
}
