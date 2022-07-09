﻿using System;
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
    public partial class frmAdmin_Login : Form
    {
        DBase_Cls DB = new DBase_Cls();

        public frmAdmin_Login()
        {
            InitializeComponent();
        }

        private void btnSignin_Click(object sender, EventArgs e)
        {
            try
            {
                DB.openConnection(); // open database connection
                //Check admin usernam & Password 
                DB.login("Select Cus_Username,Cus_Password from customer where Cus_Username= '" + txtUsrname.Text + "' and Cus_Password= '" + txtPwd.Text + "'");
                if (DB.Dtable.Rows.Count == 1) //when query find the matched username and password
                {
                    //show welcome message box
                    MessageBox.Show("Welcome to E-Shift", "E-Shift", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide(); //close login form
                    //frmCustomer_dashboard fcus_dash = new frmCustomer_dashboard(txtUsrname.Text); //create object
                    //fcus_dash.Show(); //show customer dashboard form
                }
                else
                {
                    //show welcome message box
                    MessageBox.Show("Incorrect Username or Password", "E-Shift", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex) //catch error in database 
            {
                //show the error message
                MessageBox.Show("Error : " + ex.Message, "E-Shift", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                DB.closeConnection(); // close sql connection
            }
        }
    }
}
