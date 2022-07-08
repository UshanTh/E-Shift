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
    public partial class frmCustomer_profile : Form
    {
        public frmCustomer_profile(string username)
        {
            InitializeComponent();
            txtUsername.Text = username;
        }

        private void frmCustomer_profile_Load(object sender, EventArgs e)
        {

        }
    }
}
