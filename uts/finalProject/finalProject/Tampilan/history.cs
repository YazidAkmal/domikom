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

namespace finalProject.Tampilan
{
    public partial class history : UserControl
    {
        public history()
        {
            InitializeComponent();
            LoadHistory();
        }

        private void LoadHistory()
        {
            string connectionString = @"Data Source=E:\yazid\kuliah\SEMESTER 3\pemrograman lanjut\uas\domikom.db";

            string query = @"
        SELECT 
            Donasi.DonasiID, 
            Donasi.Nama AS Username,
            Kampanye.KampanyeID AS Kampanye,
            Donasi.JumlahDonasi,
            Donasi.Metode AS MetodePembayaran,
            strftime('%d/%m/%Y %H:%M:%S', Donasi.TanggalDonasi) AS Tanggal,
            Donasi.Pesan
        FROM Donasi
        LEFT JOIN Kampanye ON Donasi.KampanyeID = Kampanye.KampanyeID
        WHERE Donasi.PenggunaID = @PenggunaID";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@PenggunaID", UserSession.PenggunaID);

                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {
                            lvwHistory.Items.Clear();

                            while (reader.Read())
                            {
                                ListViewItem item = new ListViewItem(reader["DonasiID"].ToString());
                                item.SubItems.Add(reader["Username"].ToString());
                                item.SubItems.Add(reader["Kampanye"].ToString());
                                item.SubItems.Add(Convert.ToDecimal(reader["JumlahDonasi"]).ToString("C"));
                                item.SubItems.Add(reader["MetodePembayaran"].ToString());
                                item.SubItems.Add(reader["Tanggal"].ToString());
                                item.SubItems.Add(reader["Pesan"].ToString());

                                lvwHistory.Items.Add(item);
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
}

