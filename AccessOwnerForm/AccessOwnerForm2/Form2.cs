using System.Windows.Forms;

namespace AccessOwnerForm2
{
    /// <summary>
    /// Form'dan Form'a veri aktarımı - 2
    /// Author : Muzaffer Ali AKYIL 
    /// Email : muzaffer@akyil.net
    /// Web : https://muzaffer.akyil.net
    /// Date : 19.09.2018 01:10
    /// </summary>
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        // Yeni eklediğimiz ikinci constructor
        public Form2(string gelenVeri)
        {
            InitializeComponent();
            lblGelenVeri.Text = gelenVeri;
        }
    }
}
