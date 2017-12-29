using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FBL
{
    public partial class Admin : System.Web.UI.Page
    {

        string constr = WebConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString;
        StringBuilder EPLtable = new StringBuilder();
        StringBuilder LFPtable = new StringBuilder();
        StringBuilder BLtable = new StringBuilder();
        StringBuilder SAtable = new StringBuilder();
        StringBuilder L1table = new StringBuilder();
        bool CheckT = false;



        DBMater dbm = new DBMater();

        protected void Page_Load(object sender, EventArgs e)
        {
            lblUserConnect.Text = "Username : " + Session["UserName"];


            #region TablePremierleague
            SqlDataReader EPLrdr = dbm.GetReader("SELECT * FROM FBClub where LeagueID = 505 ORDER BY LeagueID DESC;");
            EPLtable.Append("<table class='table'>");
            EPLtable.Append("<thead>");
            EPLtable.Append("<tr><th scope ='col'> ID</th><th scope = 'col'> Club</th><th scope = 'col'> Played</th><th scope = 'col'> Won</th><th scope = 'col'> Drawn</th>");
            EPLtable.Append("<th scope ='col'> Lost</th><th scope = 'col'> GF</th><th scope = 'col'> GA</th><th scope = 'col'> GD</th><th scope = 'col'> Points</th>");
            EPLtable.Append("</tr>");
            EPLtable.Append("</thead>");
            if (EPLrdr.HasRows)
            {
                while (EPLrdr.Read())
                {
                    EPLtable.Append("<tbody>");
                    EPLtable.Append("<tr>");
                    EPLtable.Append("<td><a style='color:#f7560c'> " + EPLrdr[0] + "</a></td>");
                    EPLtable.Append("<td>" + EPLrdr[1] + "</td>");
                    EPLtable.Append("<td>" + EPLrdr[2] + "</td>");
                    EPLtable.Append("<td>" + EPLrdr[3] + "</td>");
                    EPLtable.Append("<td>" + EPLrdr[4] + "</td>");
                    EPLtable.Append("<td>" + EPLrdr[5] + "</td>");
                    EPLtable.Append("<td>" + EPLrdr[6] + "</td>");
                    EPLtable.Append("<td>" + EPLrdr[7] + "</td>");
                    EPLtable.Append("<td>" + EPLrdr[8] + "</td>");
                    EPLtable.Append("<td>" + EPLrdr[9] + "</td>");
                    EPLtable.Append("</tr>");
                    EPLtable.Append("</tbody>");

                }
            }
            EPLtable.Append("</table>");
            EPLPlaceHolder.Controls.Add(new Literal { Text = EPLtable.ToString() });
            EPLrdr.Close();
            #endregion


            #region TableLaLiga
            SqlDataReader LFPrdr = dbm.GetReader("SELECT * FROM FBClub where LeagueID = 504 ORDER BY LeagueID DESC;");
            LFPtable.Append("<table class='table'>");
            LFPtable.Append("<thead>");
            LFPtable.Append("<tr><th scope ='col'> ID</th><th scope = 'col'> Club</th><th scope = 'col'> Played</th><th scope = 'col'> Won</th><th scope = 'col'> Drawn</th>");
            LFPtable.Append("<th scope ='col'> Lost</th><th scope = 'col'> GF</th><th scope = 'col'> GA</th><th scope = 'col'> GD</th><th scope = 'col'> Points</th>");
            LFPtable.Append("</tr>");
            LFPtable.Append("</thead>");
            if (LFPrdr.HasRows)
            {
                while (LFPrdr.Read())
                {
                    LFPtable.Append("<tbody>");
                    LFPtable.Append("<tr>");
                    LFPtable.Append("<td><a style='color:#f7560c'> " + LFPrdr[0] + "</a></td>");
                    LFPtable.Append("<td>" + LFPrdr[1] + "</td>");
                    LFPtable.Append("<td>" + LFPrdr[2] + "</td>");
                    LFPtable.Append("<td>" + LFPrdr[3] + "</td>");
                    LFPtable.Append("<td>" + LFPrdr[4] + "</td>");
                    LFPtable.Append("<td>" + LFPrdr[5] + "</td>");
                    LFPtable.Append("<td>" + LFPrdr[6] + "</td>");
                    LFPtable.Append("<td>" + LFPrdr[7] + "</td>");
                    LFPtable.Append("<td>" + LFPrdr[8] + "</td>");
                    LFPtable.Append("<td>" + LFPrdr[9] + "</td>");
                    LFPtable.Append("</tr>");
                    LFPtable.Append("</tbody>");

                }
            }
            LFPtable.Append("</table>");
            LFPPlaceHolder.Controls.Add(new Literal { Text = LFPtable.ToString() });
            LFPrdr.Close();
            #endregion

            #region TableBundesLiga
            SqlDataReader BLrdr = dbm.GetReader("SELECT * FROM FBClub where LeagueID = 501 ORDER BY LeagueID DESC;");
            BLtable.Append("<table class='table'>");
            BLtable.Append("<thead>");
            BLtable.Append("<tr><th scope ='col'> ID</th><th scope = 'col'> Club</th><th scope = 'col'> Played</th><th scope = 'col'> Won</th><th scope = 'col'> Drawn</th>");
            BLtable.Append("<th scope ='col'> Lost</th><th scope = 'col'> GF</th><th scope = 'col'> GA</th><th scope = 'col'> GD</th><th scope = 'col'> Points</th>");
            BLtable.Append("</tr>");
            BLtable.Append("</thead>");
            if (BLrdr.HasRows)
            {
                while (BLrdr.Read())
                {
                    BLtable.Append("<tbody>");
                    BLtable.Append("<tr>");
                    BLtable.Append("<td><a style='color:#f7560c'> " + BLrdr[0] + "</a></td>");
                    BLtable.Append("<td>" + BLrdr[1] + "</td>");
                    BLtable.Append("<td>" + BLrdr[2] + "</td>");
                    BLtable.Append("<td>" + BLrdr[3] + "</td>");
                    BLtable.Append("<td>" + BLrdr[4] + "</td>");
                    BLtable.Append("<td>" + BLrdr[5] + "</td>");
                    BLtable.Append("<td>" + BLrdr[6] + "</td>");
                    BLtable.Append("<td>" + BLrdr[7] + "</td>");
                    BLtable.Append("<td>" + BLrdr[8] + "</td>");
                    BLtable.Append("<td>" + BLrdr[9] + "</td>");
                    BLtable.Append("</tr>");
                    BLtable.Append("</tbody>");

                }
            }
            BLtable.Append("</table>");
            BLPlaceHolder.Controls.Add(new Literal { Text = BLtable.ToString() });
            BLrdr.Close();
            #endregion


            #region TableSerie A
            SqlDataReader SArdr = dbm.GetReader("SELECT * FROM FBClub where LeagueID = 502 ORDER BY LeagueID DESC;");
            SAtable.Append("<table class='table'>");
            SAtable.Append("<thead>");
            SAtable.Append("<tr><th scope ='col'> ID</th><th scope = 'col'> Club</th><th scope = 'col'> Played</th><th scope = 'col'> Won</th><th scope = 'col'> Drawn</th>");
            SAtable.Append("<th scope ='col'> Lost</th><th scope = 'col'> GF</th><th scope = 'col'> GA</th><th scope = 'col'> GD</th><th scope = 'col'> Points</th>");
            SAtable.Append("</tr>");
            SAtable.Append("</thead>");
            if (SArdr.HasRows)
            {
                while (SArdr.Read())
                {
                    SAtable.Append("<tbody>");
                    SAtable.Append("<tr>");
                    SAtable.Append("<td><a style='color:#f7560c'> " + SArdr[0] + "</a></td>");
                    SAtable.Append("<td>" + SArdr[1] + "</td>");
                    SAtable.Append("<td>" + SArdr[2] + "</td>");
                    SAtable.Append("<td>" + SArdr[3] + "</td>");
                    SAtable.Append("<td>" + SArdr[4] + "</td>");
                    SAtable.Append("<td>" + SArdr[5] + "</td>");
                    SAtable.Append("<td>" + SArdr[6] + "</td>");
                    SAtable.Append("<td>" + SArdr[7] + "</td>");
                    SAtable.Append("<td>" + SArdr[8] + "</td>");
                    SAtable.Append("<td>" + SArdr[9] + "</td>");
                    SAtable.Append("</tr>");
                    SAtable.Append("</tbody>");

                }
            }
            SAtable.Append("</table>");
            SAPlaceHolder.Controls.Add(new Literal { Text = SAtable.ToString() });
            SArdr.Close();
            #endregion


            #region TableLigue 1
            SqlDataReader L1rdr = dbm.GetReader("SELECT * FROM FBClub where LeagueID = 503 ORDER BY LeagueID DESC;");
            L1table.Append("<table class='table'>");
            L1table.Append("<thead>");
            L1table.Append("<tr><th scope ='col'> ID</th><th scope = 'col'> Club</th><th scope = 'col'> Played</th><th scope = 'col'> Won</th><th scope = 'col'> Drawn</th>");
            L1table.Append("<th scope ='col'> Lost</th><th scope = 'col'> GF</th><th scope = 'col'> GA</th><th scope = 'col'> GD</th><th scope = 'col'> Points</th>");
            L1table.Append("</tr>");
            L1table.Append("</thead>");
            if (L1rdr.HasRows)
            {
                while (L1rdr.Read())
                {
                    L1table.Append("<tbody>");
                    L1table.Append("<tr>");
                    L1table.Append("<td><a style='color:#f7560c'> " + L1rdr[0] + "</a></td>");
                    L1table.Append("<td>" + L1rdr[1] + "</td>");
                    L1table.Append("<td>" + L1rdr[2] + "</td>");
                    L1table.Append("<td>" + L1rdr[3] + "</td>");
                    L1table.Append("<td>" + L1rdr[4] + "</td>");
                    L1table.Append("<td>" + L1rdr[5] + "</td>");
                    L1table.Append("<td>" + L1rdr[6] + "</td>");
                    L1table.Append("<td>" + L1rdr[7] + "</td>");
                    L1table.Append("<td>" + L1rdr[8] + "</td>");
                    L1table.Append("<td>" + L1rdr[9] + "</td>");
                    L1table.Append("</tr>");
                    L1table.Append("</tbody>");

                }
            }
            L1table.Append("</table>");
            L1PlaceHolder.Controls.Add(new Literal { Text = L1table.ToString() });
            L1rdr.Close();
            #endregion


            lblErrorMessage.Visible = false;
            dbm.closeConnection();

        }


        protected void btnLogout_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("LoginAdmin.aspx");

        }

        protected void btUpdate_Click(object sender, EventArgs e)
        {

            if (GFTextBox.Text == "" || GATextBox.Text == "" || IDClub.Text == "")
            {
                lblErrorMessage.Visible = true;
                lblErrorMessage.ForeColor = System.Drawing.Color.Red;
                lblErrorMessage.Text = "กรุณากรอกข้อมูลให้ครบ";
                CheckT = false;

            }

            else
            {
                int GF = int.Parse(GFTextBox.Text);
                int GA = int.Parse(GATextBox.Text);
                int GD = GF - GA;
                

                if (GF > GA)
                {
                    SqlDataReader rdr = dbm.GetReader("UPDATE FBClub SET Played += 1, Won += 1, GF += " + GF + ", GA += " + GA + ", GD += " + GD + ", Points += 3  WHERE ClubID = " + IDClub.Text + "; ");

                    GFTextBox.Text = "";
                    GATextBox.Text = "";
                    IDClub.Text = "";
                    CheckT = true;
                    if (CheckT == true)
                    {
                        Response.Redirect("SuccessPage.aspx");

                    }

                }
                if (GF == GA)
                {
                    SqlDataReader rdr = dbm.GetReader("UPDATE FBClub SET Played += 1, Drawn += 1, GF += " + GF + ", GA += " + GA + ", GD += " + GD + ", Points += 1  WHERE ClubID = " + IDClub.Text + "; ");

                    GFTextBox.Text = "";
                    GATextBox.Text = "";
                    IDClub.Text = "";
                    CheckT = true;
                    if (CheckT == true)
                    {
                        Response.Redirect("SuccessPage.aspx");

                    }
                }
                if (GF < GA)
                {
                    SqlDataReader rdr = dbm.GetReader("UPDATE FBClub SET Played += 1, Lost += 1, GF += " + GF + ", GA += " + GA + ", GD += " + GD + " WHERE ClubID = " + IDClub.Text + "; ");

                    GFTextBox.Text = "";
                    GATextBox.Text = "";
                    IDClub.Text = "";
                    CheckT = true;
                    if (CheckT == true)
                    {
                        Response.Redirect("SuccessPage.aspx");

                    }
                }

            }

        }

        protected void UpdateNews_Click1(object sender, EventArgs e)
        {

            if (tbTitle.Text == "" || tbLead.Text == "" || tbContent.Text == "" || IDLeagueTextBox.Text == "" || !FileUpload1.HasFile)
            {
                lblErrorMessage.Visible = true;
                lblErrorMessage.ForeColor = System.Drawing.Color.Red;
                lblErrorMessage.Text = "กรุณากรอกข้อมูลให้ครบ";

            }


            else
            {
                SqlDataReader rdr = dbm.GetReader("INSERT INTO FBNews(IDNews, TitleNews, LeadNews, ContentNews, IDLeague) VALUES((select max(IDNews) from FBNews ) + 1, '" + tbTitle.Text + "', '" + tbLead.Text + "', '" + tbContent.Text + "', "+ IDLeagueTextBox.Text+ ");");
                string filePath = FileUpload1.PostedFile.FileName;
                string filename = Path.GetFileName(filePath);
                string ext = Path.GetExtension(filename);
                string contenttype = String.Empty;
                switch (ext)
                {
                    case ".jpg":
                        contenttype = "image/jpg";
                        break;
                    case ".png":
                        contenttype = "image/png";
                        break;
                    case ".gif":
                        contenttype = "image/gif";
                        break;

                }
                if (contenttype != String.Empty)
                {
                    Stream fs = FileUpload1.PostedFile.InputStream;
                    BinaryReader br = new BinaryReader(fs);
                    Byte[] bytes = br.ReadBytes((Int32)fs.Length);


                    //insert the file into database
                    string strQuery = "insert into FBImage(IName, Data)" + " values (@Name, @Data)";

                    SqlCommand cmd = new SqlCommand(strQuery);

                    cmd.Parameters.Add("@Name", SqlDbType.VarChar).Value = filename;
                    cmd.Parameters.Add("@Data", SqlDbType.Binary).Value = bytes;

                    InsertUpdateData(cmd);
                    CheckT = true;
                    if (CheckT == true)
                    {
                        Response.Redirect("SuccessPage.aspx");

                    }
                }
                else
                {
                    CheckT = false;
                    lblErrorMessage.ForeColor = System.Drawing.Color.Red;
                    lblErrorMessage.Text = "File format not recognised." + " Upload Image(.jpg, .png, .gif) formats";
                }

            }




        }
        

        private Boolean InsertUpdateData(SqlCommand cmd)
        {
            SqlConnection con = new SqlConnection(constr);
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
                return false;
            }
            finally
            {
                con.Close();
                con.Dispose();
            }
        }

        protected void btnEditEdit_Click(object sender, EventArgs e)
        {
            if (tbIDClubEdit.Text == "" || tbClubNameEdit.Text == "" || tbPlayerEdit.Text == "" || tbWonEdit.Text == "" || tbDrawnEdit.Text == "" || tbLostEdit.Text == "")
            {
                lblErrorMessage.Visible = true;
                lblErrorMessage.ForeColor = System.Drawing.Color.Red;
                lblErrorMessage.Text = "กรุณากรอกข้อมูลให้ครบ";

            }
            else if (tbGFEdit.Text == "" || tbGAEdit.Text == "" || tbGDEdit.Text == "" || tbPointsEdit.Text == "" ) 
            {
                lblErrorMessage.Visible = true;
                lblErrorMessage.ForeColor = System.Drawing.Color.Red;
                lblErrorMessage.Text = "กรุณากรอกข้อมูลให้ครบ";
            }
            else
            {
                SqlDataReader rdr = dbm.GetReader("UPDATE FBClub SET ClubName = '"+ tbClubNameEdit.Text + "', Played = "+ tbPlayerEdit.Text + ", Won = "+ tbWonEdit.Text + ", Drawn =" + tbDrawnEdit.Text + ", Lost = "+ tbLostEdit.Text + ", GF = "+ tbGFEdit.Text + ", GA = "+ tbGAEdit.Text + ", GD = "+ tbGDEdit.Text + ", Points = " + tbPointsEdit.Text + "  WHERE ClubID = " + tbIDClubEdit.Text + ";");
                tbIDClubEdit.Text = "";
                tbClubNameEdit.Text = "";
                tbPlayerEdit.Text = "";
                tbWonEdit.Text = "";
                tbDrawnEdit.Text = "";
                tbLostEdit.Text = "";
                tbGFEdit.Text = "";
                tbGAEdit.Text = "";
                tbGDEdit.Text = "";
                tbPointsEdit.Text = "";
                CheckT = true;
                if (CheckT == true)
                {
                    Response.Redirect("SuccessPage.aspx");

                }
            }




        }
    }
}