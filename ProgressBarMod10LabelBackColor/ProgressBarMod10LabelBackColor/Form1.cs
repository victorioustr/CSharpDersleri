using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProgressBarMod10LabelBackColor
{
    public partial class Form1 : Form
    {
        private Timer tmr;
        public Form1()
        {
            InitializeComponent();
            InitTimer();
            InitProgress();
        }

        private void InitTimer()
        {
            tmr = new Timer
            {
                Interval = 1000,
            };
            tmr.Tick += Tmr_Tick;
        }

        private void InitProgress()
        {
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
        }

        private void Tmr_Tick(object sender, EventArgs e)
        {
            Invoke(new MethodInvoker(delegate
            {
                if (progressBar1.Value + 5 > progressBar1.Maximum)
                {
                    button1.PerformClick();
                    return;
                }
                progressBar1.Value += 5;
                label1.Text = progressBar1.Value.ToString();
                label1.BackColor = progressBar1.Value % 10 == 0 ? Color.Red : Color.White;
                label2.Text = $"Mod : {progressBar1.Value % 10}";
            }));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tmr.Enabled)
            {
                tmr.Stop();
                progressBar1.Value = 0;
                label1.Text = "0";
                label1.BackColor = Color.Transparent;
                button1.Text = "Başlat";
            }
            else
            {
                tmr.Start();
                button1.Text = "Durdur";
            }
        }
    }
}
