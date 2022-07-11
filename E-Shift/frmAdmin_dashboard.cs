using E_Shift.Admin_Dashboard;
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
    public partial class frmAdmin_dashboard : Form
    {
        private ucAdmin_dashboard ucAdmin_Dash;
        private ucAdmin_profile ucAdmin_pro;
        private ucCustomer_details ucCustomer_info;
        private ucDriver_details ucDriver_info;
        private ucProducts ucProducts;
        private ucJob_details ucJob_info;

        public frmAdmin_dashboard(string username)
        {
            InitializeComponent();
            lblUsr.Text = username;
        }

        internal void togglePanelMain(string panelname)
        {
            this.pnl_Main.Controls.Clear();
            switch (panelname)
            {
                case "Admin Dashboard":
                    if (this.ucAdmin_Dash == null)
                    {
                        this.ucAdmin_Dash = new ucAdmin_dashboard();
                        this.pnl_Main.Controls.Add(ucAdmin_Dash);
                        this.ucAdmin_Dash.Dock = System.Windows.Forms.DockStyle.Fill;
                        this.ucAdmin_Dash.Location = new System.Drawing.Point(0, 0);
                        this.ucAdmin_Dash.Name = "Admin Dashboard";
                        this.ucAdmin_Dash.TabIndex = 0;
                    }
                    else
                    {
                        this.pnl_Main.Controls.Add(ucAdmin_Dash);
                    }
                    break;
                case "Customer Detaills":
                    if (this.ucCustomer_info == null)
                    {
                        this.ucCustomer_info = new ucCustomer_details();
                        this.pnl_Main.Controls.Add(ucCustomer_info);
                        this.ucCustomer_info.Dock = System.Windows.Forms.DockStyle.Fill;
                        this.ucCustomer_info.Location = new System.Drawing.Point(0, 0);
                        this.ucCustomer_info.Name = "Customer Details";
                        this.ucCustomer_info.TabIndex = 0;
                    }
                    else
                    {
                        this.pnl_Main.Controls.Add(ucCustomer_info);
                    }
                    break;
                case "Admin Profile":
                    if (this.ucAdmin_pro == null)
                    {
                        this.ucAdmin_pro = new ucAdmin_profile(lblUsr.Text);
                        this.pnl_Main.Controls.Add(ucAdmin_pro);
                        this.ucAdmin_pro.Dock = System.Windows.Forms.DockStyle.Fill;
                        this.ucAdmin_pro.Location = new System.Drawing.Point(0, 0);
                        this.ucAdmin_pro.Name = "Admin profile";
                        this.ucAdmin_pro.TabIndex = 0;
                    }
                    else
                    {
                        this.pnl_Main.Controls.Add(ucAdmin_pro);
                    }
                    break;
                case "Job Details":
                    if (this.ucJob_info == null)
                    {
                        this.ucJob_info = new ucJob_details();
                        this.pnl_Main.Controls.Add(ucJob_info);
                        this.ucJob_info.Dock = System.Windows.Forms.DockStyle.Fill;
                        this.ucJob_info.Location = new System.Drawing.Point(0, 0);
                        this.ucJob_info.Name = "Job Details";
                        this.ucJob_info.TabIndex = 0;
                    }
                    else
                    {
                        this.pnl_Main.Controls.Add(ucJob_info);
                    }
                    break;
                case "Driver Details":
                    if (this.ucDriver_info == null)
                    {
                        this.ucDriver_info = new ucDriver_details();
                        this.pnl_Main.Controls.Add(ucDriver_info);
                        this.ucDriver_info.Dock = System.Windows.Forms.DockStyle.Fill;
                        this.ucDriver_info.Location = new System.Drawing.Point(0, 0);
                        this.ucDriver_info.Name = "Driver Details";
                        this.ucDriver_info.TabIndex = 0;
                    }
                    else
                    {
                        this.pnl_Main.Controls.Add(ucDriver_info);
                    }
                    break;
                case "Product Details":
                    if (this.ucProducts == null)
                    {
                        this.ucProducts = new ucProducts();
                        this.pnl_Main.Controls.Add(ucProducts);
                        this.ucProducts.Dock = System.Windows.Forms.DockStyle.Fill;
                        this.ucProducts.Location = new System.Drawing.Point(0, 0);
                        this.ucProducts.Name = "Product details";
                        this.ucProducts.TabIndex = 0;
                    }
                    else
                    {
                        this.pnl_Main.Controls.Add(ucProducts);
                    }
                    break;
                default:
                    break;
            }
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            this.togglePanelMain("Admin Dashboard");
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            this.togglePanelMain("Customer Detaills");
        }

        private void btnDriver_Click(object sender, EventArgs e)
        {
            this.togglePanelMain("Driver Details");
        }

        private void btnJobs_Click(object sender, EventArgs e)
        {
            this.togglePanelMain("Job Details");
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            this.togglePanelMain("Product Details");
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            this.togglePanelMain("Admin Profile");
        }
    }
}
