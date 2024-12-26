using finalProject.Tampilan;
using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace finalProject
{
    public partial class DonationPopUp : Form
    {
        private readonly int kampanyeID;
        private readonly int PenggunaID;


        public DonationPopUp(int kampanyeID)
        {
            InitializeComponent();
            cmbMetode.Items.Add("Bank");
            cmbMetode.Items.Add("E-Wallet");

            this.kampanyeID = kampanyeID;
        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
            string nama = txtNama.Text;
            string nominal = txtNominal.Text;
            string pesan = txtPesan.Text;
            string metode = cmbMetode.SelectedItem.ToString();

            DetailDonasi detail = new DetailDonasi(nama, nominal, pesan, metode, kampanyeID);

            this.Close();
            detail.Show();
        }

        private void btnDonasi_Click(object sender, EventArgs e)
        {
            string nama = txtNama.Text;
            string nominal = txtNominal.Text;
            string pesan = txtPesan.Text;
            string metode = cmbMetode.SelectedItem.ToString();
            string password = txtPassword.Text;

            if (string.IsNullOrWhiteSpace(nama) ||
                string.IsNullOrWhiteSpace(nominal) ||
                string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Mohon lengkapi semua data.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            DetailDonasi detail = new DetailDonasi(nama, nominal, pesan, metode, kampanyeID);
            this.Close();
            detail.Show();


        }
    }

}