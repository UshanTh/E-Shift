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
    public partial class frmUnit_Details : Form
    {
        DBase_Cls DB = new DBase_Cls();
        public frmUnit_Details()
        {
            InitializeComponent();
        }

        private void unitdetails_Load()
        {
            try
            {
                DB.openConnection(); //open sql connection
                //search records in the unit table
                DB.showRecords("select transport_Unit.Unit_ID, transport_Unit.Unit_Status, transport_Unit.Description, JOB.Job_ID, JOB.Job_Status, JOB.Cus_ID, Driver.Driver_ID , Driver.FullName , Assistant.Assistant_ID,Assistant.FullName, Lorry.lorry_ID, Lorry.Lorry_PlateNo ,Lorry.Cont_ID FROM transport_Unit INNER JOIN JOB ON transport_Unit.Unit_ID=JOB.Unit_ID INNER JOIN Driver ON transport_Unit.Unit_ID=Driver.Unit_ID INNER JOIN Assistant ON transport_Unit.Unit_ID=Assistant.Assistant_ID INNER JOIN Lorry ON transport_Unit.Unit_ID=Lorry.lorry_ID", "transport_Unit"); 
                dgv_Unit.DataSource = DB.ds.Tables[0]; //show record in datagrid view
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
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "")
            {
                MessageBox.Show("Please enter All fields", "E-Shift", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    DB.openConnection();
                    DB.queryingRecord("update transport_Unit set Unit_Status='" + cmbUnit_status.Text + "'where Unit_ID= '" + txtID.Text + "'");
                    MessageBox.Show("Successfully Updated", "E-Shift", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DB.queryingRecord("update JOB set Job_Status='" + cmbUnit_status.Text + "'where Job_ID= '" + txtID.Text + "'");
                    MessageBox.Show("Job Status Updated", "E-Shift", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    unitdetails_Load(); //refresh after update the table
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

        private void frmUnit_Details_Load(object sender, EventArgs e)
        {
            unitdetails_Load(); // invoke unit details method 
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (cmbSearchBy.Text == "") //if search by null 
            {
                //then show error message
                MessageBox.Show("Please Select ID", "E-Shift", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (cmbSearchBy.Text == "JOB ID") //else if search by equal to job id
            {
                //then show products relevent customer id
                try
                {
                    DB.openConnection(); //open sql connection
                    DB.showRecords("select transport_Unit.Unit_ID, transport_Unit.Unit_Status, transport_Unit.Description, JOB.Job_ID, JOB.Job_Status, JOB.Cus_ID, Driver.Driver_ID , Driver.FullName , Assistant.Assistant_ID,Assistant.FullName, Lorry.lorry_ID, Lorry.Lorry_PlateNo ,Lorry.Cont_ID FROM transport_Unit INNER JOIN JOB ON transport_Unit.Unit_ID=JOB.Job_ID INNER JOIN Driver ON transport_Unit.Unit_ID=Driver.Unit_ID INNER JOIN Assistant ON transport_Unit.Unit_ID=Assistant.Assistant_ID INNER JOIN Lorry ON transport_Unit.Unit_ID=Lorry.lorry_ID where JOB.Job_ID = '" + txtID.Text + "'", "transport_Unit");
                    dgv_Unit.DataSource = DB.ds.Tables[0]; //show record in datagrid view
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
            else if (cmbSearchBy.Text == "UNIT ID") //else if search by equal to unit id
            {
                //then show product relevent product id
                try
                {
                    DB.openConnection(); //open sql connection
                    DB.showRecords("select transport_Unit.Unit_ID, transport_Unit.Unit_Status, transport_Unit.Description, JOB.Job_ID, JOB.Job_Status, JOB.Cus_ID, Driver.Driver_ID , Driver.FullName , Assistant.Assistant_ID,Assistant.FullName, Lorry.lorry_ID, Lorry.Lorry_PlateNo ,Lorry.Cont_ID FROM transport_Unit INNER JOIN JOB ON transport_Unit.Unit_ID=JOB.Job_ID INNER JOIN Driver ON transport_Unit.Unit_ID=Driver.Unit_ID INNER JOIN Assistant ON transport_Unit.Unit_ID=Assistant.Assistant_ID INNER JOIN Lorry ON transport_Unit.Unit_ID=Lorry.lorry_ID  where transport_Unit.Unit_ID = '" + txtID.Text + "'", "transport_Unit");
                    dgv_Unit.DataSource = DB.ds.Tables[0]; //show record in datagrid view
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
