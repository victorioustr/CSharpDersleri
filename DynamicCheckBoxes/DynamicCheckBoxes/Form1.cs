using System;
using System.Linq;
using System.Windows.Forms;

namespace DynamicCheckBoxes
{
    /// <summary>
    /// Dinamik CheckBox ekleme ve tek event ile kontrol etme
    /// Yunus Kurt 19.01.2019 C# Dersleri grubu sorusu
    /// Author : Muzaffer Ali AKYIL 
    /// Email : muzaffer@akyil.net
    /// Web : https://muzaffer.akyil.net
    /// Date : 19.01.2019 20:50
    /// </summary>
    public partial class Form1 : Form
    {
        private FlowLayoutPanel fl;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Init();
            InitCheckBoxes();
        }

        private void Init()
        {
            fl = new FlowLayoutPanel
            {
                Dock = DockStyle.Fill
            };
            Controls.Add(fl);
        }

        private void InitCheckBoxes()
        {
            for (int i = 0; i < 10; i++)
            {
                CheckBox chk = new CheckBox()
                {
                    Name = $"checkBox{i}",
                    Text = $"CheckBox No : {i}",
                    Width = 120,
                    Height = 80
                };
                chk.CheckedChanged += Chk_CheckedChanged;
                fl.Controls.Add(chk);
            }
        }

        private void Chk_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox chk = (CheckBox)sender;
            
            // Sadece checkleniyorsa devam edelim
            if (!chk.Checked) return;

            // Klasik Yöntem

            //foreach (Control item in fl.Controls)
            //{
            //    if(item.GetType() == typeof(CheckBox) && item != chk)
            //    {
            //        ((CheckBox)item).Checked = false;
            //    }
            //}


            // Linq Yöntemi

            //foreach (CheckBox item in fl.Controls.OfType<CheckBox>().Where(w => w.Name != chk.Name))
            //{
            //    item.Checked = false;
            //}


            // Kısaltılmış Linq Yöntemi

            fl.Controls.OfType<CheckBox>().Where(w => w != chk).ToList().ForEach(f => f.Checked = false);
        }
    }
}
