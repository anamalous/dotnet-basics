using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication6
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        public string course = "computer science";
        protected void Page_Load(object sender, EventArgs e)
        {
            Dictionary<int,string> subj = new Dictionary<int, string>();
            subj.Add(1, "cloud computing");
            subj.Add(2, "artificial intelligence");
            subj.Add(3, "networks and connectivity");
            subj.Add(4, "database systems");

            ListBox1.DataSource = subj;
            ListBox1.DataTextField="Value";
            ListBox1.DataValueField = "Key";
            ListBox1.DataBind();
            
            this.DataBind();
        }

    }
}