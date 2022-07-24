using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Shift.Admin_Dashboard
{
    public partial class frmAll_jobs : Form
    {
        DBase_Cls DB = new DBase_Cls();

        public frmAll_jobs()
        {
            InitializeComponent();
        }

        private void jobTblaod() //load job details
        {
            try
            {
                DB.openConnection(); //open sql connection
                //search records in the JOB table
                DB.showRecords("SELECT JOB.Job_ID,JOB.Start_Date,JOB.End_Date,JOB.Start_Time,JOB.End_Time, JOB.Start_location, JOB.End_location,JOB.Job_Status, JOB.Cus_ID,JOB.Unit_ID, Customer.Cus_FullName, Customer.Cus_Status, Products.Pro_ID, Products.Pro_name, Products.Pro_type,Products.Pro_desc FROM JOB  INNER JOIN Customer ON JOB.Cus_ID=Customer.Cus_ID INNER JOIN Products ON Customer.Cus_ID=Products.Pro_ID", "JOB");
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
        private void frmAll_jobs_Load(object sender, EventArgs e)
        {
            jobTblaod();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (txt_Id.Text == "") //if search by null 
            {
                //then show error message
                MessageBox.Show("Please Select ID", "E-Shift", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //then show Jobs relevent customer id
                try
                {
                    DB.openConnection(); //open sql connection
                    //search records in the JOB table using customer ID
                    DB.showRecords("SELECT JOB.Job_ID,JOB.Start_Date,JOB.End_Date,JOB.Start_Time,JOB.End_Time, JOB.Start_location, JOB.End_location,JOB.Job_Status, JOB.Cus_ID,JOB.Unit_ID, Customer.Cus_FullName, Customer.Cus_Status, Products.Pro_ID, Products.Pro_name, Products.Pro_type,Products.Pro_desc FROM JOB  INNER JOIN Customer ON JOB.Cus_ID=Customer.Cus_ID INNER JOIN Products ON Customer.Cus_ID=Products.Pro_ID where JOB.Job_ID = '" + txt_Id.Text + "'", "JOB");
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
        }
    }
}
