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
    public partial class ucJob_details : UserControl
    {
        DBase_Cls DB = new DBase_Cls();
        int index;
        DataGridViewRow row;
        string end_Time = DateTime.Now.ToString("00:00 tt");

        public ucJob_details()
        {
            InitializeComponent();
        }

        private void jobTblaod() //load job details
        {
            try
            {
                DB.openConnection(); //open sql connection
                //search records in the JOB table
                DB.showRecords("SELECT JOB.Job_ID,JOB.Start_Date,JOB.End_Date,JOB.Start_Time,JOB.End_Time, JOB.Start_location, JOB.End_location,JOB.Job_Status, JOB.Cus_ID, Customer.Cus_FullName, Customer.Cus_Status FROM JOB INNER JOIN Customer ON JOB.Cus_ID=Customer.Cus_ID", "JOB"); 
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

        private void ucJob_details_Load(object sender, EventArgs e)
        {
            jobTblaod();
        }

        private void clear_Textbox() //clear textboxes method
        {
            txtUsr_id.ResetText();
            txtId.ResetText();
            txtCus_Name.ResetText();
            txtCus_status.ResetText();
            dtpStrtdate.ResetText();
            dtpEnddate.ResetText();
            dtpStartime.ResetText();
            dtpEndtime.ResetText();
            txtStart_location.ResetText();
            txtEnd_location.ResetText();
            cmbJob_status.SelectedIndex = -1;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //check all fileds are fill
            if (txtUsr_id.Text == "" || txtStart_location.Text == "" || txtEnd_location.Text == "" || dtpStrtdate.Text == "" || dtpEnddate.Text == "" || cmbJob_status.Text == "" || dtpStartime.Text == "" || dtpEndtime.Text == "")
            {
                //if not show a warning message
                MessageBox.Show("Please Enter All Fileds", "E-Shift", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtCus_status.Text == "Pending")
            {
                MessageBox.Show("Please Approve This Customer First", "E-Shift", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else //if all details are filled
            {
                try
                {
                    DB.openConnection(); //open sql connection
                    //insert record to database
                    DB.queryingRecord("insert into JOB values('" + dtpStrtdate.Value.ToString("yyyy-MM-dd") + "','" + dtpEnddate.Value.ToString("yyyy-MM-dd") + "', '" +dtpStartime.Value.ToString("h:mm tt") + "','" + dtpEndtime.Value.ToString("h:mm tt") + "','" + txtStart_location.Text + "', '"+txtEnd_location.Text+"', '"+cmbJob_status.Text+ "', '" + txtUsr_id.Text + "')");
                    //showing message box
                    MessageBox.Show("Successfully Registered.. Please Add product..!", "E-Shift", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    clear_Textbox();//invoke clear textbox method
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

        private void txtUsr_id_Leave(object sender, EventArgs e)
        {
            try
            {
                DB.openConnection();
                //search relevent record in customer table using customer id
                System.Data.SqlClient.SqlDataReader dr = DB.readRecord("Select * from customer where Cus_ID='" + txtUsr_id.Text + "'");
                while (dr.Read())
                {
                    //display customer name 
                    txtCus_Name.Text = dr[1].ToString();
                    txtCus_status.Text = dr[8].ToString();
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

        private void dgvJob_tbl_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DB.openConnection();
                //get values to textbox
                index = e.RowIndex;
                row = dgvJob_tbl.Rows[index];
                txtId.Text = row.Cells[0].Value.ToString();
                dtpStrtdate.Text = row.Cells["Start_Date"].Value.ToString();
                dtpEnddate.Text = row.Cells["End_Date"].Value.ToString();
                dtpStartime.Text = row.Cells["Start_Time"].Value.ToString();
                dtpEndtime.Text = row.Cells["End_Time"].Value.ToString();
                txtStart_location.Text = row.Cells[5].Value.ToString();
                txtEnd_location.Text = row.Cells[6].Value.ToString();
                cmbJob_status.Text = row.Cells["Job_Status"].Value.ToString();
                txtUsr_id.Text = row.Cells[8].Value.ToString();
                txtCus_Name.Text = row.Cells["Cus_FullName"].Value.ToString();
                txtCus_status.Text = row.Cells["Cus_Status"].Value.ToString();
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear_Textbox(); //invoke clear textbox method
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                DB.openConnection();
                DB.queryingRecord("update JOB set Start_Date='" + dtpStrtdate.Value.ToString("yyyy-MM-dd") + "',End_Date='" + dtpEnddate.Value.ToString("yyyy-MM-dd") + "', Start_Time='" + dtpStartime.Value.ToShortTimeString() + "',End_Time='" + dtpEndtime.Value.ToShortTimeString() + "',Start_location = '"+txtStart_location.Text+ "',End_location = '"+txtEnd_location.Text+ "',Job_Status ='"+cmbJob_status.Text+ "'  where Job_ID = '" + txtId.Text + "'");
                MessageBox.Show("Successfully Updated", "E-Shift", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (cmbSearchBy.Text == "") //if search by null 
            {
                //then show error message
                MessageBox.Show("Please Select ID", "E-Shift", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (cmbSearchBy.Text == "Customer ID") //else if search by equal to customer id
            {
                //then show Jobs relevent customer id
                try
                {
                    DB.openConnection(); //open sql connection
                    //search records in the JOB table using customer ID
                    DB.showRecords("SELECT JOB.Job_ID,JOB.Start_Date,JOB.End_Date,JOB.Start_Time,JOB.End_Time, JOB.Start_location, JOB.End_location,JOB.Job_Status, JOB.Cus_ID, Customer.Cus_FullName, Customer.Cus_Status FROM JOB INNER JOIN Customer ON JOB.Cus_ID=Customer.Cus_ID where JOB.Cus_ID = '" + txtId.Text + "'", "JOB"); 
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
            else if (cmbSearchBy.Text == "JOB ID") //else if search by equal to prodcut id
            {
                //then show product relevent product id
                try
                {
                    DB.openConnection(); //open sql connection
                    //search records in the JOB table using job ID
                    DB.showRecords("SELECT JOB.Job_ID,JOB.Start_Date,JOB.End_Date,JOB.Start_Time,JOB.End_Time, JOB.Start_location, JOB.End_location,JOB.Job_Status, JOB.Cus_ID, Customer.Cus_FullName, Customer.Cus_Status FROM JOB INNER JOIN Customer ON JOB.Cus_ID=Customer.Cus_ID where JOB.Job_ID = '" + txtId.Text + "'", "JOB"); 
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
            else
            {
                MessageBox.Show("No Records Found", "E-Shift", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
