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
    public partial class SerieA : System.Web.UI.Page
    {

        StringBuilder SerieAtable = new StringBuilder();
        StringBuilder SerieAPlayer = new StringBuilder();

        string constr = WebConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString;


        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                DBMater dbm = new DBMater();


                #region TableSerieA
                SqlDataReader SerieArdr = dbm.GetReader("SELECT * FROM FBClub where LeagueID = 502 ORDER BY Points DESC;");
                SerieAtable.Append("<table class='table'>");
                SerieAtable.Append("<thead class='thead-dark'>");
                SerieAtable.Append("<tr><th scope ='col'> Position</th><th scope = 'col'> Club</th><th scope = 'col'> Played</th><th scope = 'col'> Won</th><th scope = 'col'> Drawn</th>");
                SerieAtable.Append("<th scope ='col'> Lost</th><th scope = 'col'> GF</th><th scope = 'col'> GA</th><th scope = 'col'> GD</th><th scope = 'col'> Points</th>");
                SerieAtable.Append("</tr>");
                SerieAtable.Append("</thead>");

                if (SerieArdr.HasRows)
                {
                    int i = 1;
                    while (SerieArdr.Read())
                    {
                        SerieAtable.Append("<tbody>");
                        SerieAtable.Append("<tr>");
                        SerieAtable.Append("<td><a style='color:#f7560c'> " + i++ + "</a></td>");
                        SerieAtable.Append("<td>" + SerieArdr[1] + "</td>");
                        SerieAtable.Append("<td>" + SerieArdr[2] + "</td>");
                        SerieAtable.Append("<td>" + SerieArdr[3] + "</td>");
                        SerieAtable.Append("<td>" + SerieArdr[4] + "</td>");
                        SerieAtable.Append("<td>" + SerieArdr[5] + "</td>");
                        SerieAtable.Append("<td>" + SerieArdr[6] + "</td>");
                        SerieAtable.Append("<td>" + SerieArdr[7] + "</td>");
                        SerieAtable.Append("<td>" + SerieArdr[8] + "</td>");
                        SerieAtable.Append("<td>" + SerieArdr[9] + "</td>");
                        SerieAtable.Append("</tr>");
                        SerieAtable.Append("</tbody>");

                    }
                }
                SerieAtable.Append("</table>");
                SerieAPlaceHolder.Controls.Add(new Literal { Text = SerieAtable.ToString() });
                SerieArdr.Close();
                #endregion


                #region PlayerSerieA
                SqlDataReader Plrdr = dbm.GetReader("select PlayerName, FBPlayer.Position, Nationality, ClubName from FBPlayer inner join FBClub on FBPlayer.ClubID = FBClub.ClubID where FBClub.LeagueID = 502");
                SerieAPlayer.Append("<table class='table'>");
                SerieAPlayer.Append("<thead class='thead-dark'>");
                SerieAPlayer.Append("<tr><th scope ='col'> Position</th><th scope = 'col'> PlayerName</th><th scope = 'col'> Position</th><th scope = 'col'> Nationality</th><th scope = 'col'> Club</th>");
                SerieAPlayer.Append("</tr>");
                SerieAPlayer.Append("</thead>");
                if (Plrdr.HasRows)
                {
                    int i = 1;
                    while (Plrdr.Read())
                    {
                        SerieAPlayer.Append("<tbody>");
                        SerieAPlayer.Append("<tr>");
                        SerieAPlayer.Append("<td><a style='color:#f7560c'> " + i++ + "</a></td>");
                        SerieAPlayer.Append("<td>" + Plrdr[0] + "</td>");
                        SerieAPlayer.Append("<td>" + Plrdr[1] + "</td>");
                        SerieAPlayer.Append("<td>" + Plrdr[2] + "</td>");
                        SerieAPlayer.Append("<td>" + Plrdr[3] + "</td>");
                        SerieAPlayer.Append("</tr>");
                        SerieAPlayer.Append("</tbody>");

                    }
                }
                SerieAPlayer.Append("</table>");
                phPlayerSA.Controls.Add(new Literal { Text = SerieAPlayer.ToString() });
                Plrdr.Close();
                #endregion





            }
        }

        protected void SearchButton_Click(object sender, EventArgs e)
        {
            pills.Visible = false;
            SqlConnection con = new SqlConnection(constr);
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT PlayerName, Position, Nationality, ClubName FROM FBPlayer inner join FBClub on FBPlayer.ClubID = FBClub.ClubID WHERE PlayerName LIKE @param and LeagueID = 502", con);
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