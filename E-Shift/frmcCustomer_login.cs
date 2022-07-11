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
    public partial class frmcCustomer_login : Form
    {
        DBase_Cls DB = new DBase_Cls(); // Class object
        //string user_Status = "Approved";

        public frmcCustomer_login()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

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
                    //DB.login("Select Cus_Username,Cus_Password from customer where Cus_Username= '" + txtUsrname.Text + "' and Cus_Password= '" + txtPwd.Text + "' or Cus_Status = '" + user_Status + "'");
                    DB.login("Select Cus_Username,Cus_Password from customer where Cus_Username= '" + txtUsrname.Text + "' and Cus_Password= '" + txtPwd.Text + "'");
                    if (DB.Dtable.Rows.Count == 1) //when query find the matched username and password
                    {
                        //show welcome message box
                        MessageBox.Show("Welcome to E-Shift", "E-Shift", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide(); //close login form
                        frmCustomer_dashboard fcus_dash = new frmCustomer_dashboard(txtUsrname.Text); //create object
                        fcus_dash.Show(); //show customer dashboard form
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

        private void joinLbl_Click(object sender, EventArgs e)
        {
            this.Hide(); //close this form
            frmCustomer_signin fcussign = new frmCustomer_signin(); //create object for customer sign in page
            fcussign.Show(); //open customer sign in form
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
