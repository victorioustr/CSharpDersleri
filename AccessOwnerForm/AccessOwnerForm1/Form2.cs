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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnGetir_Click(object sender, EventArgs e)
        {
            // Butona tıklandığında Form1 tipinde ownerForm adında bir nesne oluşturuyoruz ve bu nesneye formumuzun
            // Owner'ını (yani Form1'i) veriyoruz. Tabi Owner object tipli olduğundan as ile Form1 e cast ediyoruz.
            Form1 ownerForm = Owner as Form1;

            // Artık ownerForm nesnesi ile bulunduğumuz formu açan ve kendini bu formun owner'ı tanıtan Form1 formuna
            // erişebiliriz. ownerForm üzerindeki txtVeri textbox'ının Text'ini bu formdaki txtGelenVeri.Text'ine
            // atıyoruz. Burada dikkat edilmesi gereken şey Form1 deki txtVeri textbox'ının Modifiers özelliki Public olmalı.
            txtGelenVeri.Text = ownerForm.txtVeri.Text;
        }
    }
}
