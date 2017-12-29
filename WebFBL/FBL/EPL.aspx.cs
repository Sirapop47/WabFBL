using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FBL
{
    public partial class EPL : System.Web.UI.Page
    {

        StringBuilder EPLtable = new StringBuilder();
        StringBuilder EPLplayer = new StringBuilder();

        string constr = WebConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString;


        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack)
            {
                DBMater dbm = new DBMater();


                #region TablePremierleague
                SqlDataReader EPLrdr = dbm.GetReader("SELECT * FROM FBClub where LeagueID = 505 ORDER BY Points DESC;");
                EPLtable.Append("<table class='table'>");
                EPLtable.Append("<thead class='thead-dark'>");
                EPLtable.Append("<tr><th scope ='col'> Position</th><th scope = 'col'> Club</th><th scope = 'col'> Played</th><th scope = 'col'> Won</th><th scope = 'col'> Drawn</th>");
                EPLtable.Append("<th scope ='col'> Lost</th><th scope = 'col'> GF</th><th scope = 'col'> GA</th><th scope = 'col'> GD</th><th scope = 'col'> Points</th>");
                EPLtable.Append("</tr>");
                EPLtable.Append("</thead>");
                
                if (EPLrdr.HasRows)
                {
                    int i = 1;
                    while (EPLrdr.Read())
                    {
                        EPLtable.Append("<tbody>");
                        EPLtable.Append("<tr>");
                        EPLtable.Append("<td><a style='color:#f7560c'> " + i++ + "</a></td>");
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


                #region PlayerPremierleague
                SqlDataReader Plrdr = dbm.GetReader("select PlayerName, FBPlayer.Position, Nationality, ClubName from FBPlayer inner join FBClub on FBPlayer.ClubID = FBClub.ClubID where FBClub.LeagueID = 505");
                EPLplayer.Append("<table class='table'>");
                EPLplayer.Append("<thead class='thead-dark'>");
                EPLplayer.Append("<tr><th scope ='col'> Position</th><th scope = 'col'> PlayerName</th><th scope = 'col'> Position</th><th scope = 'col'> Nationality</th><th scope = 'col'> Club</th>");
                EPLplayer.Append("</tr>");
                EPLplayer.Append("</thead>");
                if (Plrdr.HasRows)
                {
                    int i = 1;
                    while (Plrdr.Read())
                    {
                        EPLplayer.Append("<tbody>");
                        EPLplayer.Append("<tr>");
                        EPLplayer.Append("<td><a style='color:#f7560c'> " + i++ + "</a></td>");
                        EPLplayer.Append("<td>" + Plrdr[0] + "</td>");
                        EPLplayer.Append("<td>" + Plrdr[1] + "</td>");
                        EPLplayer.Append("<td>" + Plrdr[2] + "</td>");
                        EPLplayer.Append("<td>" + Plrdr[3] + "</td>");
                        EPLplayer.Append("</tr>");
                        EPLplayer.Append("</tbody>");

                    }
                }
                EPLplayer.Append("</table>");
                phPlayerEPL.Controls.Add(new Literal { Text = EPLplayer.ToString() });
                Plrdr.Close();
                #endregion




            }

        }

        protected void SearchButton_Click(object sender, EventArgs e)
        {
            pills.Visible = false;
            SqlConnection con = new SqlConnection(constr);
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT PlayerName, Position, Nationality, ClubName FROM FBPlayer inner join FBClub on FBPlayer.ClubID = FBClub.ClubID WHERE PlayerName LIKE @param and LeagueID = 505", con);
            cmd.Parameters.AddWithValue("@param", "%" + SearchTextBox.Text + "%");
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                string _htmlappend = @"<div class='card' style='width: 20rem;'>
                                          <div class='card-body'>
                                            <h4 class='card-title'><span style='font-size:16px;font-weight:bold;'>PlayerName : " + rdr[0].ToString() + @"</span><br/></h4>
                                            <p class='card-text'><span style='font-size:14px;'>Position : " + rdr[1].ToString() + @"</span><br />
                                            <span style='font-size:14px;'>Nationality : " + rdr[2].ToString() + @"</span><br />
                                            <span style='font-size:14px;'>ClubName : " + rdr[3].ToString() + @"</span><br /><p/></p>
                                          </div>
                                        </div>";

                usercontent.Controls.Add(new LiteralControl(_htmlappend));
            }

            GridView1.DataSource = rdr;
            GridView1.DataBind();
            con.Close();
        }
    }
}