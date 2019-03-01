using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace SettingsAndSerialize
{
    /// <summary>
    /// Settings ve Serialize ile ayarları saklama ve çağırma
    /// Volkan Karataş 01.03.2019 C# Dersleri grubu sorusu
    /// Author : Muzaffer Ali AKYIL 
    /// Email : muzaffer@akyil.net
    /// Web : https://muzaffer.akyil.net
    /// Date : 01.03.2019 19:26:00
    /// </summary>
    public partial class Form1 : Form
    {
        private IFormatter formatter = new BinaryFormatter();

        // Ayarlar.txt yazılabilir bir yerde olmalı. burada projenın exe sinin olduğu klasörde oluşturuyoruz.
        private readonly string ayarlarPath = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "Ayarlar.txt");

        public Form1()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (rbSettings.Checked)
            {
                // Settings
                // Settings ayarları Propertieste tanımlandı kontrol ediniz.
                Properties.Settings.Default.Tarih1 = dtpTarih1.Value;
                Properties.Settings.Default.Tarih2 = dtpTarih2.Value;
                Properties.Settings.Default.Kalan = txtKalan.Text;
                Properties.Settings.Default.Save();
            }
            else
            {
                // Serialize ile kaydetme
                Ayar ayar = new Ayar()
                {
                    Tarih1 = dtpTarih1.Value,
                    Tarih2 = dtpTarih2.Value,
                    Kalan = txtKalan.Text
                };

                using (Stream stream = new FileStream(ayarlarPath, FileMode.Create, FileAccess.Write))
                {
                    formatter.Serialize(stream, ayar);
                    stream.Close();
                }
            }
        }

        private void btnCagir_Click(object sender, EventArgs e)
        {
            if (rbSettings.Checked)
            {
                dtpTarih1.Value = Properties.Settings.Default.Tarih1;
                dtpTarih2.Value = Properties.Settings.Default.Tarih2;
                txtKalan.Text = Properties.Settings.Default.Kalan;
            }
            else
            {
                // Serialzie ile geri çekme
                if (!File.Exists(ayarlarPath))
                {
                    MessageBox.Show("Ayar dosyası bulunamadı. Lütfen önce kaydedin.");
                    return;
                }

                using (FileStream stream = new FileStream(ayarlarPath, FileMode.Open, FileAccess.Read))
                {
                    Ayar ayar = (Ayar)formatter.Deserialize(stream);
                    if (ayar == null) return;
                    dtpTarih1.Value = ayar.Tarih1;
                    dtpTarih2.Value = ayar.Tarih2;
                    txtKalan.Text = ayar.Kalan;
                }
            }

        }
    }
}
