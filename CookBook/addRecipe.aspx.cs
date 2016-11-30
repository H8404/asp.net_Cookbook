using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class addRecipe : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnSaveToDatabase_Click(object sender, EventArgs e)
    {
        try
        {
            string cs = System.Configuration.ConfigurationManager.ConnectionStrings["mysql"].ConnectionString;
            CookBook.Data.DBmysql.InsertIntoRecipe(cs, tbTitle.Text, tbDescription.Text, tbCategory.Text, tbIngredients.Text, tbSteps.Text);
            lblModalTitle.Text = "Recipe was added succesfully!";
            ScriptManager.RegisterStartupScript(Page, Page.GetType(), "myModal", "$('#myModal').modal();", true);
            upModal.Update();
        }
        catch (Exception ex)
        {
           lblModalTitle.Text = ex.Message;
           ScriptManager.RegisterStartupScript(Page, Page.GetType(), "myModal", "$('#myModal').modal();", true);
           upModal.Update();
        }
        finally
        {
            tbTitle.Text = "";
            tbDescription.Text = "";
            tbCategory.Text = "";
            tbIngredients.Text = "";
            tbSteps.Text = "";
        }
    }

}