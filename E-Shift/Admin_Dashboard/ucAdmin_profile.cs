using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Shift.Admin_Dashboard
{
    public partial class ucAdmin_profile : UserControl
    {
        DBase_Cls DB = new DBase_Cls();
            
        public ucAdmin_profile(string username)
        {
            InitializeComponent();
            txtUsername.Text = username;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            DB.password = txtPwd.Text;
            DB.confirm_Password = txtConfirmpwd.Text;

            //check any blank fileds 
            if (txtFullname.Text == "" || txtEmail.Text == "" || txtPhone.Text == "" || txtUsername.Text == "" || txtPwd.Text == "" || txtConfirmpwd.Text == "" || txtAddress.Text == "")
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
                        DB.queryingRecord("update Admin set Admin_FullName='" + txtFullname.Text + "',Admin_Email='" + txtEmail.Text + "', Admin_TellNo='" + txtPhone.Text + "',Admin_Password='" + txtPwd.Text + "', Admin_Address='" + txtAddress.Text + "' where Admin_Username = '" + txtUsername.Text + "'");
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

        private void ucAdmin_profile_Load(object sender, EventArgs e)
        {
            try
            {
                DB.openConnection();
                //search record in customer table using customer username
                System.Data.SqlClient.SqlDataReader dr = DB.readRecord("Select * from Admin where Admin_Username='" + txtUsername.Text + "'");
                while (dr.Read())
                {
                    txtFullname.Text = dr[1].ToString();
                    txtEmail.Text = dr[2].ToString();
                    txtPhone.Text = dr[3].ToString();
                    txtUsername.Text = dr[4].ToString();
                    txtPwd.Text = dr[5].ToString();
                    txtConfirmpwd.Text = dr[5].ToString();
                    txtAddress.Text = dr[6].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message, "E-Shift", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                DB.closeConnection();
            }
        }
    }
}
