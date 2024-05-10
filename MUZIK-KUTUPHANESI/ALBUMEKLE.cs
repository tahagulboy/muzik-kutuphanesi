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
    public partial class ALBUMEKLE : Form
    {
        private SqlConnection connection;

        public ALBUMEKLE()
        {
            InitializeComponent();
            connection = new SqlConnection("Data Source = DESKTOP-2DF58T4;Initial Catalog = Muzik;Integrated Security = true;");
        }

        private void btAlbumEkle_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();

                string sqlQuery = "INSERT INTO Albumler (AlbumAdi) VALUES (@albumAdi)";

                SqlCommand sqlCommand = new SqlCommand(sqlQuery, connection);

                sqlCommand.Parameters.AddWithValue("@albumAdi", lbAlbumAdi.Text);

                sqlCommand.ExecuteNonQuery();

                connection.Close();

                MessageBox.Show("Albüm Eklendi!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veritabanı bağlantısında hata oluştu: " + ex.Message);
            }
        }
    }
}
