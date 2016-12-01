using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Web.Security;

public partial class login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        try
        {
     
            string cs = System.Configuration.ConfigurationManager.ConnectionStrings["mysql"].ConnectionString;
            DataTable dt = CookBook.Data.DBmysql.LogIn(cs, tbUsername.Text, tbPasword.Text);
            foreach (DataRow dr in dt.Rows)
            {
                Session["id"] = dr["id"].ToString();
                Session["user"] = dr["username"].ToString();
                FormsAuthentication.RedirectFromLoginPage(Session["user"].ToString(), true);
            }
            if (Session["id"] == null && Session["user"] == null)
            {
                lblModalTitle.Text = "Username or password is wrong!";
                ScriptManager.RegisterStartupScript(Page, Page.GetType(), "myModal", "$('#myModal').modal();", true);
                upModal.Update();
            }

        }
        catch (Exception ex)
        {
            lblModalTitle.Text = ex.Message;
            ScriptManager.RegisterStartupScript(Page, Page.GetType(), "myModal", "$('#myModal').modal();", true);
            upModal.Update();
        }
    }
}