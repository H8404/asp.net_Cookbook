using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class editRecipe : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            string idFromURL = Request.QueryString["id"];
            tbTitle.Text = CookBook.Data.DBmysql.getrecipeTitle(idFromURL);
            tbDescription.Text = CookBook.Data.DBmysql.getrecipeDescription(idFromURL);
            tbCategory.Text = CookBook.Data.DBmysql.getrecipeCategory(idFromURL);
            tbIngredients.Text = CookBook.Data.DBmysql.getrecipeIngredients(idFromURL);
            tbSteps.Text = CookBook.Data.DBmysql.getrecipeSteps(idFromURL);
        }
    }

    protected void btnSaveChanges_Click(object sender, EventArgs e)
    {
        try
        {
            string idFromURL = Request.QueryString["id"];
            string cs = System.Configuration.ConfigurationManager.ConnectionStrings["mysql"].ConnectionString;
            CookBook.Data.DBmysql.EditRecipe(cs, idFromURL, tbTitle.Text, tbDescription.Text, tbCategory.Text, tbIngredients.Text, tbSteps.Text);
            lblModalTitle.Text = "Recipe was updated";
            ScriptManager.RegisterStartupScript(Page, Page.GetType(), "myModal", "$('#myModal').modal();", true);
            upModal.Update();
        }
        catch (Exception ex)
        {
            lblModalTitle.Text = ex.Message;
            ScriptManager.RegisterStartupScript(Page, Page.GetType(), "myModal", "$('#myModal').modal();", true);
            upModal.Update();
        }
    }
}