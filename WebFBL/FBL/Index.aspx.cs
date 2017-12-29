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
    public partial class Index : System.Web.UI.Page
    {
        StringBuilder EPLtable = new StringBuilder();
        StringBuilder LFPtable = new StringBuilder();
        StringBuilder BLtable = new StringBuilder();
        StringBuilder SAtable = new StringBuilder();
        StringBuilder L1table = new StringBuilder();

        public string News1;





        protected void Page_Load(object sender, EventArgs e)
        {

            if (!Page.IsPostBack)
            {

                DBMater dbm = new DBMater();




                #region TablePremierleague
                SqlDataReader EPLrdr = dbm.GetReader("SELECT ClubName, Played, GD, Points FROM FBClub where LeagueID = 505 ORDER BY Points DESC;");
                EPLtable.Append("<table class='table'>");
                EPLtable.Append("<thead>");
                EPLtable.Append("<tr><th scope ='col'> Pos</th><th scope = 'col'> Club</th><th scope = 'col'> Pl</th><th scope = 'col'> GD</th><th scope = 'col'> Pts</th></tr>");
                EPLtable.Append("</tr>");
                EPLtable.Append("</thead>");
                if (EPLrdr.HasRows)
                {
                    int i = 1;
                    while (EPLrdr.Read())
                    {
                        EPLtable.Append("<tbody>");
                        EPLtable.Append("<tr>");
                        EPLtable.Append("<td>" + i++ + "</td>");
                        EPLtable.Append("<td>" + EPLrdr[0] + "</td>");
                        EPLtable.Append("<td>" + EPLrdr[1] + "</td>");
                        EPLtable.Append("<td>" + EPLrdr[2] + "</td>");
                        EPLtable.Append("<td>" + EPLrdr[3] + "</td>");
                        EPLtable.Append("</tr>");
                        EPLtable.Append("</tbody>");
                    }
                }
                EPLtable.Append("</table>");
                EPLPlaceHolder.Controls.Add(new Literal { Text = EPLtable.ToString() });
                EPLrdr.Close();
                #endregion


                #region TableFBLaLiga 
                SqlDataReader LFPrdr = dbm.GetReader("SELECT ClubName, Played, GD, Points FROM FBClub where LeagueID = 504 ORDER BY Points DESC;");
                LFPtable.Append("<table class='table'>");
                LFPtable.Append("<thead>");
                LFPtable.Append("<tr><th scope ='col'> Pos</th><th scope = 'col'> Club</th><th scope = 'col'> Pl</th><th scope = 'col'> GD</th><th scope = 'col'> Pts</th></tr>");
                LFPtable.Append("</tr>");
                LFPtable.Append("</thead>");
                if (LFPrdr.HasRows)
                {
                    int i = 1;
                    while (LFPrdr.Read())
                    {
                        LFPtable.Append("<tbody>");
                        LFPtable.Append("<tr>");
                        LFPtable.Append("<td>" + i++ + "</td>");
                        LFPtable.Append("<td>" + LFPrdr[0] + "</td>");
                        LFPtable.Append("<td>" + LFPrdr[1] + "</td>");
                        LFPtable.Append("<td>" + LFPrdr[2] + "</td>");
                        LFPtable.Append("<td>" + LFPrdr[3] + "</td>");
                        LFPtable.Append("</tr>");
                        LFPtable.Append("</tbody>");
                    }
                }
                LFPtable.Append("</table>");
                LFPPlaceHolder.Controls.Add(new Literal { Text = LFPtable.ToString() });
                LFPrdr.Close();

                #endregion

                #region TableFBBL
                SqlDataReader BLrdr = dbm.GetReader("SELECT ClubName, Played, GD, Points FROM FBClub where LeagueID = 501 ORDER BY Points DESC;");
                BLtable.Append("<table class='table'>");
                BLtable.Append("<thead>");
                BLtable.Append("<tr><th scope ='col'> Pos</th><th scope = 'col'> Club</th><th scope = 'col'> Pl</th><th scope = 'col'> GD</th><th scope = 'col'> Pts</th></tr>");
                BLtable.Append("</tr>");
                BLtable.Append("</thead>");
                if (BLrdr.HasRows)
                {
                    int i = 1;
                    while (BLrdr.Read())
                    {
                        BLtable.Append("<tbody>");
                        BLtable.Append("<tr>");
                        BLtable.Append("<td>" + i++ + "</td>");
                        BLtable.Append("<td>" + BLrdr[0] + "</td>");
                        BLtable.Append("<td>" + BLrdr[1] + "</td>");
                        BLtable.Append("<td>" + BLrdr[2] + "</td>");
                        BLtable.Append("<td>" + BLrdr[3] + "</td>");
                        BLtable.Append("</tr>");
                        BLtable.Append("</tbody>");
                    }
                }
                BLtable.Append("</table>");
                BLPlaceHolder.Controls.Add(new Literal { Text = BLtable.ToString() });
                BLrdr.Close();

                #endregion

                #region TableFBSA
                SqlDataReader SArdr = dbm.GetReader("SELECT ClubName, Played, GD, Points FROM FBClub where LeagueID = 502 ORDER BY Points DESC;");
                SAtable.Append("<table class='table'>");
                SAtable.Append("<thead>");
                SAtable.Append("<tr><th scope ='col'> Pos</th><th scope = 'col'> Club</th><th scope = 'col'> Pl</th><th scope = 'col'> GD</th><th scope = 'col'> Pts</th></tr>");
                SAtable.Append("</tr>");
                SAtable.Append("</thead>");
                if (SArdr.HasRows)
                {
                    int i = 1;
                    while (SArdr.Read())
                    {
                        SAtable.Append("<tbody>");
                        SAtable.Append("<tr>");
                        SAtable.Append("<td>" + i++ + "</td>");
                        SAtable.Append("<td>" + SArdr[0] + "</td>");
                        SAtable.Append("<td>" + SArdr[1] + "</td>");
                        SAtable.Append("<td>" + SArdr[2] + "</td>");
                        SAtable.Append("<td>" + SArdr[3] + "</td>");
                        SAtable.Append("</tr>");
                        SAtable.Append("</tbody>");
                    }
                }
                SAtable.Append("</table>");
                SAPlaceHolder.Controls.Add(new Literal { Text = SAtable.ToString() });
                SArdr.Close();

                #endregion

                #region TableFBL1
                SqlDataReader L1rdr = dbm.GetReader("SELECT ClubName, Played, GD, Points FROM FBClub where LeagueID = 503 ORDER BY Points DESC;");
                L1table.Append("<table class='table'>");
                L1table.Append("<thead>");
                L1table.Append("<tr><th scope ='col'> Pos</th><th scope = 'col'> Club</th><th scope = 'col'> Pl</th><th scope = 'col'> GD</th><th scope = 'col'> Pts</th></tr>");
                L1table.Append("</tr>");
                L1table.Append("</thead>");
                if (L1rdr.HasRows)
                {
                    int i = 1;
                    while (L1rdr.Read())
                    {
                        L1table.Append("<tbody>");
                        L1table.Append("<tr>");
                        L1table.Append("<td>" + i++ + "</td>");
                        L1table.Append("<td>" + L1rdr[0] + "</td>");
                        L1table.Append("<td>" + L1rdr[1] + "</td>");
                        L1table.Append("<td>" + L1rdr[2] + "</td>");
                        L1table.Append("<td>" + L1rdr[3] + "</td>");
                        L1table.Append("</tr>");
                        L1table.Append("</tbody>");
                    }
                }
                L1table.Append("</table>");
                L1PlaceHolder.Controls.Add(new Literal { Text = L1table.ToString() });
                L1rdr.Close();

                #endregion





                #region News1
                SqlDataReader Newsrdr1 = dbm.GetReader("select FBImage.IDNews, TitleNews, ContentNews, IName, Data from FBNews inner join FBImage on FBNews.IDNews = FBImage.IDNews where FBNews.IDNews = (select MAx(FBNews.IDNews) from FBNews)");
                while (Newsrdr1.Read())
                {
                    byte[] imagedata = (byte[])Newsrdr1["Data"];
                    string img = Convert.ToBase64String(imagedata, 0, imagedata.Length);
                    Image1.ImageUrl = "data:image/png;base64," + img;
                    News1 = Newsrdr1[1].ToString();

                }
                TtNews1.DataBind();
                Newsrdr1.Close();


                #endregion

                #region News2
                SqlDataReader Newsrdr2 = dbm.GetReader("select FBImage.IDNews, TitleNews, ContentNews, IName, Data from FBNews inner join FBImage on FBNews.IDNews = FBImage.IDNews where FBNews.IDNews = (select MAx(FBNews.IDNews) - 1 from FBNews)");
                while (Newsrdr2.Read())
                {
                    byte[] imagedata = (byte[])Newsrdr2["Data"];
                    string img = Convert.ToBase64String(imagedata, 0, imagedata.Length);
                    Image2.ImageUrl = "data:image/png;base64," + img;
                    News1 = Newsrdr2[1].ToString();

                }
                TtNews2.DataBind();
                Newsrdr2.Close();


                #endregion

                #region News3
                SqlDataReader Newsrdr3 = dbm.GetReader("select FBImage.IDNews, TitleNews, ContentNews, IName, Data from FBNews inner join FBImage on FBNews.IDNews = FBImage.IDNews where FBNews.IDNews = (select MAx(FBNews.IDNews) - 2 from FBNews)");
                while (Newsrdr3.Read())
                {
                    byte[] imagedata = (byte[])Newsrdr3["Data"];
                    string img = Convert.ToBase64String(imagedata, 0, imagedata.Length);
                    Image3.ImageUrl = "data:image/png;base64," + img;
                    News1 = Newsrdr3[1].ToString();

                }
                TtNews3.DataBind();
                Newsrdr3.Close();


                #endregion









                #region NewsCardsrdr


                SqlDataReader NewsCardsrdr = dbm.GetReader("select FBImage.IDNews, TitleNews, LeadNews, ContentNews, IName, Data from FBNews inner join FBImage on FBNews.IDNews = FBImage.IDNews where FBNews.IDNews = (select MAx(FBNews.IDNews) from FBNews)");

                SqlDataReader NewsCardsrdr2 = dbm.GetReader("select FBImage.IDNews, TitleNews, LeadNews, ContentNews, IName, Data from FBNews inner join FBImage on FBNews.IDNews = FBImage.IDNews where FBNews.IDNews = (select MAx(FBNews.IDNews)  - 1 from FBNews)");

                SqlDataReader NewsCardsrdr3 = dbm.GetReader("select FBImage.IDNews, TitleNews, LeadNews, ContentNews, IName, Data from FBNews inner join FBImage on FBNews.IDNews = FBImage.IDNews where FBNews.IDNews = (select MAx(FBNews.IDNews)  - 2 from FBNews)");

                SqlDataReader NewsCardsrdr4 = dbm.GetReader("select FBImage.IDNews, TitleNews, LeadNews, ContentNews, IName, Data from FBNews inner join FBImage on FBNews.IDNews = FBImage.IDNews where FBNews.IDNews = (select MAx(FBNews.IDNews)  - 3 from FBNews)");

                SqlDataReader NewsCardsrdr5 = dbm.GetReader("select FBImage.IDNews, TitleNews, LeadNews, ContentNews, IName, Data from FBNews inner join FBImage on FBNews.IDNews = FBImage.IDNews where FBNews.IDNews = (select MAx(FBNews.IDNews)  - 4 from FBNews)");

                SqlDataReader NewsCardsrdr6 = dbm.GetReader("select FBImage.IDNews, TitleNews, LeadNews, ContentNews, IName, Data from FBNews inner join FBImage on FBNews.IDNews = FBImage.IDNews where FBNews.IDNews = (select MAx(FBNews.IDNews)  - 5 from FBNews)");

                NewsCards(NewsCardsrdr);
                NewsCards(NewsCardsrdr2);
                NewsCards(NewsCardsrdr3);
                NewsCards(NewsCardsrdr4);
                NewsCards(NewsCardsrdr5);
                NewsCards(NewsCardsrdr6);

                #endregion





                dbm.closeConnection();

            }



        }

        private void NewsCards(SqlDataReader Testrdr)
        {
            while (Testrdr.Read())
            {

                byte[] imagedata = (byte[])Testrdr[5];
                string img = Convert.ToBase64String(imagedata, 0, imagedata.Length);
                string _htmlappend = @"<div class='col-6'>
                                    <img class='card-img-top' src='data:image/jpg;base64," + img + @" ' alt='Card image cap'>
                                        <a style='font-family:'Athiti', sans-serif;'>
                                        <h2><a style='font-size: 18px;'> " + Testrdr[1].ToString() + @" </a></h2>
                                    <p><a style='font-size: 14px;'>" + Testrdr[2].ToString() + @"</a></p>
                                    <p><a class='btn btn-secondary' href='News.aspx?testxxid=" + Testrdr[0].ToString() + @"' role='button'>View details »</a></p>
                                </div>";
                usercontent.Controls.Add(new LiteralControl(_htmlappend));

            }
            
            GridView1.DataSource = Testrdr;
            GridView1.DataBind();
            

        }
                        





    }
}