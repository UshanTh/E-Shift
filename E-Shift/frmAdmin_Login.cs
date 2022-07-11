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
    public partial class frmAdmin_Login : Form
    {
        DBase_Cls DB = new DBase_Cls();

        public frmAdmin_Login()
        {
            InitializeComponent();
        }

        private void btnSignin_Click(object sender, EventArgs e)
        {
            if (txtUsrname.Text == "" || txtPwd.Text == "")
            {
                MessageBox.Show("Please enter all fields", "E-Shift", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    DB.openConnection(); // open database connection
                    DB.login("Select Admin_Username,Admin_Password from Admin where Admin_Username= '" + txtUsrname.Text + "' and Admin_Password= '" + txtPwd.Text + "'");
                    if (DB.Dtable.Rows.Count == 1) //when query find the matched username and password
                    {
                        //show welcome message box
                        MessageBox.Show("Welcome to E-Shift", "E-Shift", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide(); //close login form
                        frmAdmin_dashboard fAdmin_dash = new frmAdmin_dashboard(txtUsrname.Text); //create object
                        fAdmin_dash.Show(); //show customer dashboard form
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            //check user want to cancel this application using message box buttons
            if (MessageBox.Show("Are you sure to exit this application", "E-Shift", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Application.Exit(); // if user click ok close apllication
            }
        }
    }
}
