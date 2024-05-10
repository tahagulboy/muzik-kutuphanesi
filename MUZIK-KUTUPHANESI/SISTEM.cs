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
            string query = "SELECT * FROM Sarkilar";
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
    }
}
