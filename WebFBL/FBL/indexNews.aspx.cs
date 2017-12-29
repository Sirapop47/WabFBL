using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FBL
{
    public partial class indexNews : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                DBMater dbm = new DBMater();
                SqlDataReader NewsCardsrdr = dbm.GetReader("select FBImage.IDNews, TitleNews, LeadNews, ContentNews, IName, Data from FBNews inner join FBImage on FBNews.IDNews = FBImage.IDNews ORDER BY IDNews DESC;");

                NewsCards(NewsCardsrdr);
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