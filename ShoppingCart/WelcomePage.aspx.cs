using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ShoppingCart
{
    public partial class WelcomePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ShoppingPlazaButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Webforms/ShoppingPlazaForm.aspx");
        }

        protected void ExitBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Webforms/ExitPage.aspx");
        }
    }
}