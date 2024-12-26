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

namespace finalProject
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
            cmbPeran.Items.Add("Admin");
            cmbPeran.Items.Add("User");
            cmbPeran.SelectedIndex = 1;
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=E:\yazid\kuliah\SEMESTER 3\pemrograman lanjut\uas\domikom.db";
            string query = "INSERT INTO Pengguna (Username, email, Password, noTelp, peran) VALUES (@Username, @email, @password, @peran)";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Username", Username.Text);
                        command.Parameters.AddWithValue("@email", Email.Text); 
                        command.Parameters.AddWithValue("@password", Password.Text);
                        command.Parameters.AddWithValue("@noTelp", noTelp.Text);
                        command.Parameters.AddWithValue("@peran", cmbPeran.SelectedItem.ToString());

                        command.ExecuteNonQuery();
                        MessageBox.Show("Akun berhasil dibuat dengan peran " + cmbPeran.SelectedItem, "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close(); 
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Terjadi kesalahan: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
