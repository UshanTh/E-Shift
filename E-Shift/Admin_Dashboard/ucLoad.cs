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
    public partial class ucLoad : UserControl
    {
        DBase_Cls DB = new DBase_Cls();
        DataGridViewRow row;
        int index;

        public ucLoad()
        {
            InitializeComponent();
        }

        private void loadtble_load() //load datagrid view
        {
            try
            {
                DB.openConnection(); //open sql connection
                DB.showRecords("SELECT * from load", "load"); //search records in the load table
                dgvLoad_tbl.DataSource = DB.ds.Tables[0]; //show record in datagrid view
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

        private void job_Product_tble_load() //load datagrid view
        {
            try
            {
                DB.openConnection(); //open sql connection
                DB.showRecords("SELECT * from job_product", "job_product"); //search records in the load table
                dgvjob_Product_load.DataSource = DB.ds.Tables[0]; //show record in datagrid view
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
            if (txtUnit_ID.Text == "" || cmbLoad_status.Text == "")
            {
                MessageBox.Show("Please Enter All Texboxes", "E-Shift", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    DB.openConnection(); //open sql connection
                    //insert record to load table
                    DB.queryingRecord("insert into load values('"+txtLoad_id.Text +"','" + cmbLoad_status.Text + "', '" + txtDesc.Text + "','" + txtJob_ID.Text + "', '"+txtUnit_ID.Text+"')");
                    //showing message box
                    MessageBox.Show("Added Successfully", "E-Shift", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //update job status in job table
                    DB.queryingRecord("update JOB set Job_Status = '" + cmbLoad_status.Text + "' where Job_ID = '"+txtJob_ID.Text+"'");
                    MessageBox.Show("Job Status updated", "E-Shift", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clear_Textbox();//invoke clear textbox method
                    loadtble_load(); //invoke refresh load table
                    job_Product_tble_load();//invoke refresh job_Prodcut_load table
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            //check all fileds are fill
            if (txtLoad_id.Text == "")
            {
                //if not show a warning message
                MessageBox.Show("Please Enter Load Id To search", "E-Shift", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    DB.openConnection(); //open sql connection
                    //update record in load table
                    DB.queryingRecord("update load set Load_Status= '" + cmbLoad_status.Text + "', Description = '"+txtDesc.Text+"' where load_ID = '" + txtLoad_id.Text + "'");
                    //update job status after assing job id
                    DB.queryingRecord("update JOB set Job_Status='" + cmbLoad_status.Text + "' where Job_ID = '" + txtJob_ID.Text + "'");
                    //showing message box
                    MessageBox.Show("Job status Updated", "E-Shift", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clear_Textbox();//invoke clear textbox method
                    //updateJob_status();
                    loadtble_load(); //invoke refresh datagrid view method
                    job_Product_tble_load();//invoke refresh job_Prodcut_load table
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

        private void ucLoad_Load(object sender, EventArgs e)
        {
            loadtble_load(); //incoke load job table load
            job_Product_tble_load();//invoke refresh job_Prodcut_load table
        }

        private void dgvLoad_tbl_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DB.openConnection();
                //get values to textbox
                index = e.RowIndex;
                row = dgvLoad_tbl.Rows[index];
                txtLoad_id.Text = row.Cells[0].Value.ToString();
                cmbLoad_status.Text = row.Cells[1].Value.ToString();
                txtDesc.Text = row.Cells[2].Value.ToString();
                txtJob_ID.Text = row.Cells[3].Value.ToString();
                txtUnit_ID.Text = row.Cells[4].Value.ToString();
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //check all fileds are fill
            if (txtLoad_id.Text == "")
            {
                //if not show a warning message
                MessageBox.Show("Please Enter Load Id To search", "E-Shift", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else //if all details are filled
            {
                try
                {
                    DB.openConnection();
                    //search record in load table using load id
                    System.Data.SqlClient.SqlDataReader dr = DB.readRecord("Select * from load where load_ID='" + txtLoad_id.Text + "'");
                    while (dr.Read())
                    {
                        cmbLoad_status.Text = dr[1].ToString();
                        txtDesc.Text = dr[2].ToString();
                        txtJob_ID.Text = dr[3].ToString();
                        txtUnit_ID.Text = dr[4].ToString();
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

        private void clear_Textbox() //clear textboxes method
        {
            txtLoad_id.ResetText();
            txtDesc.ResetText();
            txtJob_ID.ResetText();
            txtUnit_ID.ResetText();
            cmbLoad_status.SelectedIndex = -1;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear_Textbox(); //invoke clear textbox
        }

        private void txtJob_ID_MouseLeave(object sender, EventArgs e)
        {
            try
            {
                DB.openConnection();
                //search relevent record in customer table using customer id
                System.Data.SqlClient.SqlDataReader dr = DB.readRecord("Select * from JOB where Job_ID='" + txtJob_ID.Text + "'");
                while (dr.Read())
                {
                    //display customer name 
                    txtUnit_ID.Text = dr[9].ToString();
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
