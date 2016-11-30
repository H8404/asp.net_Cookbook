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
            txtHeader.InnerText = CookBook.Data.DBmysql.getrecipeTitle(idFromURL);
            txtDescription.InnerText = CookBook.Data.DBmysql.getrecipeDescription(idFromURL);
            txtIngredients.InnerHtml = CookBook.Data.DBmysql.getrecipeIngredients(idFromURL);
            txtSteps.InnerHtml = CookBook.Data.DBmysql.getrecipeSteps(idFromURL);
        }
    }


    protected void btnRemove_Click(object sender, EventArgs e)
    {
        try
        {
            string idFromURL = Request.QueryString["id"];
            string cs = System.Configuration.ConfigurationManager.ConnectionStrings["mysql"].ConnectionString;
            CookBook.Data.DBmysql.RemoveRecipe(cs, idFromURL);
        }
        catch (Exception ex)
        {
            lblModalTitle.Text = ex.Message;
            ScriptManager.RegisterStartupScript(Page, Page.GetType(), "myModal", "$('#myModal').modal();", true);
            upModal.Update();
        }
        finally
        {
            Response.Redirect("showRecipes.aspx");
        }
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {

    }

    protected void btnConfirm_Click(object sender, EventArgs e)
    {
        lblModalTitle.Text = "Do you really want to delete this recipe?";
        ScriptManager.RegisterStartupScript(Page, Page.GetType(), "myModal", "$('#myModal').modal();", true);
        upModal.Update();
    }
}