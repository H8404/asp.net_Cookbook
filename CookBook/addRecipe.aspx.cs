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
            /*DataTable dt = CookBook.Data.DBmysql.GetMySql(cs);
            gvTest.DataSource = dt;
            gvTest.DataBind();*/
        }
        catch (Exception ex)
        {
            lbmsg.Text = ex.Message;
        }
    }
}