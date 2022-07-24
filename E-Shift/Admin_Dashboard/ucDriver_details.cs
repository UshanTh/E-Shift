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
    public partial class ucDriver_details : UserControl
    {
        DBase_Cls DB = new DBase_Cls();

        public ucDriver_details()
        {
            InitializeComponent();
        }

        private void clear_Textbox()
        {
            txtLID.ResetText();
            txtFname.ResetText();
            txtEmail.ResetText();
            txtDID.ResetText();
            txtAddress.ResetText();
            txtPhone.ResetText();
            cmbStatus.SelectedIndex = -1;
            txtUnitid.ResetText();
        }

        private void driver_load() //load Driver table records
        {
            try
            {
                DB.openConnection(); //open sql connection
                DB.showRecords("SELECT Driver.Driver_ID,Driver.Unit_ID, Driver.FullName,Driver.Email,Driver.TellNo,Driver.D_Status,Driver.D_Address,Driver.lorry_ID,Lorry.Cont_ID FROM Driver INNER JOIN Lorry ON Driver.lorry_ID = Lorry.lorry_ID", "Driver"); //search records in the lorry table
                dgvDriver.DataSource = DB.ds.Tables[0]; //show record in datagrid view
            }
            catch (Exception ex)
            {
                //display error message
                MessageBox.Show("Error : " + ex.Message, "E-Shift", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                DB.closeConnection(); //close connection
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtFname.Text == "" || txtEmail.Text == "" || txtPhone.Text == "" || txtAddress.Text == "" || cmbStatus.Text == "" || txtUnitid.Text == "")
            {
                MessageBox.Show("Please Enter All Details", "E-Shift", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    DB.openConnection(); //open sql connection
                    //insert record to driver table
                    DB.queryingRecord("insert into Driver values('" + txtFname.Text + "','" + txtEmail.Text + "', '"+txtPhone.Text+"', '"+cmbStatus.Text+"','"+txtAddress.Text+"','"+txtLID.Text+"', '"+txtUnitid.Text+"')");
                    //showing message box
                    MessageBox.Show("Added Successfully", "E-Shift", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clear_Textbox();//invoke clear textbox method
                    driver_load();//invoke refresh driver table
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtDID.Text == "")
            {
                MessageBox.Show("Please Enter Driver ID", "E-Shift", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    DB.openConnection(); //open sql connection
                    //delete record in driver table
                    DB.queryingRecord("Delete from Driver where Driver_ID='" + txtDID.Text + "'");
                    //showing message box
                    MessageBox.Show("Delete Successfully", "E-Shift", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clear_Textbox();//invoke clear textbox method
                    driver_load();//invoke refresh lorry table
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

        private void ucDriver_details_Load(object sender, EventArgs e)
        {
            driver_load();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                DB.openConnection();
                DB.queryingRecord("update Driver set FullName='" + txtFname.Text + "',Email='" + txtEmail.Text + "', TellNo='" + txtPhone.Text + "',D_Status='" + cmbStatus.Text + "', D_Address='" + txtAddress.Text + "' where Driver_ID = '" + txtDID.Text + "'");
                MessageBox.Show("Successfully Updated", "E-Shift", MessageBoxButtons.OK, MessageBoxIcon.Information);
                driver_load();
                clear_Textbox();
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

        private void btnFInd_Click(object sender, EventArgs e)
        {
            if(txtDID.Text == "")
            {
                MessageBox.Show("Please enter driver id", "E-Shift", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    DB.openConnection();
                    //search record in customer table using customer username
                    System.Data.SqlClient.SqlDataReader dr = DB.readRecord("Select * from Driver where Driver_ID='" + txtDID.Text + "'");
                    while (dr.Read())
                    {
                        txtFname.Text = dr[1].ToString();
                        txtEmail.Text = dr[2].ToString();
                        txtPhone.Text = dr[3].ToString();
                        cmbStatus.Text = dr[4].ToString();
                        txtAddress.Text = dr[5].ToString();
                        txtLID.Text = dr[6].ToString();
                        txtUnitid.Text = dr[7].ToString();
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear_Textbox();
        }
    }
}
