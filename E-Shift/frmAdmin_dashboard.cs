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
        private ucUnit ucUnit_info;
        private ucLoad ucLoad_info;
        private ucLorry ucLorry_info;
        private ucAssistant ucAssistant_info;

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
                case "Unit Details":
                    if (this.ucUnit_info == null)
                    {
                        this.ucUnit_info = new ucUnit();
                        this.pnl_Main.Controls.Add(ucUnit_info);
                        this.ucUnit_info.Dock = System.Windows.Forms.DockStyle.Fill;
                        this.ucUnit_info.Location = new System.Drawing.Point(0, 0);
                        this.ucUnit_info.Name = "Unit Details";
                        this.ucUnit_info.TabIndex = 0;
                    }
                    else
                    {
                        this.pnl_Main.Controls.Add(ucUnit_info);
                    }
                    break;
                case "Load Details":
                    if (this.ucLoad_info == null) 
                    {
                        this.ucLoad_info = new ucLoad();
                        this.pnl_Main.Controls.Add(ucLoad_info);
                        this.ucLoad_info.Dock = System.Windows.Forms.DockStyle.Fill;
                        this.ucLoad_info.Location = new System.Drawing.Point(0, 0);
                        this.ucLoad_info.Name = "Load Details";
                        this.ucLoad_info.TabIndex = 0;
                    }
                    else
                    {
                        this.pnl_Main.Controls.Add(ucLoad_info);
                    }
                    break;
                case "Lorry Details":
                    if (this.ucLorry_info == null)
                    {
                        this.ucLorry_info = new ucLorry();
                        this.pnl_Main.Controls.Add(ucLorry_info);
                        this.ucLorry_info.Dock = System.Windows.Forms.DockStyle.Fill;
                        this.ucLorry_info.Location = new System.Drawing.Point(0, 0);
                        this.ucLorry_info.Name = "Lorry Details";
                        this.ucLorry_info.TabIndex = 0;
                    }
                    else
                    {
                        this.pnl_Main.Controls.Add(ucLorry_info);
                    }
                    break;
                case "Assistant Details":
                    if (this.ucAssistant_info == null)
                    {
                        this.ucAssistant_info = new ucAssistant();
                        this.pnl_Main.Controls.Add(ucAssistant_info);
                        this.ucAssistant_info.Dock = System.Windows.Forms.DockStyle.Fill;
                        this.ucAssistant_info.Location = new System.Drawing.Point(0, 0);
                        this.ucAssistant_info.Name = "Assistant Details";
                        this.ucAssistant_info.TabIndex = 0;
                    }
                    else
                    {
                        this.pnl_Main.Controls.Add(ucAssistant_info);
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

        private void btnLogout_Click(object sender, EventArgs e)
        {
            //check user want to exit this application using message box buttons
            if (MessageBox.Show("Are You Sure To Logout This Application", "E-Shift", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                this.Hide();
                frmAdmin_Login fadmin_login = new frmAdmin_Login();
                fadmin_login.Show();
            }
        }

        private void btnUnit_Click(object sender, EventArgs e)
        {
            this.togglePanelMain("Unit Details");
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            this.togglePanelMain("Load Details");
        }

        private void btnLorry_Click(object sender, EventArgs e)
        {
            this.togglePanelMain("Lorry Details");
        }

        private void btnAssistant_Click(object sender, EventArgs e)
        {
            this.togglePanelMain("Assistant Details");
        }
    }
}
