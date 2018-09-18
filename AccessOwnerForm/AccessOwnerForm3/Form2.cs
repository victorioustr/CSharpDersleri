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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            Shown += Form2_Shown;
            // Buradaki 3 örnekten ilkinde verinin taşınmadığını göreceksiniz. Aslında taşınmakta fakat Label'a yazıldığı
            // yer contructor olduğundan daha property'e veri giremeden null olarak label text'ine atanmaktadır.
            lblGelenVeri1.Text = Veri1;
        }

        // Property tanımlamaları (kısayol olarak prop yazıp çift tab basabilirsiniz.)
        public string Veri1 { get; set; }

        public string Veri2 { get; set; }

        private void Form2_Shown(object sender, System.EventArgs e)
        {
            // Bu örnekte 1. örnekte yaşadığımız sorunu yaşamamak için Form'un Shown (ekrana gelme) eventinde
            // Veri2 property'sine atadığımız veriyi Label'ın text'ine yazıyoruz.
            lblGelenVeri2.Text = Veri2;
        }

        public string Veri3
        {
            // Bu örnekte de Veri3 diye tanımladığımız ve sadece setter'ı (veri atama) bulunan property'e 
            // veri atandığı gibi Label'ın Text'ine veriyi gönderiyoruz. Diğer örneklerden farklı olarak bu 
            // property her set edildiğinde label'ı güncelleyecektir.
            set => lblGelenVeri3.Text = value;
        }
    }
}
