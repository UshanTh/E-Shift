using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Shift
{
    public partial class frmcCustomer_login : Form
    {
        DBase_Cls DB = new DBase_Cls(); // Class object
        string user_Type;

        public frmcCustomer_login()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
           
        }

        //private void approved_User()
        //{
        //    try
        //    {
        //        DB.openConnection();
        //        DB.login("select customer.Cus_Username, customer.Cus_Password, customer.Cus_Status from customer where customer.Cus_Username = '" + txtUsrname.Text + "'  and customer.Cus_Password ='" + txtPwd.Text + "'  and customer.Cus_Status = '"+user_Status+"'");
        //        if (DB.Dtable.Rows.Count == 1) //when query find the matched username and password
        //        {
        //            MessageBox.Show("Welcome to E-Shift", "E-Shift", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        }
        //        else
        //        {
        //            MessageBox.Show("Incorrect Password and username", "E-Shift", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Error : " + ex.Message, "E-Shift", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //    finally
        //    {
        //        DB.closeConnection();
        //    }
        //}

        private void check_user_Status()
        {
            try
            {
                DB.openConnection();
                //check customer status approved or not
                System.Data.SqlClient.SqlDataReader dr = DB.readRecord("Select * from customer where Cus_Username = '" + txtUsrname.Text + "' and Cus_Password = '"+txtPwd.Text+"'");
                while (dr.Read())
                {
                    user_Type = dr[8].ToString(); //status assign to variable
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
        private void btnSignin_Click(object sender, EventArgs e)
        {
            if (txtUsrname.Text == "" || txtPwd.Text == "") // check username & password null
            {
                //then show error message
                MessageBox.Show("Please enter all fields", "E-Shift", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
               check_user_Status(); //invoke check customer status method

               if (user_Type == "Approved") // if customer status equal to approved
                {
                    try
                    {
                        //then check his username and password
                        DB.login("Select Cus_Username,Cus_Password from customer where Cus_Username= '" + txtUsrname.Text + "' and Cus_Password= '" + txtPwd.Text + "'");
                        if (DB.Dtable.Rows.Count == 1) //when query find the matched username and password
                        {
                            //show welcome message box
                            MessageBox.Show("Welcome to E-Shift", "E-Shift", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            //this.Hide(); //close login form
                            //frmCustomer_dashboard fcus_dash = new frmCustomer_dashboard(txtUsrname.Text); //create object
                            //fcus_dash.Show(); //show customer dashboard form
                        }
                        else
                        {
                            //show Error message box
                            MessageBox.Show("Incorrect Username or Password", "E-Shift", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    catch (Exception ex) //catch error in database 
                    {
                        //show the error message
                        MessageBox.Show("Error : " + ex.Message, "E-Shift", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        DB.closeConnection(); // close sql connection
                    }                  
                }
               else
                {
                    // customer status approved show message box
                    MessageBox.Show("Wait For Your Approval", "E-Shift", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    user_Type = null;
                }

            }       
        }

        private void joinLbl_Click(object sender, EventArgs e)
        {
            this.Hide(); //close this form
            frmCustomer_signin fcussign = new frmCustomer_signin(); //create object for customer sign in page
            fcussign.Show(); //open customer sign in form
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //check user want to cancel this application using message box buttons
            if (MessageBox.Show("Are you sure to exit this application", "E-Shift", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Application.Exit(); // if user click ok close apllication
            }
            
        }
    }
}
