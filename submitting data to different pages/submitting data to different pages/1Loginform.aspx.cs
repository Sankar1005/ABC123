using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace submitting_data_to_different_pages
{
    public partial class Loginform : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                txtname.Focus();
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtname.Text == "admin" && txtpwd.Text == "admin")
                Server.Transfer("2success.aspx");
            else
                Response.Redirect("3failure.aspx?Na me="+txtname.Text);
        }

        protected void btnReset_Click(object sender, EventArgs e)
        {
            txtname.Text = txtpwd.Text = "";
            txtname.Focus();
        }
    }
}