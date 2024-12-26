using finalProject.Tampilan;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace finalProject
{
    public partial class DetailDonasi : Form
    {
        public DetailDonasi(string nama, string nominal, string pesan, string metode, int KampanyeID)
        {
            InitializeComponent();
            LoadProfileData();
            txtNama.Text = nama;
            txtNominal.Text = nominal;
            txtPesan.Text = pesan;
            txtMetode.Text = metode;
            txtKampanye.Text = KampanyeID.ToString();
            txtTanggal.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void LoadProfileData()
        {
            string connectionString = @"Data Source=E:\yazid\kuliah\SEMESTER 3\pemrograman lanjut\uas\domikom.db";

            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT PenggunaID FROM Pengguna WHERE PenggunaID = @PenggunaID";

                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@PenggunaID", UserSession.PenggunaID); 


                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txtPengguna.Text = reader["PenggunaID"].ToString();

                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=E:\yazid\kuliah\SEMESTER 3\pemrograman lanjut\uas\domikom.db";
            string query = "INSERT INTO Donasi (Nama, PenggunaID, KampanyeID, JumlahDonasi, TanggalDonasi, Pesan, Metode) VALUES (@nama, @penggunaID, @kampanyeID, @jumlahDonasi, @tglDonasi, @pesan, @metode)";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@nama", txtNama.Text);
                        command.Parameters.AddWithValue("@penggunaID", txtPengguna.Text);
                        command.Parameters.AddWithValue("@kampanyeID", txtKampanye.Text);
                        command.Parameters.AddWithValue("@jumlahDonasi", txtNominal.Text);
                        command.Parameters.AddWithValue("@tglDonasi", txtTanggal.Text);
                        command.Parameters.AddWithValue("@pesan", txtPesan.Text);
                        command.Parameters.AddWithValue("@metode", txtMetode.Text);

                        command.ExecuteNonQuery();
                        MessageBox.Show("Donasi berhasil kirim dengan nominal " + txtNominal.Text, "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Terjadi kesalahan: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                this.Close();
            }
        }
    }
}

