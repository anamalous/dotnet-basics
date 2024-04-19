using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (PreviousPage != null)
            {
                 TextBox t1 = (TextBox)PreviousPage.FindControl("TextBox1");
                 TextBox t2 = (TextBox)PreviousPage.FindControl("TextBox2");
                 TextBox2.Text = t1.Text + "\n" + t2.Text;
            }
            else
            {
                String n = Request.QueryString["name"];
                String s = Request.QueryString["stream"];
                String f = Request.QueryString["fav"];
                TextBox2.Text = n + "\n" + s + "\n" + f;
            }

        }
    }
}