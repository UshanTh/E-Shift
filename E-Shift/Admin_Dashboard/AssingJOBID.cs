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
    public partial class AssingJOBID : Form
    {
        DBase_Cls DB = new DBase_Cls();

        public AssingJOBID()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //check all fileds are fill
            if (txtJob_ID.Text == "" || txtPro_id.Text == "" )
            {
                //if not show a warning message
                MessageBox.Show("Please Enter All Fileds", "E-Shift", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else //if all details are filled
            {
                try
                {
                    DB.openConnection(); //open sql connection
                    //insert record to database
                    DB.queryingRecord("insert into job_product values('" + txtJob_ID.Text + "', '" + txtPro_id.Text + "')");
                    //showing message box
                    MessageBox.Show("Assign Registered..Please assign to Load", "E-Shift", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}
