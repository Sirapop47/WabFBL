using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Configuration;
using System.IO;

namespace FBL
{
    public class DBMater
    {

        SqlConnection con;
        string constr = WebConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString;

        public SqlConnection GetConnection()
        {
           
            con = new SqlConnection(constr);
            con.Open();
            return con;

        }

        public SqlDataReader GetReader(string query)
        {
            SqlCommand cmd = new SqlCommand(query);
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Connection = this.GetConnection();

            SqlDataReader rdr = cmd.ExecuteReader();
 

            return rdr;

        }





        public void closeConnection()
        {
            if (con != null && con.State == System.Data.ConnectionState.Open)
            {
                this.con.Close();
            }

        }



    }
}