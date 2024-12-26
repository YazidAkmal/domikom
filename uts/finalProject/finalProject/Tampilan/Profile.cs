using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;
using System.Drawing;


namespace finalProject.Tampilan
{

    public partial class Profile : UserControl
    {
        private string fotoProfilPath;
        public Profile()
        {
            InitializeComponent();
            LoadProfileData(); 
        }

        private void LoadProfileData()
        {
            string connectionString = @"Data Source=E:\yazid\kuliah\SEMESTER 3\pemrograman lanjut\uas\domikom.db";

            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT PenggunaID, Username, Email, NoTelp, Peran, Password, FotoProfil FROM Pengguna WHERE PenggunaID = @PenggunaID";

                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@PenggunaID", UserSession.PenggunaID); 

                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txtPenggunaID.Text = reader["PenggunaID"].ToString();
                                txtUsername.Text = reader["Username"].ToString();
                                txtEmail.Text = reader["Email"].ToString();
                                txtNoTelp.Text = reader["NoTelp"].ToString();
                                txtPeran.Text = reader["Peran"].ToString();
                                txtPassword.Text = reader["Password"].ToString();

                                string fotoPath = reader["FotoProfil"] != DBNull.Value ? reader["FotoProfil"].ToString() : string.Empty;
                                if (!string.IsNullOrEmpty(fotoPath) && System.IO.File.Exists(fotoPath))
                                {
                                    pictureBoxFoto.Image = Image.FromFile(fotoPath);
                                    fotoProfilPath = fotoPath; 
                                }
                                else
                                {
                                    pictureBoxFoto.Image = null; 
                                }
                            }
                            else
                            {
                                MessageBox.Show("Data pengguna tidak ditemukan.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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


        private void Profile_Load(object sender, EventArgs e)
        {
            
        }

        private void panelUtama_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            UserSession.PenggunaID = 0;
            UserSession.Username = string.Empty;

            Domikom loginForm = new Domikom();
            loginForm.Show();

            this.Hide();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;";
                openFileDialog.Title = "Pilih Foto Profil";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pictureBoxFoto.Image = Image.FromFile(openFileDialog.FileName);

                    fotoProfilPath = openFileDialog.FileName;
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(fotoProfilPath))
            {
                MessageBox.Show("Silakan pilih foto profil terlebih dahulu.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string connectionString = @"Data Source=E:\yazid\kuliah\SEMESTER 3\pemrograman lanjut\uas\domikom.db";
            string query = "UPDATE Pengguna SET FotoProfil = @FotoProfil WHERE PenggunaID = @PenggunaID";

            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();
                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@FotoProfil", fotoProfilPath); 
                        command.Parameters.AddWithValue("@PenggunaID", txtPenggunaID.Text); 

                        int result = command.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Foto profil berhasil disimpan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Gagal menyimpan foto profil.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
