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
    public partial class ucCustomer_Dashboard : UserControl
    {
        DBase_Cls DB = new DBase_Cls();
        string Usrname;

        public ucCustomer_Dashboard(string username)
        {
            InitializeComponent();
            Usrname = username ;
        }

        private void ucCustomer_Dashboard_Load(object sender, EventArgs e)
        {
            try
            {
                DB.openConnection(); //open sql connection
                DB.showRecords("SELECT COUNT(Customer.Cus_Username) FROM JOB INNER JOIN Customer ON JOB.Cus_ID=Customer.Cus_ID where Customer.Cus_Username ='" + Usrname + "'", "JOB"); //search records in the product table
                lbljobs_Count.Text = DB.Dtable.Rows.Count.ToString(); //show record in datagrid view
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

            //try
            //{
            //    DB.openConnection();
            //    //then check his username and password
            //    DB.login("SELECT COUNT(Customer.Cus_Username) FROM JOB INNER JOIN Customer ON JOB.Cus_ID=Customer.Cus_ID where Customer.Cus_Username ='" + Usrname + "'");
            //    lbljobs_Count.Text = DB.Dtable.Rows.Count.ToString();
            //}
            //catch (Exception ex) //catch error in database 
            //{
            //    //show the error message
            //    MessageBox.Show("Error : " + ex.Message, "E-Shift", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            //finally
            //{
            //    DB.closeConnection(); // close sql connection
            //}
        }
    }
}
