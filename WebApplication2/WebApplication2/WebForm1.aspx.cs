using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Button1_Click(object sender, EventArgs e)
        {
            ViewState["name"] = TextBox1.Text;
            ViewState["age"] = TextBox2.Text;
            TextBox1.Text = "";
            TextBox2.Text = "";
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            TextBox1.Text = ViewState["name"].ToString();
            TextBox2.Text = ViewState["age"].ToString();
        }
        protected void Button4_Click(object sender, EventArgs e)
        {
            String url = "WebForm2.aspx?";
            url += "name=" + TextBox1.Text + "&";
            url += "stream=" + RadioButtonList1.SelectedItem.Value + "&";
            url += "fav=" + Server.UrlEncode(ListBox1.SelectedItem.Value);
            Response.Redirect(url);
        }
    }
}