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
    public partial class SISTEM : Form
    {
        private SqlConnection connection;
        private DataTable dataTable;
        private SqlDataAdapter adapter;

        public int loggedInUserID { get; set; }
        public string kullaniciAdi { get; set; }


        public SISTEM()
        {
            InitializeComponent();
            connection = new SqlConnection("Data Source = DESKTOP-2DF58T4;Initial Catalog = Muzik;Integrated Security = true;");
        }

        private void SISTEM_Load(object sender, EventArgs e)
        {
            GetData();
            ResizeDataGridView();
            lbKullaniciAdi.Text = "Merhaba, " + kullaniciAdi + "!";

        }

        private void ResizeDataGridView()
        {
            dtSarkiListesi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtSarkiListesi.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void GetData()
        {
            string query = @"
                SELECT 
                    s.SarkiAdi, 
                    k.KullaniciAdi, 
                    t.TurAdi, 
                    a.AlbumAdi, 
                    s.Yil
                FROM 
                    Sarkilar s
                JOIN 
                    Kullanicilar k ON s.KullaniciID = k.KullaniciID
                JOIN 
                    Turler t ON s.TurID = t.TurID
                JOIN 
                    Albumler a ON s.AlbumID = a.AlbumID;";
            adapter = new SqlDataAdapter(query, connection);
            dataTable = new DataTable();
            adapter.Fill(dataTable);
            dtSarkiListesi.DataSource = dataTable;
        }

        private void btAra_Click(object sender, EventArgs e)
        {
            string searchText = aramaKutusu.Text.ToLower();
            if (!string.IsNullOrWhiteSpace(searchText))
            {
                DataView dv = new DataView(dataTable);
                dv.RowFilter = string.Format("SarkiAdi LIKE '%{0}%'", searchText);
                dtSarkiListesi.DataSource = dv;
            }
            else
            {
                dtSarkiListesi.DataSource = dataTable;
            }
        }

        private void btTurEkle_Click(object sender, EventArgs e)
        {
            TUREKLE turEkle = new TUREKLE();
            turEkle.Show();

        }

        private void btAlbumEkle_Click(object sender, EventArgs e)
        {
            ALBUMEKLE albumEkle = new ALBUMEKLE();
            albumEkle.Show();
        }

        private void btSarkiYukle_Click(object sender, EventArgs e)
        {
            SARKIYUKLE sarkiEkle = new SARKIYUKLE();
            sarkiEkle.loggedInUserID = loggedInUserID;
            sarkiEkle.Show();
        }

        private void musicPlayer_Enter(object sender, EventArgs e)
        {
            if (dtSarkiListesi.SelectedRows.Count > 0)
            {
                string dosyaYolu = dtSarkiListesi.SelectedRows[0].Cells["DosyaYolu"].Value.ToString();

                musicPlayer.URL = dosyaYolu;
                musicPlayer.Ctlcontrols.play();
            }
            else
            {
                MessageBox.Show("Lütfen bir öğe seçin.");
            }
        }

        private void btDuzenle_Click(object sender, EventArgs e)
        {
            if (dtSarkiListesi.SelectedRows.Count > 0)
            {
                string selectedKullaniciAdi = dtSarkiListesi.SelectedRows[0].Cells["KullaniciAdi"].Value.ToString();
                string selectedSarkiAdi = dtSarkiListesi.SelectedRows[0].Cells["SarkiAdi"].Value.ToString();

                if (selectedKullaniciAdi == kullaniciAdi)
                {
                    string dosyaYolu = null;
                    string query = "SELECT DosyaYolu FROM Sarkilar WHERE SarkiAdi = @SarkiAdi";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@SarkiAdi", selectedSarkiAdi);
                        connection.Open();
                        object result = command.ExecuteScalar();
                        connection.Close();

                        if (result != null)
                        {
                            dosyaYolu = result.ToString();
                        }
                    }

                    if (!string.IsNullOrEmpty(dosyaYolu))
                    {
                        SARKIDUZENLE sarkiDuzenle = new SARKIDUZENLE();

                        sarkiDuzenle.SarkiAdi = selectedSarkiAdi;
                        sarkiDuzenle.TurAdi = dtSarkiListesi.SelectedRows[0].Cells["TurAdi"].Value.ToString();
                        sarkiDuzenle.AlbumAdi = dtSarkiListesi.SelectedRows[0].Cells["AlbumAdi"].Value.ToString();
                        int yil = (int)dtSarkiListesi.SelectedRows[0].Cells["Yil"].Value;
                        sarkiDuzenle.Yil = new DateTime(yil, 1, 1);

                        sarkiDuzenle.Show();
                    }
                    else
                    {
                        MessageBox.Show("Dosya yolu bulunamadı.");
                    }
                }
                else
                {
                    MessageBox.Show("Bu şarkıyı düzenleme yetkiniz yok.");
                }
            }
            else
            {
                MessageBox.Show("Lütfen bir şarkı seçin.");
            }
        }

        private void btSil_Click(object sender, EventArgs e)
        {
            if (dtSarkiListesi.SelectedRows.Count > 0)
            {
                string selectedKullaniciAdi = dtSarkiListesi.SelectedRows[0].Cells["KullaniciAdi"].Value.ToString();
                string selectedSarkiAdi = dtSarkiListesi.SelectedRows[0].Cells["SarkiAdi"].Value.ToString();

                if (selectedKullaniciAdi == kullaniciAdi)
                {
                    DialogResult result = MessageBox.Show("Seçili şarkıyı silmek istediğinizden emin misiniz?", "Şarkı Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        string query = "DELETE FROM Sarkilar WHERE SarkiAdi = @SarkiAdi";

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@SarkiAdi", selectedSarkiAdi);
                            connection.Open();
                            int rowsAffected = command.ExecuteNonQuery();
                            connection.Close();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Şarkı başarıyla silindi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                GetData();
                            }
                            else
                            {
                                MessageBox.Show("Şarkı silinirken bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Bu şarkıyı silme yetkiniz yok.", "Yetki Hatası", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Lütfen bir şarkı seçin.", "Seçim Hatası", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btCikisYap_Click(object sender, EventArgs e)
        {
            GIRIS giris = new GIRIS();
            giris.Show();
            this.Hide();
        }
    }
}