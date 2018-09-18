using System;
using System.Windows.Forms;

namespace AccessOwnerForm3
{
    /// <summary>
    /// Form'dan Form'a veri aktarımı - 3
    /// Author : Muzaffer Ali AKYIL 
    /// Email : muzaffer@akyil.net
    /// Web : https://muzaffer.akyil.net
    /// Date : 19.09.2018 02:00
    /// </summary>
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // Bu örnekte de formdan forma veriyi property ile taşıyoruz. Property tanımlamaları için Form2'ye bakın.

        private void btnVeri1Gonder_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2
            {
                Veri1 = "Veri1 verisi"
            };
            frm.Show();
        }

        private void btnVeri2Gonder_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2
            {
                Veri2 = "Veri2 verisi"
            };
            frm.Show();
        }

        private void btnVeri3Gonder_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2
            {
                Veri3 = "Veri3 verisi"
            };
            frm.Show();
        }
    }
}
