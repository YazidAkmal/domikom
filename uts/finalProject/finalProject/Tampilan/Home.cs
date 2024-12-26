using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace finalProject.Tampilan
{
    public partial class Home : UserControl
    {
        public Home()
        {
            InitializeComponent();
        }
        private void btn_donasi_Click(object sender, EventArgs e)
        {
            panelUtama.Controls.Clear();

            Donation donation = new Donation();

            donation.Dock = DockStyle.Fill;

            panelUtama.Controls.Add(donation);
        }
    }
}
