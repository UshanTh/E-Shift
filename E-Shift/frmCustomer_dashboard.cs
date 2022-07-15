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
        private ucJobs myJobs;
        private ucProducts myProducts;

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
                        this.cus_Dashboard = new ucCustomer_Dashboard(lblUsr.Text);
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
                case "My Jobs":
                    if (this.myJobs == null)
                    {
                        this.myJobs = new ucJobs(lblUsr.Text);
                        this.pnl_Main.Controls.Add(myJobs);
                        this.myJobs.Dock = System.Windows.Forms.DockStyle.Fill;
                        this.myJobs.Location = new System.Drawing.Point(0, 0);
                        this.myJobs.Name = "My Jobs";
                        this.myJobs.TabIndex = 0;
                    }
                    else
                    {
                        this.pnl_Main.Controls.Add(myJobs);
                    }
                    break;
                case "My Products":
                    if (this.myProducts == null)
                    {
                        this.myProducts = new ucProducts();
                        this.pnl_Main.Controls.Add(myProducts);
                        this.myProducts.Dock = System.Windows.Forms.DockStyle.Fill;
                        this.myProducts.Location = new System.Drawing.Point(0, 0);
                        this.myProducts.Name = "My Products";
                        this.myProducts.TabIndex = 0;
                    }
                    else
                    {
                        this.pnl_Main.Controls.Add(myProducts);
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
            //this.togglePanelMain("customer_Dashboard");
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            this.togglePanelMain("customer_Dashboard");
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            //check user want to cancel this application using message box buttons
            if (MessageBox.Show("Are You Sure To Logout This Application", "E-Shift", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                this.Hide();
                frmcCustomer_login fcus_login = new frmcCustomer_login();
                fcus_login.Show();
            }
        }

        private void btnJobs_Click(object sender, EventArgs e)
        {
            this.togglePanelMain("My Jobs");
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            this.togglePanelMain("My Products");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
