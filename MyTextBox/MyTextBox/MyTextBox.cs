using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace MyTextBoxDemo
{
    public class MyTextBox : TextBox
    {
        [Category("Ayarlar")]
        [DisplayName("Tümünü Seç")]
        [Description("Focus durumunda tüm metni seçer")]
        public bool TumunuSec { get; set; }

        [Category("Ayarlar")]
        [DisplayName("Enter Next Control")]
        [Description("Enter ile sıradaki kontrole geçer")]
        public bool EnterIleSiradakiKontroleGec { get; set; }

        [Category("Ayarlar")]
        [DisplayName("Hover Color")]
        [Description("Focus durumundaki arka plan rengi. Transparent bırakılırsa değiştirilmez.")]
        public Color HoverColor { get; set; } = Color.Transparent;

        [Category("Ayarlar")]
        [DisplayName(nameof(Zorunlu))]
        [Description("Boş geçilemez hatası. ErrorProvider tanımlanmalı")]
        public bool Zorunlu { get; set; }

        [Category("Ayarlar")]
        [DisplayName(nameof(ErrorProvider))]
        [Description("Zorunlu alanlar için ErrorProvider tanımlaması")]
        public ErrorProvider ErrorProvider { get; set; }

        [Category("Ayarlar")]
        [DisplayName("Doğrulandı")]
        [Description("Doğrulama durumu")]
        public bool Dogrulandi { get; private set; } = true;

        [Category("Ayarlar")]
        [DisplayName("Auto Trim")]
        [Description("Text özelliğine otomatik trim uygulanır")]
        public bool AutoTrim { get; set; }

        private Color _oldColor;

        public MyTextBox()
        {
            Enter += MyTextBox_Enter;
            Leave += MyTextBox_Leave;
            KeyDown += MyTextBox_KeyDown;
        }

        private void MyTextBox_Leave(object sender, EventArgs e)
        {
            ErrorProvider.Clear();
            Dogrulandi = true;
            if (HoverColor != Color.Transparent) BackColor = _oldColor;
            if (Zorunlu && ErrorProvider != null && (String.IsNullOrEmpty(Text) || String.IsNullOrWhiteSpace(Text)))
            {
                ErrorProvider.SetError(this, "Boş geçilemez!");
                Dogrulandi = false;
                Focus();
            }
        }

        private void MyTextBox_Enter(object sender, EventArgs e)
        {
            if (TumunuSec) SelectAll();
            if (HoverColor != Color.Transparent)
            {
                _oldColor = BackColor;
                BackColor = HoverColor;
            }
        }

        private void MyTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (EnterIleSiradakiKontroleGec && e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                Parent.SelectNextControl(this, true, true, true, true);
            }
        }

        public override string Text
        {
            get => AutoTrim ? base.Text.Trim() : base.Text;
            set => base.Text = value;
        }
    }
}
