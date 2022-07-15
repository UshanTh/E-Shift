using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Shift.Admin_Dashboard
{
    public partial class ucAdmin_dashboard : UserControl
    {
        private ucAssistant ucAssistant_info;
        private ucAdmin_dashboard ucAdmin_Dash;
        private ucAdmin_profile ucAdmin_pro;
        private ucCustomer_details ucCustomer_info;
        private ucDriver_details ucDriver_info;
        private ucProducts ucProducts;
        private ucJob_details ucJob_info;
        private ucUnit ucUnit_info;
        private ucLoad ucLoad_info;
        private ucLorry ucLorry_info;

        public ucAdmin_dashboard()
        {
            InitializeComponent();
        }

        private void btnLorry_Click(object sender, EventArgs e)
        {
            ucLorry ucLorry = new ucLorry();
            ucLorry.Dock = DockStyle.Fill;
            this.Controls.Add(ucLorry);
            ucAdmin_dashboard ucadmin = new ucAdmin_dashboard();
            ucadmin.Hide();
            ucadmin.Controls.Clear();


            //ucLorry_info = new ucLorry();
            //this.ucLorry_info.Dock = System.Windows.Forms.DockStyle.Fill;
            //this.ucLorry_info.Location = new System.Drawing.Point(0, 0);
            //this.ucLorry_info.Name = "Lorry Details";
            //this.ucLorry_info.TabIndex = 0;
        }
    }
}
