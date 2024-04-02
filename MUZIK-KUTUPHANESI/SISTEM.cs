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

        public SISTEM()
        {
            InitializeComponent();
            connection = new SqlConnection("Data Source = DESKTOP-2DF58T4;Initial Catalog = Depo;Integrated Security = true;");
        }

        private void SISTEM_Load(object sender, EventArgs e)
        {
            GetData();
            ResizeDataGridView();
        }

        private void ResizeDataGridView()
        {
            sarkiListesi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            sarkiListesi.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void GetData()
        {
            string query = "SELECT * FROM Sarkilar";
            adapter = new SqlDataAdapter(query, connection);
            dataTable = new DataTable();
            adapter.Fill(dataTable);
            sarkiListesi.DataSource = dataTable;
        }

        private void araButonu_Click(object sender, EventArgs e)
        {
            string searchText = aramaKutusu.Text.ToLower();
            if (!string.IsNullOrWhiteSpace(searchText))
            {
                DataView dv = new DataView(dataTable);
                dv.RowFilter = string.Format("SarkiAdi LIKE '%{0}%'", searchText);
                sarkiListesi.DataSource = dv;
            }
            else
            {
                sarkiListesi.DataSource = dataTable;
            }
        }
    }
}
