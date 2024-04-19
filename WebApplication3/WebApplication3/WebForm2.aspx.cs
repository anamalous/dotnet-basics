using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie c = Request.Cookies["usercookie"];
            if(c != null)
            {
                Label1.Text = "welcome " + c["username"];
            }
            else
            {
                Label1.Text = "cookie expired";
            }
            ListBox1.Items.Add(new ListItem("Badminton"));
            ListBox1.Items.Add(new ListItem("Football"));
            ListBox1.Items.Add(new ListItem("Tennis"));
            ListBox1.Items.Add(new ListItem("Basketball"));

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session["sport"] = ListBox1.SelectedItem.Value;
            Response.Redirect("WebForm3.aspx");
        }
    }
}