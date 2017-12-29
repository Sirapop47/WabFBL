using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FBL
{
    public partial class LoginAdmin : System.Web.UI.Page
    {


        protected void Page_Load(object sender, EventArgs e)
        {
            lblErrorMessage.Visible = false;

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            DBMater dbm = new DBMater();
            SqlCommand adcmd = new SqlCommand("Select Count(1) from FBAdmin where UserName = @UserName and Password = @Password");
            adcmd.CommandType = System.Data.CommandType.Text;
            adcmd.Connection = dbm.GetConnection();

            adcmd.Parameters.AddWithValue("@UserName", inputUser.Text.Trim());
            adcmd.Parameters.AddWithValue("@Password", inputPassword.Text.Trim());
            int count = Convert.ToInt32(adcmd.ExecuteScalar());
            if (count == 1)
            {
                Session["UserName"] = inputUser.Text.Trim();
                Response.Redirect("Admin.aspx");
            }
            else { lblErrorMessage.Visible = true; }


            dbm.closeConnection();




        }
    }
}