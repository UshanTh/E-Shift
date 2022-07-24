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
    public partial class ucLorry : UserControl
    {
        DBase_Cls DB = new DBase_Cls();

        public ucLorry()
        {
            InitializeComponent();
        }

        private void lorry_load() //load lorry table records
        {
            try
            {
                DB.openConnection(); //open sql connection
                DB.showRecords("SELECT * from Lorry", "Lorry"); //search records in the lorry table
                dgvLorry.DataSource = DB.ds.Tables[0]; //show record in datagrid view
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

        private void Container_load() //load lorry table records
        {
            try
            {
                DB.openConnection(); //open sql connection
                DB.showRecords("SELECT * from Container", "Container"); //search records in the lorry table
                dgvContainer.DataSource = DB.ds.Tables[0]; //show record in datagrid view
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtLid.Text == "" || txtLorryPlate.Text == "" || txtCont_Id.Text == "" || cmbCapacity.Text == "" || txtUnitid.Text == "")
            {
                MessageBox.Show("Please Enter All Texboxes", "E-Shift", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    DB.openConnection(); //open sql connection
                    //insert record to Container table
                    DB.queryingRecord("insert into Container values('" + txtCont_Id.Text + "','" + cmbCapacity.Text + "', '"+txtUnitid.Text+"')");
                    //insert record to Lorry table
                    DB.queryingRecord("insert into Lorry values('" + txtLid.Text + "','" + txtLorryPlate.Text + "', '" + txtCont_Id.Text + "', '" + txtUnitid.Text + "')");
                    //showing message box
                    MessageBox.Show("Added Successfully", "E-Shift", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    clear_Textbox();//invoke clear textbox method
                    Container_load(); //invoke refresh container table
                    lorry_load();//invoke refresh lorry table
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
            txtCont_Id.ResetText();
            txtLid.ResetText();
            txtLorryPlate.ResetText();
            cmbCapacity.SelectedIndex = -1;
            txtUnitid.ResetText();
        }

        private void ucLorry_Load(object sender, EventArgs e)
        {
            Container_load(); //invoke refresh container table
            lorry_load();//invoke refresh lorry table
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtLid.Text == "" || txtCont_Id.Text == "" )
            {
                MessageBox.Show("Please Enter Lorry ID & Container ID", "E-Shift", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    DB.openConnection(); //open sql connection
                    //delete record in lorry table
                    DB.queryingRecord("Delete from Lorry where lorry_ID='" + txtLid.Text + "'");
                    //delete record in Container table
                    DB.queryingRecord("Delete from Container where Cont_ID='" + txtCont_Id.Text + "'");
                    //showing message box
                    MessageBox.Show("Delete Successfully", "E-Shift", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    clear_Textbox();//invoke clear textbox method
                    Container_load(); //invoke refresh container table
                    lorry_load();//invoke refresh lorry table
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtLid.Text == "") //if search by null 
            {
                //then show error message
                MessageBox.Show("Please Enter Lorry ID", "E-Shift", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    DB.openConnection();
                    //search record in lorry table using lorry id
                    System.Data.SqlClient.SqlDataReader dr = DB.readRecord("SELECT Lorry.lorry_ID,Lorry.Lorry_PlateNo,Lorry.Cont_ID,Lorry.Unit_ID, Container.Cont_capacity FROM Lorry INNER JOIN Container ON Lorry.Cont_ID = Container.Cont_ID where Lorry.lorry_ID = '" + txtLid.Text + "'");
                    while (dr.Read())
                    {
                        txtLorryPlate.Text = dr[1].ToString();
                        txtCont_Id.Text = dr[2].ToString();
                        txtUnitid.Text = dr[3].ToString();
                        cmbCapacity.Text = dr[4].ToString();            
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear_Textbox();//invoke clear textbox method
        }
    }
}
