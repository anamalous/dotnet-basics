using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            DateTime d = Calendar1.SelectedDate;
            DateTime start = new DateTime(2023, 01, 03);
            DateTime end = new DateTime(2023, 01, 18);

            Label1.Visible = true;

            if (d < start || d > end)
            {
                Label1.Text = "Choose date within deadline";
            }
            else
            {
                Label1.Text = "submission expected on " + d.ToShortDateString();
            }
        }

        protected void AdRotator1_AdCreated(object sender, AdCreatedEventArgs e)
        {

        }
    }
}