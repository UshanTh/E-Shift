using E_Shift.Cus_Dashboard;
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
        private ucCus_profile usrProfile;
        private ucCustomer_Dashboard cus_Dashboard;

        public frmCustomer_dashboard(string username)
        {
            InitializeComponent();
            lblUsr.Text = username; 
        }

        internal void togglePanelMain(string panelname)
        {
            this.pnl_Main.Controls.Clear();
            switch (panelname)
            {
                case "customer_Profile":
                    if (this.usrProfile == null)
                    {
                        this.usrProfile = new ucCus_profile(lblUsr.Text);
                        this.pnl_Main.Controls.Add(usrProfile);
                        this.usrProfile.Dock = System.Windows.Forms.DockStyle.Fill;
                        this.usrProfile.Location = new System.Drawing.Point(0, 0);
                        this.usrProfile.Name = "UserProfile";
                        this.usrProfile.TabIndex = 0;
                    }
                    else
                    {
                        this.pnl_Main.Controls.Add(usrProfile);
                    }
                    break;
                case "customer_Dashboard":
                    if (this.cus_Dashboard == null)
                    {
                        this.cus_Dashboard = new ucCustomer_Dashboard();
                        this.pnl_Main.Controls.Add(cus_Dashboard);
                        this.cus_Dashboard.Dock = System.Windows.Forms.DockStyle.Fill;
                        this.cus_Dashboard.Location = new System.Drawing.Point(0, 0);
                        this.cus_Dashboard.Name = "Customer Dashboard";
                        this.cus_Dashboard.TabIndex = 0;
                    }
                    else
                    {
                        this.pnl_Main.Controls.Add(cus_Dashboard);
                    }
                    break;
                default:
                    break;
            }
        }
        private void btnProfile_Click(object sender, EventArgs e)
        {
            this.togglePanelMain("customer_Profile");
        }

        private void frmCustomer_dashboard_Load(object sender, EventArgs e)
        {
            this.togglePanelMain("customer_Dashboard");
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            this.togglePanelMain("customer_Dashboard");
        }
    }
}
