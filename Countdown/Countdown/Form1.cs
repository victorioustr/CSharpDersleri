using System;
using System.Drawing;
using System.Windows.Forms;

namespace Countdown
{
    /// <summary>
    /// Geri Sayım Örneği
    /// Author : Muzaffer Ali AKYIL 
    /// Email : muzaffer@akyil.net
    /// Web : https://muzaffer.akyil.net
    /// Date : 23.06.2019 01:40
    /// </summary>
    public partial class Form1 : Form
    {

        Timer countdownTimer;
        DateTime startDate;
        DateTime endDate;

        public Form1()
        {
            InitializeComponent();
            lblKalanSure.Text = string.Empty;
            lblKalanSure.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold);
            lblKalanSure.TextAlign = ContentAlignment.MiddleCenter;
            btnStop.Enabled = false;
            this.AcceptButton = btnStart;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Geri Sayım Örneği";
            this.FormClosing += Form1_FormClosing;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (countdownTimer != null && countdownTimer.Enabled)
            {
                if (MessageBox.Show("Geri sayım devam ediyor çıkmak istediğinize emin misiniz ?", "Çıkış Onayı", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    e.Cancel = true;
                }
                else
                {
                    countdownTimer.Stop();
                    countdownTimer.Dispose();
                }
            } else
            {
                countdownTimer.Dispose();
            }
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtGeriSayimSuresi.Text, out int geriSayilacakSure) || geriSayilacakSure == 0)
            {
                MessageBox.Show("Lütfen sayı giriniz");
                return;
            }

            countdownTimer = new Timer()
            {
                Interval = 100
            };
            countdownTimer.Tick += CountdownTimer_Tick;

            startDate = DateTime.UtcNow;
            endDate = startDate.AddMinutes(geriSayilacakSure);
            btnStart.Enabled = false;
            btnStop.Enabled = true;
            countdownTimer.Start();
        }

        private void BtnStop_Click(object sender, EventArgs e)
        {
            lblKalanSure.Text = "İşlem İptal Edildi";
            countdownTimer.Stop();
            btnStart.Enabled = true;
            btnStop.Enabled = false;
        }

        private void CountdownTimer_Tick(object sender, EventArgs e)
        {
            TimeSpan fark = endDate - DateTime.UtcNow;
            if ((int)fark.TotalSeconds > 0)
            {
                lblKalanSure.Text = $"{fark.Minutes} dk. {fark.Seconds} sn.";
            }
            else
            {
                lblKalanSure.Text = "Süre Tamamlandı";
                countdownTimer.Stop();
                btnStart.Enabled = true;
                btnStop.Enabled = false;
            }
        }
    }
}
