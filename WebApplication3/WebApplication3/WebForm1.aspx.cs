using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            HttpCookie c = new HttpCookie("usercookie");
            c["username"] = TextBox1.Text;
            c["email"] = TextBox2.Text;

            c.Expires=DateTime.Now.AddMinutes(15);

            Response.Cookies.Add(c);
            Response.Redirect("WebForm2.aspx");
        }
    }
}