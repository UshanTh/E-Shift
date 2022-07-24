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

namespace E_Shift.Admin_Dashboard
{

    public partial class ucAdmin_dashboard : UserControl
    {
        SqlConnection con = new SqlConnection("Data Source = LAPTOP-9MO4U183; Initial Catalog = E_Shift; Integrated Security = True");

        public ucAdmin_dashboard()
        {
            InitializeComponent();
        }

        private void btnLorry_Click(object sender, EventArgs e)
        {

        }

        private void proudct_Count()
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT COUNT (*) FROM Products", con);
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

        private void jobs_Count()
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT COUNT (*) FROM JOB", con);
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

        private void pending_Customer()
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT COUNT(Customer.Cus_Status) FROM Customer where Cus_Status = 'Pending' ", con);
                var count = cmd.ExecuteScalar();
                lblCustomer_count.Text = count.ToString();
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

        private void all_Customer()
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Customer", con);
                var count = cmd.ExecuteScalar();
                lblAll_customer_count.Text = count.ToString();
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

        private void lorry_Count()
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Lorry", con);
                var count = cmd.ExecuteScalar();
                lblLorry_count.Text = count.ToString();
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

        private void assistant_Count()
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Assistant", con);
                var count = cmd.ExecuteScalar();
                lblAssistant_Count.Text = count.ToString();
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


        private void ucAdmin_dashboard_Load(object sender, EventArgs e)
        {
            proudct_Count();
            jobs_Count();
            pending_Customer();
            all_Customer();
            lorry_Count();
            assistant_Count();
        }
    }
}
