using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BölgeVeŞehirUygulaması
{
    public partial class ŞehirleriListeleForm : Form
    {
        private const string connectionString = "Data Source=MSSQLADRES;Initial Catalog=DbName;User ID=DbUserName;Password=DbPassword";
        public ŞehirleriListeleForm()
        {
            InitializeComponent();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.CellClick += DataGridView1_CellClick;
            FillBölgelerComboBox(); // Bölgeler combobox'ını doldur
        }

        private void FillBölgelerComboBox()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT BölgeAdı FROM Bölgeler";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable table = new DataTable();
                adapter.Fill(table);

                cmbBölgeler.DisplayMember = "BölgeAdı";
                cmbBölgeler.DataSource = table;
            }
        }

        private void ŞehirleriListele()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT Şehirler.*, Bölgeler.BölgeAdı FROM Şehirler INNER JOIN Bölgeler ON Şehirler.BölgeID = Bölgeler.BölgeID";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView1.DataSource = table;
            }
        }

        private void ŞehirSil(string şehirAdı)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Şehri sil
                string deleteQuery = "DELETE FROM Şehirler WHERE ŞehirAdı = @ŞehirAdı";
                SqlCommand deleteCommand = new SqlCommand(deleteQuery, connection);
                deleteCommand.Parameters.AddWithValue("@ŞehirAdı", şehirAdı);
                int rowsAffected = deleteCommand.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Şehir silindi.");
                }
                else
                {
                    MessageBox.Show("Şehir bulunamadı.");
                }
            }
        }

        private void ŞehirEkle(string şehirAdı, string bölgeAdı)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Bölge ID'sini almak için bölge adından sorgu yap
                string getBölgeIDQuery = "SELECT BölgeID FROM Bölgeler WHERE BölgeAdı = @BölgeAdı";
                SqlCommand getBölgeIDCommand = new SqlCommand(getBölgeIDQuery, connection);
                getBölgeIDCommand.Parameters.AddWithValue("@BölgeAdı", bölgeAdı);
                connection.Open();
                object result = getBölgeIDCommand.ExecuteScalar();

                if (result != null)
                {
                    int bölgeID = Convert.ToInt32(result);

                    // Var olan şehir bilgisini kontrol et
                    string checkQuery = "SELECT COUNT(*) FROM Şehirler WHERE ŞehirAdı = @ŞehirAdı";
                    SqlCommand checkCommand = new SqlCommand(checkQuery, connection);
                    checkCommand.Parameters.AddWithValue("@ŞehirAdı", şehirAdı);
                    int count = (int)checkCommand.ExecuteScalar();

                    if (count > 0)
                    {
                        MessageBox.Show("Bu şehir zaten mevcut.");
                        return;
                    }

                    // Şehri ekle
                    string query = "INSERT INTO Şehirler (ŞehirAdı, BölgeID) VALUES (@ŞehirAdı, @BölgeID)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@ŞehirAdı", şehirAdı);
                    command.Parameters.AddWithValue("@BölgeID", bölgeID);
                    command.ExecuteNonQuery();
                }
                else
                {
                    MessageBox.Show("Geçersiz bölge adı.");
                }
                MessageBox.Show("Şehir eklendi!");
                ŞehirleriListele();
            }
        }

        private void btnŞehirEkle_Click(object sender, EventArgs e)
        {
            string şehirAdı = txtŞehirAdı.Text.Trim();
            string bölgeAdı = cmbBölgeler.Text.Trim();

            ŞehirEkle(şehirAdı, bölgeAdı);
        }

        private void ŞehirleriListeleForm_Load(object sender, EventArgs e)
        {
            ŞehirleriListele();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ŞehirleriListele();
        }

        private void ŞehirSilBtn_Click(object sender, EventArgs e)
        {
            ŞehirSil(txtŞehirAdı.Text);
            ŞehirleriListele();
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txtŞehirAdı.Text = row.Cells["ŞehirAdı"].Value.ToString();
            }
        }
    }
}
