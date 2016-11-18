using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class showRecipes : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            divData.InnerHtml = GetRecipeFromDatabase();
        }
    }

    private string GetRecipeFromDatabase()
    {
        string result = "";
        string cs = System.Configuration.ConfigurationManager.ConnectionStrings["mysql"].ConnectionString;
        DataTable dt = CookBook.Data.DBmysql.GetRecipeInfo(cs);
        foreach (DataRow dr in dt.Rows)
        {
            result += "<div class='media list-group-item'><a class='media-left waves-light' href='recipe.aspx'><img class='rounded-circle' height='100' width='100' src='Images/foodpng.jpg' alt='Generic placeholder image'></a><div class='media-body '><h2 class='media-heading'>" + dr["title"].ToString() + "</h2><p>" + dr["description"].ToString() + "</p></div></div>";
        }
        return result;
    }
}