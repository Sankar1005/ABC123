using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace submitting_data_to_different_pages
{
    public partial class _3failure : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Control ctrl = PreviousPage.FindControl("txtName");
            TextBox tb = (TextBox)ctrl;
            string Name = tb.Text;
            Response.Write("Hello " + Name + " ,have a nice day");
        }
    }
}