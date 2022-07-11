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
    public partial class ucProducts : UserControl
    {
        DBase_Cls DB = new DBase_Cls();
        int index;
        public ucProducts()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                DB.openConnection(); //open sql connection
                //insert record to database
                DB.queryingRecord("insert into Products values('" + txtProName.Text + "', '" + cmbProduct_type.Text + "','" + txtDesc.Text + "', '" + txtCustomerId.Text + "')");
                //showing message box
                MessageBox.Show("Successfully Registered", "E-Shift", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clear_Textbox(); //invoke clear textbox method
                itemlaod(); //invoke refresh datagrid view
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

        private void clear_Textbox()
        {
            txtCustomerId.ResetText();
            txtCustomername.ResetText();
            txtProName.ResetText();
            txtDesc.ResetText();
            txtID.ResetText();
        }

        private void txtCustomerId_Leave(object sender, EventArgs e)
        {
            try
            {
                DB.openConnection();
                //search relevent record in customer table using customer id
                System.Data.SqlClient.SqlDataReader dr = DB.readRecord("Select * from customer where Cus_ID='" + txtCustomerId.Text + "'");
                while (dr.Read())
                {
                    txtCustomername.Text = dr[1].ToString(); //get customer name using customer id
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

        private void itemlaod()
        {
            try
            {
                DB.openConnection(); //open sql connection
                DB.showRecords("select * from Products", "Products"); //search records in the product table
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
            if (cmbSearchBy.Text == "")
            {
                MessageBox.Show("Please Select ID", "E-Shift", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if(cmbSearchBy.Text == "Customer Id")
            {
                try
                {
                    DB.openConnection(); //open sql connection
                    DB.showRecords("select * from Products where Cus_ID = '" + txtID.Text + "'", "Products"); //search records in the product table
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
            else if(cmbSearchBy.Text == "Product Id")
            {
                try
                {
                    DB.openConnection(); //open sql connection
                    DB.showRecords("select * from Products where Pro_ID = '" + txtID.Text + "'", "Products"); //search records in the product table
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
            else
            {
                MessageBox.Show("No Records Found", "E-Shift", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                DataGridViewRow row = dgvProduct_tbl.Rows[index];
                row.Cells[0].Value = txtID.Text;
                row.Cells[1].Value = txtProName.Text;
                row.Cells[2].Value = cmbProduct_type.Text;
                row.Cells[3].Value = txtDesc.Text;
                row.Cells[4].Value = txtCustomerId.Text;   

                MessageBox.Show("Record Updated Successfully ", "E-Shift", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message, "E-Shift", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                //DB.closeConnection();
            }
        }

        private void dgvProduct_tbl_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            DataGridViewRow row = dgvProduct_tbl.Rows[index];
            txtID.Text = row.Cells[0].Value.ToString();
            txtProName.Text = row.Cells[1].Value.ToString();
            cmbProduct_type.Text = row.Cells[2].Value.ToString();
            txtDesc.Text = row.Cells[3].Value.ToString();
            txtCustomerId.Text = row.Cells[4].Value.ToString();

        }
    }
} 
