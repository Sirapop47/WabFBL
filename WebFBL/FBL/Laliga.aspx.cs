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
    public partial class Laliga : System.Web.UI.Page
    {

        StringBuilder Laligatable = new StringBuilder();
        StringBuilder Laligaplayer = new StringBuilder();

        string constr = WebConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString;


        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                DBMater dbm = new DBMater();


                #region TableLaliga
                SqlDataReader LFPrdr = dbm.GetReader("SELECT * FROM FBClub where LeagueID = 504 ORDER BY Points DESC;");
                Laligatable.Append("<table class='table'>");
                Laligatable.Append("<thead class='thead-dark'>");
                Laligatable.Append("<tr><th scope ='col'> Position</th><th scope = 'col'> Club</th><th scope = 'col'> Played</th><th scope = 'col'> Won</th><th scope = 'col'> Drawn</th>");
                Laligatable.Append("<th scope ='col'> Lost</th><th scope = 'col'> GF</th><th scope = 'col'> GA</th><th scope = 'col'> GD</th><th scope = 'col'> Points</th>");
                Laligatable.Append("</tr>");
                Laligatable.Append("</thead>");

                if (LFPrdr.HasRows)
                {
                    int i = 1;
                    while (LFPrdr.Read())
                    {
                        Laligatable.Append("<tbody>");
                        Laligatable.Append("<tr>");
                        Laligatable.Append("<td><a style='color:#f7560c'> " + i++ + "</a></td>");
                        Laligatable.Append("<td>" + LFPrdr[1] + "</td>");
                        Laligatable.Append("<td>" + LFPrdr[2] + "</td>");
                        Laligatable.Append("<td>" + LFPrdr[3] + "</td>");
                        Laligatable.Append("<td>" + LFPrdr[4] + "</td>");
                        Laligatable.Append("<td>" + LFPrdr[5] + "</td>");
                        Laligatable.Append("<td>" + LFPrdr[6] + "</td>");
                        Laligatable.Append("<td>" + LFPrdr[7] + "</td>");
                        Laligatable.Append("<td>" + LFPrdr[8] + "</td>");
                        Laligatable.Append("<td>" + LFPrdr[9] + "</td>");
                        Laligatable.Append("</tr>");
                        Laligatable.Append("</tbody>");

                    }
                }
                Laligatable.Append("</table>");
                LFPPlaceHolder.Controls.Add(new Literal { Text = Laligatable.ToString() });
                LFPrdr.Close();
                #endregion

                #region PlayerLaliga
                SqlDataReader Plrdr = dbm.GetReader("select PlayerName, FBPlayer.Position, Nationality, ClubName from FBPlayer inner join FBClub on FBPlayer.ClubID = FBClub.ClubID where FBClub.LeagueID = 504");
                Laligaplayer.Append("<table class='table'>");
                Laligaplayer.Append("<thead class='thead-dark'>");
                Laligaplayer.Append("<tr><th scope ='col'> Position</th><th scope = 'col'> PlayerName</th><th scope = 'col'> Position</th><th scope = 'col'> Nationality</th><th scope = 'col'> Club</th>");
                Laligaplayer.Append("</tr>");
                Laligaplayer.Append("</thead>");

                if (Plrdr.HasRows)
                {
                    int i = 1;
                    while (Plrdr.Read())
                    {
                        Laligaplayer.Append("<tbody>");
                        Laligaplayer.Append("<tr>");
                        Laligaplayer.Append("<td><a style='color:#f7560c'> " + i++ + "</a></td>");
                        Laligaplayer.Append("<td>" + Plrdr[0] + "</td>");
                        Laligaplayer.Append("<td>" + Plrdr[1] + "</td>");
                        Laligaplayer.Append("<td>" + Plrdr[2] + "</td>");
                        Laligaplayer.Append("<td>" + Plrdr[3] + "</td>");
                        Laligaplayer.Append("</tr>");
                        Laligaplayer.Append("</tbody>");

                    }
                }
                Laligaplayer.Append("</table>");
                phPlayerLFP.Controls.Add(new Literal { Text = Laligaplayer.ToString() });
                Plrdr.Close();
                #endregion




            }
        }

        protected void SearchButton_Click(object sender, EventArgs e)
        {
            pills.Visible = false;
            SqlConnection con = new SqlConnection(constr);
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT PlayerName, Position, Nationality, ClubName FROM FBPlayer inner join FBClub on FBPlayer.ClubID = FBClub.ClubID WHERE PlayerName LIKE @param and LeagueID = 504", con);
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