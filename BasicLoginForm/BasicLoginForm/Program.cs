using System;
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
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Application başlamadan önce Login formumuzu çağırıp kullanıcı kontrolü yapıyoruz. 
            // Application'ı frmLogin ile başlatsaydık uygulama boyunca frmLogin'i Hide ile gizlemek zorunda kalacaktık.

            // Kod okunabilirliği için her iş parçasını methodlara bölmek iyi bir alışkanlıktır.
            KullaniciKontrolu();

            Application.Run(new frmMain());
        }

        private static void KullaniciKontrolu()
        {
            // IDisposable olan tüm sınıfları using ile kullanmak using bloğu sonunda (yani işimiz bittiğinde) Dispose edilerek hafızadan silinmesini sağlar.
            // using içinde frmLogin sınıfından frm adında bir nesne oluşturuyoruz.
            using (frmLogin frm = new frmLogin())
            {
                // frm nesnesini ShowDialog ile modal bir şekilde ekrana getiriyoruz. ShowDialog dediğimiz için frm Close edilene kadar burada kod bekleyecektir.
                // frm kapatıldıktan sonra oradan gönderdiğimiz DialogResult'ı bir değişkene atıyoruz.
                DialogResult dialogResult = frm.ShowDialog();
                // Dönen DialogResult OK değilse programı sonlandırıyoruz.
                if (dialogResult != DialogResult.OK)
                {
                    // Application.Exit() burada çalışmayacaktır. Çünkü daha Application çalıştırılmadı.
                    Environment.Exit(0);
                }

                // Yukarıdaki kontrolde DialogResult OK ise bu method sorunsuz bir şekilde işini bitirip sonlanacak. 
                // Main methodundaki sıradaki satır çalıştırılıp frmMain ile Application çalışacaktır.
            }
        }
    }
}
