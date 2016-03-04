using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnlogin_Click(object sender, EventArgs e)
    {
        try
        {
            if (tbid.Text == "")
            {
                lblerr.Text = "Please input user ID";
                return;
            }
            if (tbpass.Text == "")
            {
                lblerr.Text = "Please input user password";
                return;
            }
            Response.Redirect("~\\adminhome.aspx");
        }
        catch (Exception ex)
        {

            lblerr.Text = ex.Message;
        }
    }
}