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
    public partial class ucProducts : UserControl
    {
        DBase_Cls DB = new DBase_Cls();
        int index;
        DataGridViewRow row;

        public ucProducts()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //check all fileds are fill
            if (txtCustomerId.Text == "" || txtProName.Text == "" || cmbProduct_type.Text == "")
            {
                //if not show a warning message
                MessageBox.Show("Please Enter All Fileds", "E-Shift", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else //or else all are filled
            {
                try
                {
                    DB.openConnection(); //open sql connection
                    //insert record to database
                    DB.queryingRecord("insert into Products values('" + txtProName.Text + "', '" + cmbProduct_type.Text + "','" + txtDesc.Text + "', '" + txtCustomerId.Text + "')");
                    //showing message box
                    MessageBox.Show("Successfully Registered..Please assign to Job", "E-Shift", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clear_Textbox(); //invoke clear textbox method
                    itemlaod(); //invoke refresh datagrid view
                    AssingJOBID frmassingJOB = new AssingJOBID();
                    frmassingJOB.Show();
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

        private void clear_Textbox() //clear textboxes method
        {
            txtCustomerId.ResetText();
            txtCustomername.ResetText();
            txtProName.ResetText();
            txtDesc.ResetText();
            txtID.ResetText();
            cmbProduct_type.SelectedIndex = -1;
            cmbSearchBy.SelectedIndex = -1;
        }

        //Enter customer id and then show relevent customer name
        private void txtCustomerId_Leave(object sender, EventArgs e) 
        {
            try
            {
                DB.openConnection();
                //search relevent record in customer table using customer id
                System.Data.SqlClient.SqlDataReader dr = DB.readRecord("Select * from customer where Cus_ID='" + txtCustomerId.Text + "'");
                while (dr.Read())
                {
                    //display customer name 
                    txtCustomername.Text = dr[1].ToString();
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

        private void itemlaod() //load datagrid view
        {
            try
            {
                DB.openConnection(); //open sql connection
                DB.showRecords("SELECT Products.Pro_ID,Products.Pro_name,Products.Pro_type,Products.Pro_desc, Customer.Cus_ID, Customer.Cus_FullName FROM Products INNER JOIN Customer ON Products.Cus_ID=Customer.Cus_ID;", "Products"); //search records in the product table
                dgvProduct_tbl.DataSource = DB.ds.Tables[0]; //show record in datagrid view
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

        private void ucProducts_Load(object sender, EventArgs e)
        {
            itemlaod(); //invoke item load method
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (cmbSearchBy.Text == "") //if search by null 
            {
                //then show error message
                MessageBox.Show("Please Select ID", "E-Shift", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if(cmbSearchBy.Text == "Customer Id") //else if search by equal to customer id
            {
                //then show products relevent customer id
                try
                {
                    DB.openConnection(); //open sql connection
                    DB.showRecords("SELECT Products.Pro_ID,Products.Pro_name,Products.Pro_type,Products.Pro_desc, Customer.Cus_ID, Customer.Cus_FullName FROM Products INNER JOIN Customer ON Products.Cus_ID=Customer.Cus_ID where Customer.Cus_ID = '" + txtID.Text + "'", "Products"); //search records in the product table
                    dgvProduct_tbl.DataSource = DB.ds.Tables[0]; //show record in datagrid view
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
            else if(cmbSearchBy.Text == "Product Id") //else if search by equal to prodcut id
            {
                //then show product relevent product id
                try
                {
                    DB.openConnection(); //open sql connection
                    DB.showRecords("SELECT Products.Pro_ID,Products.Pro_name,Products.Pro_type,Products.Pro_desc, Customer.Cus_ID, Customer.Cus_FullName FROM Products INNER JOIN Customer  ON Products.Cus_ID=Customer.Cus_ID  where Products.Pro_ID = '" + txtID.Text + "'", "Products"); //search records in the product table
                    dgvProduct_tbl.DataSource = DB.ds.Tables[0]; //show record in datagrid view
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear_Textbox(); //invoke clear textbox method
            itemlaod(); //invoke refresh datagridview method
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(txtID.Text == "") // if ID null
            {
                //show message please enter id
                MessageBox.Show("Please Enter Product ID", "E-Shift", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else //if not
            {
                try
                {
                    DB.openConnection();
                    //update products details using product id
                    DB.queryingRecord("update Products set Pro_name='" + txtProName.Text + "',Pro_type='" + cmbProduct_type.Text + "', Pro_desc='" + txtDesc.Text + "',Cus_ID='" + txtCustomerId.Text + "' where Pro_ID = '" + txtID.Text + "'");
                    MessageBox.Show("Successfully Updated", "E-Shift", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    itemlaod(); //refresh after update the table
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

        //datagrid view cell clieck event
        private void dgvProduct_tbl_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DB.openConnection();
                //get values to textbox
                index = e.RowIndex;
                row = dgvProduct_tbl.Rows[index];
                txtID.Text = row.Cells[0].Value.ToString();
                txtProName.Text = row.Cells[1].Value.ToString();
                cmbProduct_type.Text = row.Cells[2].Value.ToString();
                txtDesc.Text = row.Cells[3].Value.ToString();
                txtCustomerId.Text = row.Cells[4].Value.ToString();
                txtCustomername.Text = row.Cells[5].Value.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message, "E-Shift", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                DB.closeConnection();
            }
        }

        private void btnAssign_Click(object sender, EventArgs e)
        {
            AssingJOBID frmassingJOB = new AssingJOBID();
            frmassingJOB.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "") // if ID null
            {
                //show message please enter id
                MessageBox.Show("Please Enter Product ID", "E-Shift", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else //if not
            {
                try
                {
                    DB.openConnection();
                    //update products details using product id
                    DB.queryingRecord("delete from Products where Pro_ID = '" + txtID.Text + "'");
                    MessageBox.Show("Successfully Deleted", "E-Shift", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    itemlaod(); //refresh after update the table
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
} 
