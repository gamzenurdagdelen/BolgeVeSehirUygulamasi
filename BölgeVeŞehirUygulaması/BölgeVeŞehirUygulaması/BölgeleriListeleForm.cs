using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BölgeVeŞehirUygulaması
{
    public partial class BölgeleriListeleForm : Form
    {
        private const string connectionString = "Data Source=MSSQLADRES;Initial Catalog=DbName;User ID=DbUserName;Password=DbPassword";
        public BölgeleriListeleForm()
        {
            InitializeComponent();
        }

        private void BölgeEkle(string bölgeAdı)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Bölgeler tablosundaki bölge sayısını kontrol et
                string countQuery = "SELECT COUNT(*) FROM Bölgeler";
                SqlCommand countCommand = new SqlCommand(countQuery, connection);
                connection.Open();
                int bölgeSayısı = (int)countCommand.ExecuteScalar();
                if (bölgeSayısı >= 7)
                {
                    MessageBox.Show("Maksimum bölge sayısına ulaşıldı.");
                    return;
                }

                // Eklenecek bölgenin tabloda olup olmadığını kontrol et
                string checkQuery = "SELECT COUNT(*) FROM Bölgeler WHERE BölgeAdı = @BölgeAdı";
                SqlCommand checkCommand = new SqlCommand(checkQuery, connection);
                checkCommand.Parameters.AddWithValue("@BölgeAdı", bölgeAdı);
                int count = (int)checkCommand.ExecuteScalar();
                if (count > 0)
                {
                    MessageBox.Show("Bu bölge zaten mevcut.");
                    return;
                }

                // Bölgeyi ekle
                string insertQuery = "INSERT INTO Bölgeler (BölgeAdı) VALUES (@BölgeAdı)";
                SqlCommand insertCommand = new SqlCommand(insertQuery, connection);
                insertCommand.Parameters.AddWithValue("@BölgeAdı", bölgeAdı);
                insertCommand.ExecuteNonQuery();
                MessageBox.Show("Bölge eklendi.");
            }
        }

        private void BölgeSil(string bölgeAdı)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Bağlı olduğu Şehirler tablosunda veri var mı kontrol et
                string checkQuery = "SELECT COUNT(*) FROM Şehirler WHERE BölgeID = (SELECT BölgeID FROM Bölgeler WHERE BölgeAdı = @BölgeAdı)";
                SqlCommand checkCommand = new SqlCommand(checkQuery, connection);
                checkCommand.Parameters.AddWithValue("@BölgeAdı", bölgeAdı);
                int şehirSayısı = (int)checkCommand.ExecuteScalar();

                if (şehirSayısı > 0)
                {
                    MessageBox.Show("Bu bölgeye bağlı şehir(ler) olduğu için bölgeyi silemezsiniz.");
                    return;
                }

                // Bağlı şehir yoksa bölgeyi sil
                string deleteQuery = "DELETE FROM Bölgeler WHERE BölgeAdı = @BölgeAdı";
                SqlCommand deleteCommand = new SqlCommand(deleteQuery, connection);
                deleteCommand.Parameters.AddWithValue("@BölgeAdı", bölgeAdı);
                int rowsAffected = deleteCommand.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Bölge silindi.");
                }
                else
                {
                    MessageBox.Show("Bölge bulunamadı.");
                }
            }
        }
        private void BölgeleriListele()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT BölgeAdı FROM Bölgeler";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView1.DataSource = table;
            }
        }

        private void btnBölgeEkle_Click(object sender, EventArgs e)
        {
            string bölgeAdı = txtBölgeAdı.Text.Trim();

            if (!string.IsNullOrWhiteSpace(bölgeAdı))
            {
                BölgeEkle(bölgeAdı);
                BölgeleriListele();
            }
            else
            {
                MessageBox.Show("Lütfen bir bölge adı girin.");
            }
        }

        private void btnBölgeSil_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string selectedBölge = dataGridView1.SelectedRows[0].Cells["BölgeAdı"].Value.ToString();
               BölgeSil(selectedBölge);
                BölgeleriListele();
            }
            else
            {
                MessageBox.Show("Lütfen silinecek bir bölge seçin.");
            }
        }

        private void BölgeleriListeleForm_Load(object sender, EventArgs e)
        {
            BölgeleriListele();
        }
    }
}