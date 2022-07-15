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

        public ucUnit()
        {
            InitializeComponent();
        }

        private void jobTblaod() //load job details
        {
            try
            {
                DB.openConnection(); //open sql connection
                //search records in the JOB table
                DB.showRecords("SELECT * from JOB where Job_Status = 'Approved'", "JOB");
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

        private void updateJob_status()
        {
            try
            {
                DB.openConnection(); //open sql connection
                //update job status 
                DB.queryingRecord("update JOB set Job_Status='" + cmbUnit_status.Text + "'");
                //showing message box
                MessageBox.Show("Job Status Updated", "E-Shift", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        private void btnAssign_Click(object sender, EventArgs e)
        {
            if(txtJobId.Text == "" || cmbUnit_status.Text == "" )
            {
                MessageBox.Show("Please Enter All Texboxes", "E-Shift", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    DB.openConnection(); //open sql connection
                    //insert record to unit table
                    DB.queryingRecord("insert into transport_Unit values('" + cmbUnit_status.Text + "', '" + txtDesc.Text + "','" + txtJobId.Text + "')");
                    //update job status after assing job id
                    DB.queryingRecord("update JOB set Job_Status='" + cmbUnit_status.Text + "'");
                    //showing message box
                    MessageBox.Show("Assigned Successfully", "E-Shift", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //clear_Textbox();//invoke clear textbox method
                    updateJob_status();
                    jobTblaod(); //invoke refresh datagrid view method
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
            jobTblaod();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                DB.openConnection();
                DB.queryingRecord("update transport_Unit set Unit_Status='" + cmbUnit_status.Text + "',Description='" + txtDesc.Text + "'");
                MessageBox.Show("Successfully Updated", "E-Shift", MessageBoxButtons.OK, MessageBoxIcon.Information);
                updateJob_status(); //invoke job status method
                jobTblaod(); //refresh after update the table
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
