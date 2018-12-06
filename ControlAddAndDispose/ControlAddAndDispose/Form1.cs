using System.Windows.Forms;

namespace ControlAddAndDispose
{
    public partial class Form1 : Form
    {
        private FlowLayoutPanel fl;
        public Form1()
        {
            InitializeComponent();
            InitControls();
        }

        private void InitControls()
        {
            fl = new FlowLayoutPanel
            {
                Left = 0,
                Top = 0,
                Height = Height - 100,
                Width = Width
            };

            Controls.Add(fl);

            Button btnEkle = new Button
            {
                Text = "Kontrolleri Ekle",
                Left = 10,
                Top = Height - 100,
                AutoSize = true
            };

            btnEkle.Click += BtnEkle_Click;

            Controls.Add(btnEkle);

            Button btnSil = new Button
            {
                Text = "Kontrolleri Sil",
                Left = btnEkle.Width + 20,
                Top = Height - 100,
                AutoSize = true
            };

            btnSil.Click += BtnSil_Click;

            Controls.Add(btnSil);
        }

        private void BtnEkle_Click(object sender, System.EventArgs e)
        {
            for (int i = 0; i < 30; i++)
            {
                TextBox ctl = new TextBox()
                {
                    Text = $"TextBox{i + 1}",
                    Name = $"TextBox{i + 1}"
                };

                fl.Controls.Add(ctl);
            }
        }

        private void BtnSil_Click(object sender, System.EventArgs e)
        {
            while (fl.Controls.Count > 0)
            {
                Control ctl = fl.Controls[0];
                fl.Controls.Remove(ctl);
                ctl.Dispose();
            }
            MessageBox.Show("Kontroller Dispose Edildi.");
        }
    }
}
