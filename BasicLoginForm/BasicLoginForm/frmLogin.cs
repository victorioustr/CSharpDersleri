using System.Windows.Forms;

namespace BasicLoginForm
{
    /// <summary>
    /// Basit Login Form Uygulaması
    /// Author : Muzaffer Ali AKYIL 
    /// Email : muzaffer@akyil.net
    /// Web : https://muzaffer.akyil.net
    /// Date : 18.09.2018 21:40
    /// </summary>
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            ControlBox = false;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Kullanıcı Girişi";
            txtPassword.PasswordChar = '*';

            // Varsayılan butonu btnLogin yapıyoruz. Enter'a basıldığında bu butona basılmış sayılacak.
            AcceptButton = btnLogin;
            // Cancel butonunu btnCancel yapıyoruz. ESC'ye basıldığında bu butona basılmış sayılacak. 
            CancelButton = btnCancel;

            btnLogin.Click += BtnLogin_Click;
        }

        private void BtnLogin_Click(object sender, System.EventArgs e)
        {
            // Kullanıcı bilgilerini kontrol etmek için kullanacağınız kodları aşağıdaki örneğe göre düzenleyiniz.
            if (txtUsername.Text != "kullanici" && txtPassword.Text != "sifre")
            {
                // Bilgiler uyuşmuyorsa hata mesajı verip methodtan çıkıyoruz.
                MessageBox.Show("Girmiş olduğunuz kullanıcı adı yada şifre hatalı.\r\nLütfen tekrar deneyiniz.", "Hata");
                return;
            }

            // Bilgiler uyuşuyorsa Formun DialogResult ını OK yapıp formu kapatıyoruz.
            DialogResult = DialogResult.OK;
        }
    }
}
