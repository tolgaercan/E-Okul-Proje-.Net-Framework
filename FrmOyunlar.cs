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
    public partial class FrmOyunlar : Form
    {
        public FrmOyunlar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmGüclühesap fr = new FrmGüclühesap();
            fr.Show();
        }

        private void btnnot_Click(object sender, EventArgs e)
        {
            FrmİngilizceOgren fr = new FrmİngilizceOgren();
            fr.Show();
        }
    }
}
