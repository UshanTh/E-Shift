using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace E_Shift
{
    class DBase_Cls
    {
        //Create variables
        SqlConnection con;
        public SqlDataReader sqlRead;
        public SqlCommand cmd;
        SqlDataAdapter sda;
        public DataTable Dtable;
        public DataSet ds;
        public string password;
        public string confirm_Password;
        String sql;

        public SqlConnection openConnection() //Open sql Connection
        {
            //Add database connection
            sql = "Data Source = LAPTOP-9MO4U183; Initial Catalog = E_Shift; Integrated Security = True";
            con = new SqlConnection(sql); //Sqlconnection object with data source
            con.Open(); //open sql connection
            return con; //return sql connection
        }

        public void closeConnection() //Close sql connection
        {
            con.Close();
        }
        
        public void login(string qry) //login function
        {
            sda = new SqlDataAdapter(qry, con); // Sql data adapter object with query and connection
            Dtable = new DataTable(); //data table object 
            sda.Fill(Dtable); /// find records in the DataTable to match above query
        }

        public void queryingRecord(string qry) //Querying Data
        {
            cmd = new SqlCommand(qry, con); //Sqlcommand object with query and sql connection  
            cmd.ExecuteNonQuery(); //Execute the sql command
        }

        public SqlDataReader readRecord(string qry) //search database records
        {
            cmd = new SqlCommand(qry, con); //set the command object
            sqlRead = cmd.ExecuteReader(); //read the statement
            return sqlRead; //return the value
        }

        public void showRecords(string qry, string table_name) //show records in datagrid view
        {
            sda = new SqlDataAdapter(qry, con);
            ds = new System.Data.DataSet();
            sda.Fill(ds, table_name);      
        }

    }
}
