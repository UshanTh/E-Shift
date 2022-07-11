using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

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
            DB.password = txtPwd.Text;
            DB.confirm_Password = txtConfirmpwd.Text;
            
            //check any blank fileds 
            if (txtFname.Text == "" && txtLname.Text == "" || txtEmail.Text == "" || txtPhone.Text == "" || txtUsername.Text == "" || txtZipcode.Text == "" || txtPwd.Text == "" || txtConfirmpwd.Text == "" || txtAddress.Text == "")
            {
                //show message
                MessageBox.Show("Please enter all fields", "E-Shift", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (DB.password != DB.confirm_Password) //Check if password textboxes not equal
                {
                    //then showing error message
                    MessageBox.Show("Password Not Match", "E-Shift", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    try
                    {
                        DB.openConnection(); //open sql connection
                        //insert record to database
                        DB.queryingRecord("insert into customer values('" + (txtFname.Text + " " + txtLname.Text) + "', '" + txtEmail.Text + "','" + txtPhone.Text + "', '" + txtUsername.Text + "','" + txtZipcode.Text + "', '" + txtPwd.Text + "', '" + txtAddress.Text + "', 'Pending')");
                        //showing message box
                        MessageBox.Show("Successfully Registered", "E-Shift", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textbox_Clear(); //invoke clear textbox method
                    }
                    catch (Exception ex) //catch any exception
                    {
                        //show error message with exception
                        MessageBox.Show("Error : " + ex.Message, "E-Shift", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    finally
                    {
                        DB.closeConnection(); //close sql connection
                    }
                }
            } 
        }

        private void loginLbl_Click(object sender, EventArgs e)
        {
            this.Hide(); //close this form
            frmcCustomer_login frmLogin = new frmcCustomer_login(); //create object for customer login form
            frmLogin.Show(); //open customer login form
        }

        private void txtEmail_Leave(object sender, EventArgs e) //check email valid or not valid
        {
            string pattern = @"^((([a-z]|\d|[!#\$%&'\*\+\-\/=\?\^_`{\|}~]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])+(\.([a-z]|\d|[!#\$%&'\*\+\-\/=\?\^_`{\|}~]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])+)*)|((\x22)((((\x20|\x09)*(\x0d\x0a))?(\x20|\x09)+)?(([\x01-\x08\x0b\x0c\x0e-\x1f\x7f]|\x21|[\x23-\x5b]|[\x5d-\x7e]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])|(\\([\x01-\x09\x0b\x0c\x0d-\x7f]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF]))))*(((\x20|\x09)*(\x0d\x0a))?(\x20|\x09)+)?(\x22)))@((([a-z]|\d|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])|(([a-z]|\d|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])([a-z]|\d|-|\.|_|~|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])*([a-z]|\d|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])))\.)+(([a-z]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])|(([a-z]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])([a-z]|\d|-|\.|_|~|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])*([a-z]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])))\.?$";
            if (Regex.IsMatch(txtEmail.Text, pattern)) //check email match the pattern
            {
                errorProvider1.Clear(); // clear error provider
            }
            else
            {
                errorProvider1.SetError(this.txtEmail, "Please enter valid email"); //not valid then show error message
                txtEmail.Text = ""; //after clear email textbox for retype email
                return;
            }
        }

        private void textbox_Clear() //clear all textbox values
        {
            txtFname.ResetText();
            txtLname.ResetText();
            txtEmail.ResetText();
            txtPhone.ResetText();
            txtPwd.ResetText();
            txtConfirmpwd.ResetText();
            txtAddress.ResetText();
            txtUsername.ResetText();
            txtZipcode.ResetText();
        }
    }
}
