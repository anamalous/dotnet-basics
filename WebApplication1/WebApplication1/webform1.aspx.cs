using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class webform1 : System.Web.UI.Page
    {
        String user = "user1";
        String passwd = "pass1234";
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String u = TextBox1.Text;
            String p = TextBox2.Text;
            if(u==user && p == passwd)
            {
                Label1.Visible = true;
                Button2.Visible= true;
                Label1.Text = "welcome " + u;
                if (RadioButtonList1.SelectedIndex == 0)
                {
                    Label1.ForeColor = System.Drawing.Color.Red;
                }
                if (RadioButtonList1.SelectedIndex == 1)
                {
                    Label1.ForeColor = System.Drawing.Color.Green;
                }
                if (RadioButtonList1.SelectedIndex == 2)
                {
                    Label1.ForeColor = System.Drawing.Color.Blue;
                }
                if (RadioButtonList1.SelectedIndex == -1)
                {
                    Label1.Text = "invalid formatting";
                }
                if (CheckBoxList1.Items[0].Selected)
                {
                    Label1.Font.Bold = true;
                }
                if (CheckBoxList1.Items[1].Selected)
                {
                    Label1.Font.Italic = true;
                }
                if (CheckBoxList1.Items[2].Selected)
                { 
                    Label1.Font.Underline = true;
                }
            }
            else
            {
                Label1.Visible = true;
                Label1.Text = "invalid credentials";
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Server.Transfer("webform2.aspx");
        }
    }
}