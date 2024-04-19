using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie c = Request.Cookies["usercookie"];
            if (c != null)
            {
                Label1.Text = "Welcome " + c["username"];
            }
            else
            {
                Label1.Text = "Welcome user";
            }
            ListBox1.Items.Add(new ListItem("Pizza"));
            ListBox1.Items.Add(new ListItem("Sandwich"));
            ListBox1.Items.Add(new ListItem("Hot Dog"));
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session["food"] = ListBox1.SelectedItem.Value;
            Response.Redirect("WebForm4.aspx");
        }
    }
}