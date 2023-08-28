using System;
using System.Collections.Generic;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace E_Okul_Proje
{
    public partial class FrmİngilizceOgren : Form
    {
        public FrmİngilizceOgren()
        {
            InitializeComponent();
        }

        private void HayvanButon_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender; // Tıklanan butonu al
            string hayvanAdi = clickedButton.Name.Replace("BUTTON", ""); // Buton adından "Button" kelimesini çıkararak hayvan adını elde et
            //BÜYÜK KÜÇÜK HARFE DİKKAT ET.

            string resimYolu = @"C:\Users\user\source\repos\E-Okul Proje\PROJE GEREKLERİ\HAYVAN RESİMLER\" + hayvanAdi + ".jpg";
            string sesYolu = @"C:\Users\user\source\repos\E-Okul Proje\PROJE GEREKLERİ\HAYVANSESLER\" + hayvanAdi + ".wav";

            ShowAnimalInfo(resimYolu, sesYolu, hayvanAdi);
        }

        private void ShowAnimalInfo(string resimYolu, string sesYolu, string hayvanAdi)
        {
            pictureBox1.Image = Image.FromFile(resimYolu);
            SoundPlayer soundPlayer = new SoundPlayer(sesYolu);
            soundPlayer.Play();

            // Hayvanın Türkçe adını yaz
            label2.Text = GetTurkceAd(hayvanAdi);
        }

        private string GetTurkceAd(string hayvanAdi)
        {
            Dictionary<string, string> hayvanAdlari = new Dictionary<string, string>
    {
        {"CAT", "Kedi"},
        {"DOG", "Köpek"},
        {"LİON", "Aslan"},
         {"TİGER", "Kaplan"},
        {"COW", "İnek"},
        {"GOAT", "Keçi"},
         {"PİG", "Domuz"},
        {"GORİLLA", "Goril"},
        {"ELEPHANT", "Fil"},
    };

            return hayvanAdlari[hayvanAdi];


        }
    }
}


