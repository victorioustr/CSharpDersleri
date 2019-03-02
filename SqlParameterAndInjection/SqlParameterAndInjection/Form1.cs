using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SqlParameterAndInjection
{
    /// <summary>
    /// SqlParameter kullanımı ve Sql Injection'la Mücadele
    /// Author : Muzaffer Ali AKYIL 
    /// Email : muzaffer@akyil.net
    /// Web : https://muzaffer.akyil.net
    /// Date : 02.03.2019 04:04
    /// </summary>
    public partial class Form1 : Form
    {
        private SqlConnection connection;

        public Form1()
        {
            InitializeComponent();
            btnBaglan.Tag = false;
        }

        private void btnBaglan_Click(object sender, EventArgs e)
        {
            // Burada button'un Tag özelliğine butonun durumunu ifade eden bir bool değer kullanıyoruz. Böylece button'un o anki durumunu öğrenebiliyoruz.
            if ((bool)btnBaglan.Tag)
            {
                if (connection.State != System.Data.ConnectionState.Closed)
                    connection.Close();
                btnBaglan.Text = "Bağlan";
                btnBaglan.Tag = false;
                return;
            }

            // Database var mı diye kontrol etmek için InitialCatalog vermeden yani master db ye bağlanıp ilgili Database var mı sorgusunu atıyoruz.
            SqlConnectionStringBuilder connectionStringBuilder = new SqlConnectionStringBuilder()
            {
                DataSource = txtDataSource.Text,
                UserID = txtUserId.Text,
                Password = txtPassword.Text
            };

            try
            {
                using (SqlConnection checkDbConnection = new SqlConnection(connectionStringBuilder.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand("SELECT db_id(@dbname)", checkDbConnection))
                    {
                        command.Parameters.AddWithValue("@dbname", txtInitialCatalog.Text);
                        checkDbConnection.Open();
                        if (command.ExecuteScalar() == DBNull.Value)
                        {
                            if (MessageBox.Show($"{txtInitialCatalog.Text} isimli veritabanı bulunamadı. Oluşturulsun mu ?", "Veritabanı Bulunamadı", MessageBoxButtons.YesNo) == DialogResult.No)
                                return;
                            // Database yok sa oluşturmak için sql cümlelerini çalıştıran methodu çağırıyoruz.
                            CreateDatabase(checkDbConnection);
                        }
                        // Database zaten var ya da yukarıda oluşturduğumuz için global olarak tanımladığımız connection nesnesini oluştururken InitialCatalog u db ismimiz ile değiştiriyoruz.
                        connectionStringBuilder.InitialCatalog = txtInitialCatalog.Text;
                        connection = new SqlConnection(connectionStringBuilder.ConnectionString);
                        connection.Open();
                    }
                    btnBaglan.Tag = true;
                    btnBaglan.Text = "Bağlantıyı Kes";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Varitabanına bağlanırken sorun yaşandı :\r\n{ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CreateDatabase(SqlConnection testConnection)
        {
            string sqlQuery = $@"CREATE DATABASE [{txtInitialCatalog.Text}];";
            string sqlTableQuery = $@"
USE [{txtInitialCatalog.Text}];
CREATE TABLE [dbo].[Users](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Username] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](50) NOT NULL,
	[Email] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY];
INSERT INTO Users (Username,Password,Email) VALUES ('Ahmet', '12345', 'a@admin.com');
INSERT INTO Users (Username,Password,Email) VALUES ('Mehmet', 'qwerty', 'b@admin.com');
INSERT INTO Users (Username,Password,Email) VALUES ('Zeynep', 'asdfgh', 'c@admin.com');
INSERT INTO Users (Username,Password,Email) VALUES ('Mahmut', 'zxcvbn', 'd@admin.com');
";

            using (SqlCommand command = new SqlCommand(sqlQuery, testConnection))
            {
                if (testConnection.State != System.Data.ConnectionState.Open)
                    testConnection.Open();
                command.ExecuteNonQuery();
            }
            using (SqlCommand command = new SqlCommand(sqlTableQuery, testConnection))
            {
                if (testConnection.State != System.Data.ConnectionState.Open)
                    testConnection.Open();
                command.ExecuteNonQuery();
            }
        }

        private void btnKontrolEt_Click(object sender, EventArgs e)
        {
            try
            {
                if (connection.State != System.Data.ConnectionState.Open)
                    connection.Open();
                if (rbStringFormat.Checked)
                {
                    // string.Format ya da normal klasik string birleştirme (+) yöntemi ile sorgumuzu hazırlıyoruz.
                    string query = string.Format("SELECT * FROM Users WHERE Username='{0}' AND Password='{1}'", txtUser.Text, txtPass.Text);

                    MessageBox.Show($"Sorulan sorgu şu şekildedir :\r\n{query}");

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader sqlDataReader = cmd.ExecuteReader())
                        {
                            if (sqlDataReader.Read())
                            {
                                MessageBox.Show($"Kayıt Bulundu\r\nId : {sqlDataReader["Id"]}\r\nUsername : {sqlDataReader["Username"]}\r\n{sqlDataReader["Password"]}\r\n{sqlDataReader["Email"]}");
                            }
                            else
                            {
                                MessageBox.Show("Herhangi bir kayıt bulunamadı");
                            }
                        }
                    }
                }
                else
                {
                    // SqlParameter kullanarak sorgumuzu hazırlıyoruz.
                    string query = "SELECT * FROM Users WHERE Username=@Username AND Password=@Password";
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        // Parametrelere değer atıyoruz.
                        cmd.Parameters.AddWithValue("@Username", txtUser.Text);
                        cmd.Parameters.AddWithValue("@Password", txtPass.Text);

                        using (SqlDataReader sqlDataReader = cmd.ExecuteReader())
                        {
                            if (sqlDataReader.Read())
                            {
                                MessageBox.Show($"Kayıt Bulundu\r\nId : {sqlDataReader["Id"]}\r\nUsername : {sqlDataReader["Username"]}\r\n{sqlDataReader["Password"]}\r\n{sqlDataReader["Email"]}");
                            }
                            else
                            {
                                MessageBox.Show("Herhangi bir kayıt bulunamadı");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata :\r\n{ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Global olarak tanımladığımız SqlConnection nesnemiz null değilse ve açıksa kapatıp dispose edip null a çekiyoruz ki açık kalıp kaynak tüketmesin. Yukarıdaki diğer SqlConnection, SqlCommand gibi unmanagement nesneler için using kullanmıştık. Using kullanımı ile ilgili github reposundaki UsingKullanimi projsine bakabilirsiniz.
            if (connection != null)
            {
                if (connection.State != System.Data.ConnectionState.Closed)
                    connection.Close();
                connection.Dispose();
            }
            connection = null;
        }
    }
}
}
