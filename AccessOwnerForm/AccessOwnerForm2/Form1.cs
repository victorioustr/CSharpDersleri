using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnForm2Ac_Click(object sender, EventArgs e)
        {
            // Formlar arası veri aktarmada bir başka yöntemde veriyi açılacak form'a constructor ile göndermektir.
            // Örnekte string kullandım siz burada herhangi bir object gönderebilirsiniz.
            // frm adında Form2 sınıfının örneğini alırken Form2'ye yazdığımız ikinci constructor sayesinde 
            // parametre olarak veri gönderebiliyoruz.
            Form2 frm = new Form2(txtVeri.Text);
            frm.Show();
        }
    }
}
