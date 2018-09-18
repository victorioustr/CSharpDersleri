using System;
using System.Windows.Forms;

namespace AccessOwnerForm1
{
    /// <summary>
    /// Form'dan Form'a veri aktarımı - 1
    /// Author : Muzaffer Ali AKYIL 
    /// Email : muzaffer@akyil.net
    /// Web : https://muzaffer.akyil.net
    /// Date : 19.09.2018 00:40
    /// </summary>
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnForm2Ac_Click(object sender, EventArgs e)
        {
            // Formlar arası veri aktarma yöntemlerinden bu yöntemde yeni açılan forma önceki formu Owner
            // olarak atayıp yeni formdan önceki forma Owner nesnesi ile ulaşıyoruz.
            // Bu yöntemdeki tek kısıtlama ana formda erişilecek herşeyin modifiers'i Public olmalıdır.

            // Form2 formundan frm adında bir örnek alarak başlıyoruz.
            Form2 frm = new Form2();
            // frm formunu Show (yada ShowDialog) ile gösterirken Show/ShowDialog'a parametre olarak 
            // bulunduğumuz formu (this) veriyoruz. Bu parametre ile ilgili formun sahibinin hangi form
            // olduğunu söylemiş oluyoruz.
            // Alternatif olarak şu şekilde de verilebilir :
            // frm.Owner = this;
            // frm.Show();

            frm.Show(this);
        }
    }
}
