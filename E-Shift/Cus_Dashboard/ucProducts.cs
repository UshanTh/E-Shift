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
    public partial class ucProducts : UserControl
    {
        DBase_Cls DB = new DBase_Cls();
        string Usrname;

        public ucProducts(string username)
        {
            InitializeComponent();
            Usrname = username;
        }

        private void myProducts_load() //load products table records
        {
            try
            {
                DB.openConnection(); //open sql connection
                //search records in the job table
                DB.showRecords("SELECT Products.Pro_ID, Products.Pro_name,Products.Pro_type, Products.Pro_desc FROM Products INNER JOIN Customer ON Products.Cus_ID = Customer.Cus_ID where Customer.Cus_Username = '" + Usrname + "'", "Products");
                dgvProducts.DataSource = DB.ds.Tables[0]; //show record in datagrid view
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
            myProducts_load(); //load products table records
        }
    }
}
