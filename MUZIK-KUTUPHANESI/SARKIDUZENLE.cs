using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MUZIK_KUTUPHANESI
{
    public partial class SARKIDUZENLE : Form
    {
        private SqlConnection connection;
        public string SarkiAdi { get; set; }
        public string TurAdi { get; set; }
        public string AlbumAdi { get; set; }
        public DateTime Yil { get; set; }
        public string DosyaYolu { get; set; }

        public SARKIDUZENLE()
        {
            InitializeComponent();
            connection = new SqlConnection("Data Source = DESKTOP-2DF58T4;Initial Catalog = Muzik;Integrated Security = true;");
        }

        private void SARKIDUZENLE_Load(object sender, EventArgs e)
        {
            lbSarkiAdi.Text = SarkiAdi;
            cbTur.Text = TurAdi;
            cbAlbum.Text = AlbumAdi;
            dtYil.Value = Yil; 
            btDosyaYolu.Text = DosyaYolu;
            lbDosyaYolu.Text = DosyaYolu;
            LoadTurler();
            LoadAlbumler();
        }

        private void LoadTurler()
        {
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("SELECT TurAdi FROM Turler", connection);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cbTur.Items.Add(reader["TurAdi"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Türler yüklenirken hata oluştu: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void LoadAlbumler()
        {
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("SELECT AlbumAdi FROM Albumler", connection);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cbAlbum.Items.Add(reader["AlbumAdi"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Albümler yüklenirken hata oluştu: " + ex.Message);
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

        private void btDuzenle_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();

                string updateQuery = @"UPDATE s
                                SET s.TurAdi = @tur, 
                                    s.AlbumAdi = @album, 
                                    s.Yil = @yil, 
                                    s.DosyaYolu = @dosya
                                FROM Sarkilar s
                                INNER JOIN Turler t ON s.TurID = t.TurID
                                INNER JOIN Albumler a ON s.AlbumID = a.AlbumID
                                WHERE s.SarkiAdi = @sarkiadi";

                SqlCommand cmd = new SqlCommand(updateQuery, connection);

                cmd.Parameters.AddWithValue("@tur", cbTur.Text);
                cmd.Parameters.AddWithValue("@album", cbAlbum.Text);
                cmd.Parameters.AddWithValue("@yil", dtYil.Value);
                cmd.Parameters.AddWithValue("@dosya", lbDosyaYolu.Text);
                cmd.Parameters.AddWithValue("@sarkiadi", lbSarkiAdi.Text);

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Şarkı başarıyla güncellendi.");
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Şarkı güncellenirken bir hata oluştu.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Şarkı güncellenirken bir hata oluştu: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
