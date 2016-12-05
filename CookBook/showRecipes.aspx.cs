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
            DropdownItems();
            divData.InnerHtml = GetRecipeFromDatabase();
        }
    }

    private string GetRecipeFromDatabase()
    {
        try
        {
            string result = "";
            string cs = System.Configuration.ConfigurationManager.ConnectionStrings["mysql"].ConnectionString;
            DataTable dt = CookBook.Data.DBmysql.GetRecipeInfo(cs,Session["id"].ToString());
            foreach (DataRow dr in dt.Rows)
            {
                result += "<div class='media list-group-item'><a class='media-left waves-light' href='recipe.aspx?id=" + dr["id"].ToString() + "'><img class='rounded-circle' height='100' width='100' src='Images/foodpng.jpg' alt='Generic placeholder image'></a><div class='media-body '><h2 class='media-heading'>" + dr["title"].ToString() + "</h2><p>" + dr["description"].ToString() + "</p></div></div>";
            }
            return result;
        }
        catch (Exception ex)
        {

            return ex.Message;
        }
    }



    private void DropdownItems()
    {
        try
        {
            string cs = System.Configuration.ConfigurationManager.ConnectionStrings["mysql"].ConnectionString;
            DataTable dt = CookBook.Data.DBmysql.GetRecipeInfo(cs, Session["id"].ToString());
            foreach (DataRow dr in dt.Rows)
            {
                if (ddCategory.Items.FindByText(dr["category"].ToString()) == null)
                {
                    ddCategory.Items.Add(dr["category"].ToString());
                }
            }
        }
        catch (Exception ex)
        {
            lblModalTitle.Text = ex.Message;
            ScriptManager.RegisterStartupScript(Page, Page.GetType(), "myModal", "$('#myModal').modal();", true);
            upModal.Update();
        }
    }

    protected void ddCategory_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            string cs = System.Configuration.ConfigurationManager.ConnectionStrings["mysql"].ConnectionString;
            if (ddCategory.SelectedValue == "Select Category")
            {
                divData.InnerHtml = GetRecipeFromDatabase();
            }
            else
            {
                string result = "";
                DataTable dt = CookBook.Data.DBmysql.GetRecipeByGategory(cs, ddCategory.SelectedValue);
                foreach (DataRow dr in dt.Rows)
                {
                    result += "<div class='media list-group-item'><a class='media-left waves-light' href='recipe.aspx?id=" + dr["id"].ToString() + "'><img class='rounded-circle' height='100' width='100' src='Images/foodpng.jpg' alt='Generic placeholder image'></a><div class='media-body '><h2 class='media-heading'>" + dr["title"].ToString() + "</h2><p>" + dr["description"].ToString() + "</p></div></div>";
                }
                divData.InnerHtml = result;
            }
        }
        catch (Exception ex)
        {

            lblModalTitle.Text=ex.Message;
            ScriptManager.RegisterStartupScript(Page, Page.GetType(), "myModal", "$('#myModal').modal();", true);
            upModal.Update();
        }
    }
}