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
    public partial class BUN : System.Web.UI.Page
    {

        StringBuilder BUNtable = new StringBuilder();
        StringBuilder BUNplayer = new StringBuilder();

        string constr = WebConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString;


        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                DBMater dbm = new DBMater();
                pills.Visible = true;


                #region TableBundesliga
                BUNPlaceHolder.Visible = true;
                SqlDataReader BUNrdr = dbm.GetReader("SELECT * FROM FBClub where LeagueID = 501 ORDER BY Points DESC;");
                BUNtable.Append("<table class='table'>");
                BUNtable.Append("<thead class='thead-dark'>");
                BUNtable.Append("<tr><th scope ='col'> Position</th><th scope = 'col'> Club</th><th scope = 'col'> Played</th><th scope = 'col'> Won</th><th scope = 'col'> Drawn</th>");
                BUNtable.Append("<th scope ='col'> Lost</th><th scope = 'col'> GF</th><th scope = 'col'> GA</th><th scope = 'col'> GD</th><th scope = 'col'> Points</th>");
                BUNtable.Append("</tr>");
                BUNtable.Append("</thead>");

                if (BUNrdr.HasRows)
                {
                    int i = 1;
                    while (BUNrdr.Read())
                    {
                        BUNtable.Append("<tbody>");
                        BUNtable.Append("<tr>");
                        BUNtable.Append("<td><a style='color:#f7560c'> " + i++ + "</a></td>");
                        BUNtable.Append("<td>" + BUNrdr[1] + "</td>");
                        BUNtable.Append("<td>" + BUNrdr[2] + "</td>");
                        BUNtable.Append("<td>" + BUNrdr[3] + "</td>");
                        BUNtable.Append("<td>" + BUNrdr[4] + "</td>");
                        BUNtable.Append("<td>" + BUNrdr[5] + "</td>");
                        BUNtable.Append("<td>" + BUNrdr[6] + "</td>");
                        BUNtable.Append("<td>" + BUNrdr[7] + "</td>");
                        BUNtable.Append("<td>" + BUNrdr[8] + "</td>");
                        BUNtable.Append("<td>" + BUNrdr[9] + "</td>");
                        BUNtable.Append("</tr>");
                        BUNtable.Append("</tbody>");

                    }
                }
                BUNtable.Append("</table>");
                BUNPlaceHolder.Controls.Add(new Literal { Text = BUNtable.ToString() });
                BUNrdr.Close();
                #endregion


                #region PlayerBundesliga 
                phPlayerBUN.Visible = true;
                SqlDataReader Plrdr = dbm.GetReader("select PlayerName, FBPlayer.Position, Nationality, ClubName from FBPlayer inner join FBClub on FBPlayer.ClubID = FBClub.ClubID where FBClub.LeagueID = 501");
                BUNplayer.Append("<table class='table'>");
                BUNplayer.Append("<thead class='thead-dark'>");
                BUNplayer.Append("<tr><th scope ='col'> Position</th><th scope = 'col'> PlayerName</th><th scope = 'col'> Position</th><th scope = 'col'> Nationality</th><th scope = 'col'> Club</th>");
                BUNplayer.Append("</tr>");
                BUNplayer.Append("</thead>");
                if (Plrdr.HasRows)
                {
                    int i = 1;
                    while (Plrdr.Read())
                    {
                        BUNplayer.Append("<tbody>");
                        BUNplayer.Append("<tr>");
                        BUNplayer.Append("<td><a style='color:#f7560c'> " + i++ + "</a></td>");
                        BUNplayer.Append("<td>" + Plrdr[0] + "</td>");
                        BUNplayer.Append("<td>" + Plrdr[1] + "</td>");
                        BUNplayer.Append("<td>" + Plrdr[2] + "</td>");
                        BUNplayer.Append("<td>" + Plrdr[3] + "</td>");
                        BUNplayer.Append("</tr>");
                        BUNplayer.Append("</tbody>");

                    }
                }
                BUNplayer.Append("</table>");
                phPlayerBUN.Controls.Add(new Literal { Text = BUNplayer.ToString() });
                Plrdr.Close();
                #endregion





            }
        }

        protected void SearchButton_Click(object sender, EventArgs e)
        {
            pills.Visible = false;
            SqlConnection con = new SqlConnection(constr);
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT PlayerName, Position, Nationality, ClubName FROM FBPlayer inner join FBClub on FBPlayer.ClubID = FBClub.ClubID WHERE PlayerName LIKE @param and LeagueID = 501", con);
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