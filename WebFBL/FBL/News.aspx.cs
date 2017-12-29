using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FBL
{
    public partial class test2 : System.Web.UI.Page
    {

        StringBuilder Test00 = new StringBuilder();
        protected void Page_Load(object sender, EventArgs e)
        {
            DBMater dbm = new DBMater();
            Label1.Text = Request.QueryString["testxxid"].ToString();
            int TNews = int.Parse(Label1.Text);
            SqlDataReader Newsrdr = dbm.GetReader("select FBImage.IDNews, TitleNews, LeadNews, ContentNews, IName, Data from FBNews inner join FBImage on FBNews.IDNews = FBImage.IDNews where FBNews.IDNews = " + TNews + "");

            //SqlDataReader Newsrdr = dbm.GetReader("select FBImage.IDNews, TitleNews, LeadNews, ContentNews, IName, Data from FBNews inner join FBImage on FBNews.IDNews = FBImage.IDNews where FBNews.IDNews = 2");

            while (Newsrdr.Read())
            {
                byte[] imagedata = (byte[])Newsrdr["Data"];
                string img = Convert.ToBase64String(imagedata, 0, imagedata.Length);
                Image1.ImageUrl = "data:image/png;base64," + img;

                Test00.Append("<a>" + Newsrdr[1] + "</a><br/><br/>");
                Test00.Append("<a>" + Newsrdr[2] + "</a><br/><br/>");
                Test00.Append("<a>" + Newsrdr[3] + "</a><br/><br/>");


            }

            Label1.Controls.Add(new Literal { Text = Test00.ToString() });
            Newsrdr.Close();




        }
    }
}