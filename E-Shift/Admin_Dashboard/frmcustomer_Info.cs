using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Shift.Admin_Dashboard
{
    public partial class frmcustomer_Info : Form
    {
        public frmcustomer_Info()
        {
            InitializeComponent();
        }

        private void frmcustomer_Info_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'e_ShiftDataSet.customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.e_ShiftDataSet.customer);

            this.reportViewer1.RefreshReport();
        }
    }
}
