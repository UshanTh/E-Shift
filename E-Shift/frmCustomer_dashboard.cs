using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Shift
{
    public partial class frmCustomer_dashboard : Form
    {
        public frmCustomer_dashboard(string username)
        {
            InitializeComponent();
            lblUsr.Text = username;
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCustomer_profile fcus_Profile = new frmCustomer_profile(lblUsr.Text);
            fcus_Profile.Show();
        }

        private void frmCustomer_dashboard_Load(object sender, EventArgs e)
        {

        }
    }
}
