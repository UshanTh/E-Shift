using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Shift.Cus_Dashboard
{
    public partial class ucJobs : UserControl
    {
        DBase_Cls DB = new DBase_Cls();
        string Usrname;

        public ucJobs(string username)
        {
            InitializeComponent();
            Usrname = username;
            
        }

        private void myJobs_load() //load jobs table records
        {
            try
            {
                DB.openConnection(); //open sql connection
                //search records in the job table
                DB.showRecords("SELECT JOB.Job_ID,JOB.Start_Date,JOB.End_Date,JOB.Start_Time,JOB.End_Time, JOB.Start_location, JOB.End_location,JOB.Job_Status, JOB.Cus_ID, Customer.Cus_Username FROM JOB INNER JOIN Customer ON JOB.Cus_ID = Customer.Cus_ID where Customer.Cus_Username = '"+ Usrname + "'", "JOB"); 
                dgvJobs.DataSource = DB.ds.Tables[0]; //show record in datagrid view
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

        private void ucJobs_Load(object sender, EventArgs e)
        {
            myJobs_load();
        }
    }
}
