using System.Windows.Forms;

namespace DecimalListBoxFormatting
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            BindData();
        }

        private void BindData()
        {
            listView1.View = View.Details;
            listView1.FullRowSelect = true;
            listView1.Columns.Add("Ondalıksız Para");
            listView1.Columns.Add("Ondalıksız Sayı");
            listView1.Columns.Add("2 Ondalıklı Sayı");

            for (int i = 0; i < 100; i++)
            {
                decimal deger = (decimal)i * 100000m / 9m;

                ListViewItem item = new ListViewItem(new[] {
                    string.Format("{0:c0}", deger),
                    string.Format("{0:n0}", deger),
                    string.Format("{0:n2}", deger)
                });

                listView1.Items.Add(item);
            }

            // Daha fazla format'lama kodları için şurayı ziyaret edebilirsiniz.
            // https://docs.microsoft.com/tr-tr/dotnet/standard/base-types/standard-numeric-format-strings?view=netframework-4.7.2
        }
    }
}
