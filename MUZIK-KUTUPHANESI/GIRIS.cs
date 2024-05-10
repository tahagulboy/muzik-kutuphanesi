using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MUZIK_KUTUPHANESI
{
    public partial class GIRIS : Form
    {
        private const string connectionString = "Data Source=DESKTOP-2DF58T4;Initial Catalog=Muzik;Integrated Security=True";

        public GIRIS()
        {
            InitializeComponent();
        }

        private void GIRIS_Load(object sender, EventArgs e)
        {

        }

        private void btGirisYap_Click(object sender, EventArgs e)
        {
            string email = txtEMAIL.Text;
            string password = txtPASSWORD.Text;

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Lütfen e-posta ve şifreyi girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT KullaniciID FROM Kullanicilar WHERE Eposta = @Email AND Parola = @Password";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@Password", password);

                try
                {
                    connection.Open();
                    int userCount = (int)command.ExecuteScalar();
                    int loggedInUserID = -1;
                    string kullaniciAdi = "";
                    if (userCount > 0)
                    {
                        MessageBox.Show("Giriş başarılı.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        query = "SELECT KullaniciID FROM Kullanicilar WHERE Eposta = @Email AND Parola = @Password";
                        command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@Email", email);
                        command.Parameters.AddWithValue("@Password", password);
                        loggedInUserID = (int)command.ExecuteScalar();

                        query = "SELECT KullaniciAdi FROM Kullanicilar WHERE KullaniciID = @UserID";
                        command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@UserID", loggedInUserID);
                        kullaniciAdi = (string)command.ExecuteScalar();

                        SISTEM anaSayfa = new SISTEM();
                        anaSayfa.loggedInUserID = loggedInUserID;
                        anaSayfa.kullaniciAdi = kullaniciAdi;
                        anaSayfa.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Geçersiz e-posta veya şifre.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btKayitOl_Click(object sender, EventArgs e)
        {
            KAYIT kayit = new KAYIT();
            kayit.Show();
        }
    }
}