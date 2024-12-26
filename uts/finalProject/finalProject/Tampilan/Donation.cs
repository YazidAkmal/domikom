using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace finalProject.Tampilan
{
    public partial class Donation : UserControl
    {

        public Donation()
        {
            InitializeComponent();
        }

        private void pnlCampaign1_Paint(object sender, PaintEventArgs e)
        {
            LoadCampaignData();

        }
        private void LoadCampaignData()
        {
            string connectionString = @"Data Source=E:\yazid\kuliah\SEMESTER 3\pemrograman lanjut\uas\domikom.db";

            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    string query = @"
                SELECT 
                    Kampanye.KampanyeID,
                    Kampanye.Gambar, 
                    Kampanye.Judul, 
                    Pengguna.Username AS DibuatOleh, 
                    Kampanye.TanggalDibuat, 
                    Kampanye.Deskripsi, 
                    Kampanye.TargetDonasi, 
                    SUM(Donasi.JumlahDonasi) AS DonasiTerkumpul,
                    Kategori.NamaKategori AS Kategori
                FROM 
                    Kampanye
                INNER JOIN 
                    Pengguna 
                ON 
                    Kampanye.DibuatOleh = Pengguna.PenggunaID
                INNER JOIN 
                    Kategori 
                ON 
                    Kampanye.Kategori = Kategori.KategoriID
                LEFT JOIN Donasi ON Kampanye.KampanyeID = Donasi.KampanyeID
                LIMIT 1";

                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                int kampanyeID = Convert.ToInt32(reader["KampanyeID"]);

                                string gambarPath = reader["Gambar"]?.ToString();
                                if (!string.IsNullOrEmpty(gambarPath) && System.IO.File.Exists(gambarPath))
                                {
                                    pictureBoxCampaign.Image = Image.FromFile(gambarPath);
                                }
                                else
                                {
                                    pictureBoxCampaign.Image = null;
                                    MessageBox.Show("Path gambar tidak valid atau file tidak ditemukan.");
                                }

                                txt1.Text = reader["Judul"].ToString();
                                txt2.Text = reader["DibuatOleh"].ToString();
                                txt3.Text = Convert.ToDateTime(reader["TanggalDibuat"]).ToString("dd MMM yyyy");
                                txt4.Text = reader["Deskripsi"].ToString();
                                txt5.Text = string.Format("{0:N0}", reader["TargetDonasi"]);
                                txt6.Text = string.Format("{0:N0}", reader["DonasiTerkumpul"]);
                                txt7.Text = reader["Kategori"].ToString();

                                btnDonasi.Click += (sender, e) =>
                                {
                                    DonationPopUp donationPopUp = new DonationPopUp(kampanyeID);
                                    donationPopUp.Show();
                                };
                            }
                            else
                            {
                                MessageBox.Show("Kampanye tidak ditemukan.");
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
        public string GetTxt1Text()
        {
            return txt1.Text;
        }
        private void btnDonasi_Click(object sender, EventArgs e)
        {
            int kampanyeID = 1;
            DonationPopUp donationPopUp = new DonationPopUp(kampanyeID);
            donationPopUp.Show();
        }

        private void pgbTerkumpul1_ValueChanged(object sender, EventArgs e)
        {

        }
    }

}
