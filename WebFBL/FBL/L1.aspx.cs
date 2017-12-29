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
    public partial class L1 : System.Web.UI.Page
    {

        StringBuilder L1table = new StringBuilder();
        StringBuilder L1player = new StringBuilder();

        string constr = WebConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString;


        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                DBMater dbm = new DBMater();


                #region TableLeague1
                SqlDataReader L1rdr = dbm.GetReader("SELECT * FROM FBClub where LeagueID = 503 ORDER BY Points DESC;");
                L1table.Append("<table class='table'>");
                L1table.Append("<thead class='thead-dark'>");
                L1table.Append("<tr><th scope ='col'> Position</th><th scope = 'col'> Club</th><th scope = 'col'> Played</th><th scope = 'col'> Won</th><th scope = 'col'> Drawn</th>");
                L1table.Append("<th scope ='col'> Lost</th><th scope = 'col'> GF</th><th scope = 'col'> GA</th><th scope = 'col'> GD</th><th scope = 'col'> Points</th>");
                L1table.Append("</tr>");
                L1table.Append("</thead>");

                if (L1rdr.HasRows)
                {
                    int i = 1;
                    while (L1rdr.Read())
                    {
                        L1table.Append("<tbody>");
                        L1table.Append("<tr>");
                        L1table.Append("<td><a style='color:#f7560c'> " + i++ + "</a></td>");
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

                #region PlayerLeague1
                SqlDataReader Plrdr = dbm.GetReader("select PlayerName, FBPlayer.Position, Nationality, ClubName from FBPlayer inner join FBClub on FBPlayer.ClubID = FBClub.ClubID where FBClub.LeagueID = 503");
                L1player.Append("<table class='table'>");
                L1player.Append("<thead class='thead-dark'>");
                L1player.Append("<tr><th scope ='col'> Position</th><th scope = 'col'> PlayerName</th><th scope = 'col'> Position</th><th scope = 'col'> Nationality</th><th scope = 'col'> Club</th>");
                L1player.Append("</tr>");
                L1player.Append("</thead>");
                if (Plrdr.HasRows)
                {
                    int i = 1;
                    while (Plrdr.Read())
                    {
                        L1player.Append("<tbody>");
                        L1player.Append("<tr>");
                        L1player.Append("<td><a style='color:#f7560c'> " + i++ + "</a></td>");
                        L1player.Append("<td>" + Plrdr[0] + "</td>");
                        L1player.Append("<td>" + Plrdr[1] + "</td>");
                        L1player.Append("<td>" + Plrdr[2] + "</td>");
                        L1player.Append("<td>" + Plrdr[3] + "</td>");
                        L1player.Append("</tr>");
                        L1player.Append("</tbody>");

                    }
                }
                L1player.Append("</table>");
                phPlayerL1.Controls.Add(new Literal { Text = L1player.ToString() });
                Plrdr.Close();
                #endregion






            }
        }

        protected void SearchButton_Click(object sender, EventArgs e)
        {
            pills.Visible = false;
            SqlConnection con = new SqlConnection(constr);
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT PlayerName, Position, Nationality, ClubName FROM FBPlayer inner join FBClub on FBPlayer.ClubID = FBClub.ClubID WHERE PlayerName LIKE @param and LeagueID = 503", con);
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