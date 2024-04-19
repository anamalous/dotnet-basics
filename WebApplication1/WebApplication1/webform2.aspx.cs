using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class webform2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            TextBox1.Text = "";
            int[] l = ListBox1.GetSelectedIndices();
            if (l.Length < 3)
            {
                Label1.Visible = true;
                Label1.Text = "You have chosen less electives";
                TextBox1.Visible = false;
            } 
            else if (l.Length == 3)
            {
                Label1.Visible = false;
                TextBox1.Visible = true;
                Button2.Visible = true;

                foreach (int i in l)
                {
                    TextBox1.Text += ListBox1.Items[i] + "\n";
                }
            }
            else
            {
                Label1.Visible = true;
                Label1.Text = "Select only 3";
                TextBox1.Visible = false;
            }

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebForm3.aspx");
        }
    }
}