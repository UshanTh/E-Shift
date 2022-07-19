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
    public partial class ucAssistant : UserControl
    {
        DBase_Cls DB = new DBase_Cls();

        public ucAssistant()
        {
            InitializeComponent();
        }

        private void clear_Textbox()
        {
            txtAid.ResetText();
            txtFname.ResetText();
            txtEmail.ResetText();
            txtAddress.ResetText();
            txtPhone.ResetText();
            txtUnitID.ResetText();
        }

        private void assistant_load() //load Driver table records
        {
            try
            {
                DB.openConnection(); //open sql connection
                DB.showRecords("SELECT * from Assistant", "Assistant"); //search records in the Assistant table
                dgvAssistant.DataSource = DB.ds.Tables[0]; //show record in datagrid view
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
            if (txtFname.Text == "" || txtEmail.Text == "" || txtPhone.Text == "" || txtAddress.Text == "" || txtUnitID.Text == "")
            {
                MessageBox.Show("Please Enter All Details", "E-Shift", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    DB.openConnection(); //open sql connection
                    //insert record to Assistant table
                    DB.queryingRecord("insert into Assistant values('" + txtFname.Text + "','" + txtEmail.Text + "', '" + txtPhone.Text + "', '" + txtAddress.Text + "', '"+txtUnitID.Text+"')");
                    //showing message box
                    MessageBox.Show("Added Successfully", "E-Shift", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clear_Textbox();//invoke clear textbox method
                    assistant_load();//invoke refresh assistant table
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

        private void ucAssistant_Load(object sender, EventArgs e)
        {
            assistant_load();//invoke refresh assistant table
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear_Textbox();//invoke clear textbox method
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(txtAid.Text == "")
            {
                MessageBox.Show("Please Enter Assistant ID", "E-Shift", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    DB.openConnection();
                    DB.queryingRecord("update Assistant set FullName='" + txtFname.Text + "',Email='" + txtEmail.Text + "', TellNo='" + txtPhone.Text + "', A_Address='" + txtAddress.Text + "' where Assistant_ID = '" + txtAid.Text + "'");
                    MessageBox.Show("Successfully Updated", "E-Shift", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    assistant_load();//invoke refresh assistant table
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtAid.Text == "")
            {
                MessageBox.Show("Please Enter Assistant ID", "E-Shift", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    DB.openConnection(); //open sql connection
                    //delete record in driver table
                    DB.queryingRecord("Delete from Assistant where Assistant_ID='" + txtAid.Text + "'");
                    //showing message box
                    MessageBox.Show("Delete Successfully", "E-Shift", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clear_Textbox();//invoke clear textbox method
                    assistant_load();//invoke refresh Assistant table
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

        private void btnFInd_Click(object sender, EventArgs e)
        {
            if (txtAid.Text == "")
            {
                MessageBox.Show("Please enter Assistant id", "E-Shift", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    DB.openConnection();
                    //search record in customer table using customer username
                    System.Data.SqlClient.SqlDataReader dr = DB.readRecord("Select * from Assistant where Assistant_ID='" + txtAid.Text + "'");
                    while (dr.Read())
                    {
                        txtFname.Text = dr[1].ToString();
                        txtEmail.Text = dr[2].ToString();
                        txtPhone.Text = dr[3].ToString();
                        txtAddress.Text = dr[4].ToString();
                        txtUnitID.Text = dr[5].ToString();
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
}
