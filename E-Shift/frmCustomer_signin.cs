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
    public partial class frmCustomer_signin : Form
    {
        DBase_Cls DB = new DBase_Cls(); // Class object

        public frmCustomer_signin()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                DB.openConnection(); //open sql connection
                //insert record to database
                DB.queryingRecord("insert into customer values('" + txtFname.Text + "', '" + txtEmail.Text + "','" + txtPhone.Text + "', '" + txtUsername.Text + "','" + txtZipcode.Text + "', '" + txtPwd.Text + "', '" + txtAddress.Text + "', 'Pending')");
                MessageBox.Show("Successfully Registered", "E-Shift", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message, "E-Shift", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                DB.closeConnection(); //close sql connection
            }
        }

        private void loginLbl_Click(object sender, EventArgs e)
        {
            this.Hide(); //close this form
            frmcCustomer_login frmLogin = new frmcCustomer_login(); //create object for customer login form
            frmLogin.Show(); //open customer login form
        }
    }
}
