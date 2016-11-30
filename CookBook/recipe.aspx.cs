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
            btnEdit.HRef = "editRecipe.aspx?id=" + idFromURL;
            string header = CookBook.Data.DBmysql.getrecipeTitle(idFromURL);
            string description = CookBook.Data.DBmysql.getrecipeDescription(idFromURL);
            string ingredients = CookBook.Data.DBmysql.getrecipeIngredients(idFromURL);
            string steps = CookBook.Data.DBmysql.getrecipeSteps(idFromURL);
            description = description.Replace(System.Environment.NewLine, "<br/>");
            ingredients = ingredients.Replace(System.Environment.NewLine, "<br/>");
            steps = steps.Replace(System.Environment.NewLine, "<br/>");
            txtHeader.InnerText = header;
            txtDescription.InnerHtml = description;
            txtIngredients.InnerHtml = ingredients;
            txtSteps.InnerHtml = steps;
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


    protected void btnConfirm_Click(object sender, EventArgs e)
    {
        lblModalTitle.Text = "Do you really want to delete this recipe?";
        ScriptManager.RegisterStartupScript(Page, Page.GetType(), "myModal", "$('#myModal').modal();", true);
        upModal.Update();
    }
}