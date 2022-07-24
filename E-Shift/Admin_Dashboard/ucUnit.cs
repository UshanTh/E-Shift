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
    public partial class ucUnit : UserControl
    {
        DBase_Cls DB = new DBase_Cls();
        int index;
        DataGridViewRow row;
        public ucUnit()
        {
            InitializeComponent();
        }

        private void clear_Textbox()
        {
            txtUnit_id.ResetText();
            cmbUnit_status.SelectedIndex = -1;
            txtDesc.ResetText();
            //txtJOBid.ResetText();
        }
        private void unitTblaod() //load job details
        {
            try
            {
                DB.openConnection(); //open sql connection
                //search records in the JOB table
                DB.showRecords("SELECT * from transport_Unit", "transport_Unit");
                dgvJob_tbl.DataSource = DB.ds.Tables[0]; //show record in datagrid view
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

        private void btnAssign_Click(object sender, EventArgs e)
        {
            if (txtUnit_id.Text == "" || cmbUnit_status.Text == "")
            {
                MessageBox.Show("Please Enter All Texboxes", "E-Shift", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    DB.openConnection(); //open sql connection
                    //insert record to unit table
                    DB.queryingRecord("insert into transport_Unit values('" + txtUnit_id.Text + "','" + cmbUnit_status.Text + "', '" + txtDesc.Text + "')");
                    //showing message box
                    MessageBox.Show("Added Successfully", "E-Shift", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clear_Textbox();//invoke clear textbox method
                    unitTblaod(); //invoke refresh datagrid view method
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

        private void ucUnit_Load(object sender, EventArgs e)
        {
           unitTblaod();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtUnit_id.Text == "")
            {
                MessageBox.Show("Please enter All fields", "E-Shift", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    DB.openConnection();
                    DB.queryingRecord("update transport_Unit set Unit_Status='" + cmbUnit_status.Text + "',Description='" + txtDesc.Text + "'where Unit_ID= '" + txtUnit_id.Text + "'");
                    MessageBox.Show("Successfully Updated", "E-Shift", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    unitTblaod(); //refresh after update the table
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

        private void dgvJob_tbl_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DB.openConnection();
                //get values to textbox
                index = e.RowIndex;
                row = dgvJob_tbl.Rows[index];
                txtUnit_id.Text = row.Cells["Unit_ID"].Value.ToString();
                cmbUnit_status.Text = row.Cells["Unit_Status"].Value.ToString();
                txtDesc.Text = row.Cells["Description"].Value.ToString();
                //txtJOBid.Text = row.Cells["Job_ID"].Value.ToString();
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

        private void btnUnit_Details_Click(object sender, EventArgs e)
        {

        }

        private void btnUnit_Details_Click_1(object sender, EventArgs e)
        {
            frmUnit_Details frm_Unit = new frmUnit_Details();
            frm_Unit.Show();
        }
    }
}
