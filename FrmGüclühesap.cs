using System;
using System.Threading;
using System.Windows.Forms;

namespace E_Okul_Proje
{
    public partial class FrmGüclühesap : Form
    {
        private int totalQuestions = 0;
        private int correctAnswers = 0;
        private int totalScore = 0;

        private Random random = new Random();

        public FrmGüclühesap()
        {
            InitializeComponent();
        }

        private void FrmGüclühesap_Load(object sender, EventArgs e)
        {
        }

        private void btncevapgonder_Click(object sender, EventArgs e)
        {
           
        }

        private void btnsonrakisoru_Click(object sender, EventArgs e)
        {

            int userAnswer;

            if (int.TryParse(txtcevap.Text, out userAnswer))
            {
                int number1 = int.Parse(lblsoru.Text.Split(' ')[2]); // İkinci bölümü alıyoruz (0 tabanlı indeksleme)
                int number2 = int.Parse(lblsoru.Text.Split(' ')[4]); // Dördüncü bölümü alıyoruz (0 tabanlı indeksleme)
                int correctAnswer = number1 * number2;
                if (userAnswer == correctAnswer)
                {
                    pcbxcorrect1.Visible = true;
                    pcbxcorrect2.Visible = true;
                    correctAnswers++;
                    totalScore += 20;
                }
                else
                {
                    pcbxwrong1.Visible = true;
                    pcbxwrong2.Visible = true;
                    totalScore -= 10;
                }

                totalQuestions++;
                lblpuan.Text = $"Toplam Puan: {totalScore}";

                // Bir sonraki soruyu başlat
                Thread nextQuestionThread = new Thread(() =>
                {
                    Thread.Sleep(1000);
                    this.Invoke(new Action(StartNewQuestion)); // Doğru fonksiyon adını kullanın

                });

                nextQuestionThread.Start();
            }
            else
            {
                MessageBox.Show("Geçersiz cevap girişi. Lütfen bir sayı girin.");
            }
            txtcevap.Clear();
            
        }

        private void StartNewQuestion()
        {
            if (totalQuestions < 5)
            {
                int number1 = random.Next(1, 11);
                int number2 = random.Next(1, 11);
                int correctAnswer = number1 * number2;

                lblsoru.Text = $"Soru {totalQuestions + 1}: {number1} x {number2} kaçtır?";
                pcbxcorrect1.Visible = false;
                pcbxcorrect2.Visible = false;
                pcbxwrong1.Visible = false;
                pcbxwrong2.Visible = false;




                // PictureBox'ların belirttiğiniz hızda yanıp sönmesini sağlayan thread.
                Thread blinkThread = new Thread(() =>
                {
                    Thread.Sleep(1000);
                    pcbxsoru1.Invoke(new Action(() => pcbxsoru1.Visible = true));
                    Thread.Sleep(1000);
                    pcbxsoru1.Invoke(new Action(() => pcbxsoru1.Visible = false));
                    Thread.Sleep(1000);
                    pcbxsoru1.Invoke(new Action(() => pcbxsoru1.Visible = true));
                    Thread.Sleep(1000);
                    pcbxsoru1.Invoke(new Action(() => pcbxsoru1.Visible = false));
                });

                blinkThread.Start();
            }
            else
            {
                MessageBox.Show($"Oyun bitti! Toplam puan: {totalScore}");
            }
        }

        private void btnbasla_Click(object sender, EventArgs e)
        {
            totalQuestions = 0;
            correctAnswers = 0;
            totalScore = 0;
            lblpuan.Text = totalScore.ToString();
            StartNewQuestion();
        }
    }
}
