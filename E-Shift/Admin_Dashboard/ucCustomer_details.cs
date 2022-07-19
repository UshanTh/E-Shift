using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace E_Shift.Admin_Dashboard
{
    public partial class ucCustomer_details : UserControl
    {
        DBase_Cls DB = new DBase_Cls();
        DataGridViewRow row;
        int index;
        string email;
        static bool mailSent = false;
        //private frmCustomer_report cus_Report;

        public ucCustomer_details()
        {
            InitializeComponent();
        }

        private void Customer_Tblaod() //load customer details
        {
            try
            {
                DB.openConnection(); //open sql connection
                //search records in the customer table
                DB.showRecords("SELECT * From customer", "customer");
                dgvCustomerTbl.DataSource = DB.ds.Tables[0]; //show record in datagrid view
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

        private void ucCustomer_details_Load(object sender, EventArgs e)
        {
            Customer_Tblaod(); //invoke customer table load method
        }

        private void txtFname_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DB.openConnection(); //open sql connection
                //search records in the customer table using customer name
                DB.showRecords("select * from customer where Cus_FullName like '%" + txtFname.Text + "%'", "customer");
                dgvCustomerTbl.DataSource = DB.ds.Tables[0]; //show record in datagrid view
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

        private void dgvCustomerTbl_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DB.openConnection();
                //get values to textbox
                index = e.RowIndex;
                row = dgvCustomerTbl.Rows[index];
                txtCus_ID.Text = row.Cells["Cus_ID"].Value.ToString();
                email = row.Cells["Cus_Email"].Value.ToString();
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtCus_ID.Text == "")
            {
                MessageBox.Show("Please Enter Customer id ", "E-Shift", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    DB.openConnection();
                    DB.queryingRecord("update customer set Cus_Status= '" + cmbCus_Status.Text + "' where Cus_ID = '"+txtCus_ID.Text+"'");
                    MessageBox.Show("Update Successfully ", "E-Shift", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Customer_Tblaod(); //invoke customer table load method
                    //clear textbox after update
                    cmbCus_Status.SelectedValue = -1;
                    txtCus_ID.ResetText();
                    txtFname.ResetText();
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

        private void btnReport_Click(object sender, EventArgs e)
        {
            frmcustomer_Info fcus_btnReport = new frmcustomer_Info();
            fcus_btnReport.Show();
        }
    }
}
