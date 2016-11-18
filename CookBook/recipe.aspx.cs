using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class recipe : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            string idFromURL = Request.QueryString["id"];
            txtHeader.InnerText = getrecipeTitle(idFromURL);
            txtDescription.InnerText = getrecipeDescription(idFromURL);
            txtSteps.InnerText = getrecipeSteps(idFromURL);
        }
    }

    private string getrecipeTitle(string id)
    {
        string titleFromDB = "";

        string cs = System.Configuration.ConfigurationManager.ConnectionStrings["mysql"].ConnectionString;
        DataTable dt = CookBook.Data.DBmysql.GetRecipe(cs, id);
        foreach (DataRow dr in dt.Rows)
        {
            titleFromDB = dr["title"].ToString();
        }
        return titleFromDB;
    }

    private string getrecipeDescription(string id)
    {
        string descriptionFromDB = "";

        string cs = System.Configuration.ConfigurationManager.ConnectionStrings["mysql"].ConnectionString;
        DataTable dt = CookBook.Data.DBmysql.GetRecipe(cs, id);
        foreach (DataRow dr in dt.Rows)
        {
            descriptionFromDB = dr["description"].ToString();
        }
        return descriptionFromDB;
    }

    private string getrecipeSteps(string id)
    {
        string descriptionFromDB = "";

        string cs = System.Configuration.ConfigurationManager.ConnectionStrings["mysql"].ConnectionString;
        DataTable dt = CookBook.Data.DBmysql.GetRecipe(cs, id);
        foreach (DataRow dr in dt.Rows)
        {
            descriptionFromDB = dr["steps"].ToString();
        }
        return descriptionFromDB;
    }


}