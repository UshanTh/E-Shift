using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace E_Shift.Cus_Dashboard
{
    public partial class ucCus_profile : UserControl
    {
        DBase_Cls DB = new DBase_Cls();

        public ucCus_profile(string username)
        {
            InitializeComponent();
            txtUsername.Text = username;
        }

        private void ucCus_profile_Load(object sender, EventArgs e)
        {
            try
            {
                DB.openConnection();
                //search record in customer table using customer username
                System.Data.SqlClient.SqlDataReader dr = DB.readRecord("Select * from customer where Cus_Username='" + txtUsername.Text + "'");
                while (dr.Read())
                {
                    txtUsr_id.Text = dr[0].ToString();
                    txtFullname.Text = dr[1].ToString();
                    txtEmail.Text = dr[2].ToString();
                    txtPhone.Text = dr[3].ToString();
                    txtUsername.Text = dr[4].ToString();
                    txtZipcode.Text = dr[5].ToString();
                    txtPwd.Text = dr[6].ToString();
                    txtConfirmpwd.Text = dr[6].ToString();
                    txtAddress.Text = dr[7].ToString();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message, "E-Shift",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                DB.closeConnection();
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            DB.password = txtPwd.Text;
            DB.confirm_Password = txtConfirmpwd.Text;

            //check any blank fileds 
            if (txtFullname.Text == "" || txtEmail.Text == "" || txtPhone.Text == "" || txtUsername.Text == "" || txtZipcode.Text == "" || txtPwd.Text == "" || txtConfirmpwd.Text == "" || txtAddress.Text == "")
            {
                //show message
                MessageBox.Show("Please enter all fields", "E-Shift", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (DB.password != DB.confirm_Password) //Check if passwords are not equal
                {
                    //then showing error message
                    MessageBox.Show("Password Not Match", "E-Shift", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    try
                    {
                        DB.openConnection();
                        DB.queryingRecord("update customer set Cus_FullName='" + txtFullname.Text + "',Cus_Email='" + txtEmail.Text + "', Cus_TellNo='" + txtPhone.Text + "',Cus_Zipcode='" + txtZipcode.Text + "',Cus_Password='" + txtPwd.Text + "', Cus_Address='" + txtAddress.Text + "' where Cus_Username = '" + txtUsername.Text + "'");
                        MessageBox.Show("Successfully Updated", "Ayubo Drive", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        //show error message with exception
                        MessageBox.Show("Error : " + ex.Message, "E-Shift", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    finally
                    {
                        DB.closeConnection();
                    }
                }
            }              
        }

        private void txtEmail_Leave(object sender, EventArgs e)
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
    }
}
