﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace finalProject
{
    public partial class Domikom : Form
    {
        public Domikom()
        {
            InitializeComponent();
        }

        private bool isValid ()
        {
            if (username.Text.TrimStart() == string.Empty)
            {
                MessageBox.Show("Masukkan Username Dengan Benar");
                return false;
            }
            else if (password.Text.TrimStart() == string.Empty)
            {
                MessageBox.Show("Masukkan Password Dengan Benar");
                return false;
            }
            return true;
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            username.Clear();
            password.Clear();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=E:\yazid\kuliah\SEMESTER 3\pemrograman lanjut\uas\domikom.db";
            string query = "SELECT * FROM Pengguna WHERE Username = @Username AND Password = @Password";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Username", username.Text); // TextBox untuk username
                        command.Parameters.AddWithValue("@Password", password.Text); // TextBox untuk password

                        SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        if (dt.Rows.Count > 0)
                        {
                            MessageBox.Show("Login berhasil!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Buka form Dashboard
                            dashboard Dashboard = new dashboard();
                            Dashboard.Show();

                            // Tutup form login
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Username atau password salah.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Terjadi kesalahan: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            SignUp signUpForm = new SignUp();
            signUpForm.ShowDialog();
        }
    }
}
