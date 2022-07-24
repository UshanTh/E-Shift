using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace E_Shift.Cus_Dashboard
{
    public partial class ucCustomer_Dashboard : UserControl
    {
        DBase_Cls DB = new DBase_Cls();
        string Usrname;
        SqlConnection con = new SqlConnection("Data Source = LAPTOP-9MO4U183; Initial Catalog = E_Shift; Integrated Security = True");

        public ucCustomer_Dashboard(string username)
        {
            InitializeComponent();
            Usrname = username ;
        }

        private void jobs_Count()
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT COUNT(Customer.Cus_Username) FROM JOB INNER JOIN Customer ON JOB.Cus_ID=Customer.Cus_ID where Customer.Cus_Username ='" + Usrname + "'", con);
                var count = cmd.ExecuteScalar();
                lbljobs_Count.Text = count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message, "E-Shift", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }
        
        private void proudct_Count()
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT COUNT(Customer.Cus_Username) FROM Products INNER JOIN Customer ON Products.Cus_ID=Customer.Cus_ID where Customer.Cus_Username ='" + Usrname + "'", con);
                var count = cmd.ExecuteScalar();
                lblgoods_Count.Text = count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message, "E-Shift", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }

        private void ucCustomer_Dashboard_Load(object sender, EventArgs e)
        {
            jobs_Count();
            proudct_Count();
        }
    }
}
