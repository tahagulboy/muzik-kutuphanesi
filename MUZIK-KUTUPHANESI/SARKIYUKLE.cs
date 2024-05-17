using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MUZIK_KUTUPHANESI
{
    public partial class SARKIYUKLE : Form
    {
        public int loggedInUserID { get; set; }
        private string dosyaYolu;

        private SqlConnection connection;

        public SARKIYUKLE()
        {
            InitializeComponent();
            connection = new SqlConnection("Data Source = DESKTOP-2DF58T4;Initial Catalog = Muzik;Integrated Security = true;");
        }

        private void SARKIYUKLE_Load(object sender, EventArgs e)
        {
            try
            {
                connection.Open();

                string sqlQuery = "SELECT AlbumID, AlbumAdi FROM Albumler";
                SqlCommand sqlCommand = new SqlCommand(sqlQuery, connection);
                SqlDataReader reader = sqlCommand.ExecuteReader();

                DataTable dataTableAlbumler = new DataTable();
                dataTableAlbumler.Columns.Add("AlbumID", typeof(int));
                dataTableAlbumler.Columns.Add("AlbumAdi", typeof(string));
                dataTableAlbumler.Load(reader);

                cbAlbum.DataSource = dataTableAlbumler;
                cbAlbum.DisplayMember = "AlbumAdi";
                cbAlbum.ValueMember = "AlbumID";

                sqlQuery = "SELECT TurID, TurAdi FROM Turler";
                sqlCommand = new SqlCommand(sqlQuery, connection);
                reader = sqlCommand.ExecuteReader();

                DataTable dataTableTurler = new DataTable();
                dataTableTurler.Columns.Add("TurID", typeof(int));
                dataTableTurler.Columns.Add("TurAdi", typeof(string));
                dataTableTurler.Load(reader);

                cbTur.DataSource = dataTableTurler;
                cbTur.DisplayMember = "TurAdi";
                cbTur.ValueMember = "TurID";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veritabanından kategoriler alınırken bir hata oluştu: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void btDosyaYolu_Click(object sender, EventArgs e)
        {
            OpenFileDialog dosyaSecDialog = new OpenFileDialog();

            dosyaSecDialog.Filter = "Müzik Dosyaları (*.mp3)|*.mp3|Tüm Dosyalar (*.*)|*.*";

            dosyaSecDialog.Multiselect = false;

            DialogResult result = dosyaSecDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                string dosyaYolu = dosyaSecDialog.FileName;
                lbDosyaYolu.Text = dosyaYolu;
            }
        }

        private void btYukle_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();

                if (cbTur.SelectedValue != null)
                {
                    string sqlQuery = "INSERT INTO Sarkilar (SarkiAdi, KullaniciID, DosyaYolu, TurID, AlbumID, Yil) VALUES (@sarkiAdi, @kullaniciID, @dosyaYolu, @turID, @albumID, @yil)";
                    SqlCommand sqlCommand = new SqlCommand(sqlQuery, connection);
                    sqlCommand.Parameters.AddWithValue("@sarkiAdi", lbSarkiAdi.Text);
                    sqlCommand.Parameters.AddWithValue("@kullaniciID", loggedInUserID); 
                    sqlCommand.Parameters.AddWithValue("@dosyaYolu", lbDosyaYolu.Text);
                    sqlCommand.Parameters.AddWithValue("@turID", cbTur.SelectedValue);
                    sqlCommand.Parameters.AddWithValue("@albumID", cbAlbum.SelectedValue);
                    sqlCommand.Parameters.AddWithValue("@yil", dtYil.Value.Year);

                    sqlCommand.ExecuteNonQuery();

                    MessageBox.Show("İşlem başarıyla tamamlandı!");
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Lütfen geçerli bir tedarikçi seçin.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veritabanı bağlantısında hata oluştu: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
