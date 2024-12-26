using finalProject.Tampilan;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace finalProject
{
    public partial class dashboard : Form
    {

        public string LoggedInUsername { get; set; }

        public dashboard()
        {
            InitializeComponent();
            Home uC = new Home();
            addUserControl(uC);
        }

        public void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelUtama.Controls.Clear();
            panelUtama.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Home uC = new Home();
            addUserControl(uC);
        }
        private void btnDonation_Click(object sender, EventArgs e)
        {
            Donation uC = new Donation();
            addUserControl(uC);
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            Profile uC = new Profile();
            addUserControl(uC);
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            history uC = new history();
            addUserControl(uC);
        }

        private void btnRequest_Click(object sender, EventArgs e)
        {
            
        }
    }
}
