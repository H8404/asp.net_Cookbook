using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class signup : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        if (tbPasword.Text == tbPassword2.Text)
        {
            try
            {
                string cs = System.Configuration.ConfigurationManager.ConnectionStrings["mysql"].ConnectionString;
                CookBook.Data.DBmysql.InsertIntoUsers(cs, tbUsername.Text, tbPasword.Text);
                Response.Redirect("login.aspx");
            }
            catch (Exception ex)
            {
                lblModalTitle.Text = ex.Message;
                ScriptManager.RegisterStartupScript(Page, Page.GetType(), "myModal", "$('#myModal').modal();", true);
                upModal.Update();
            }

        }else
        {
            lblModalTitle.Text = "Passwords don't match!";
            ScriptManager.RegisterStartupScript(Page, Page.GetType(), "myModal", "$('#myModal').modal();", true);
            upModal.Update();
        }
    }
}