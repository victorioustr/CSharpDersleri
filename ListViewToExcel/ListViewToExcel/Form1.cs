using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace ListViewToExcel
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// ListView üzerindeki bilgileri html table taglarını kullanarak excel dosyası olarak kaydetmeye yarar.
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            InitListView();
        }

        private void InitListView()
        {
            listView1.View = View.Details;
            listView1.Columns.Add("Kolon 1");
            listView1.Columns.Add("Kolon 2");
            listView1.Columns.Add("Kolon 3");
            for (int i = 0; i < 10000; i++)
            {
                listView1.Items.Add(new ListViewItem(new string[] { $"a{i}", $"b{i}", $"c{i}" }));
            }
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog()
            {
                Filter = "Excel Dosyası|*.xls",
                OverwritePrompt = true,
                FileName = "deneme.xls"
            };

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string htmlTable = GetHtmlTable(listView1);
                    using (FileStream fs = new FileStream(sfd.FileName, FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite))
                    {
                        byte[] info = new UTF8Encoding(true).GetBytes(htmlTable);
                        fs.Write(info, 0, info.Length);
                        fs.Close();
                    }
                    MessageBox.Show("Başarı ile kaydedildi.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private string GetHtmlTable(ListView list)
        {
            string data = "<table><thead><tr>";

            foreach (ColumnHeader item in list.Columns)
            {
                data += $"<th>{item.Text}</th>";
            }

            data += "</tr></thead><tbody>";

            foreach (ListViewItem item in list.Items)
            {
                data += "<tr>";
                for (int i = 0; i < list.Columns.Count; i++)
                {
                    data += $"<td>{item.SubItems[i].Text}</td>";
                }
                data += "</tr>";
            }

            data += "</tbody></table>";

            return data;
        }
    }
}
