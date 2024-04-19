using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.IO;
using System.Xml;
using System.Web.UI.WebControls;
using Microsoft.Ajax.Utilities;

namespace WebApplication6
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string file = Path.Combine(Request.PhysicalApplicationPath, @"App_Data\testfile.xml");
            FileStream fs = new FileStream(file, FileMode.Create);

            XmlTextWriter w = new XmlTextWriter(fs, null);

            w.WriteStartDocument();
            w.WriteStartElement("tvachedule");

                w.WriteStartElement("banner");
                    w.WriteString("channel1");
                w.WriteEndElement();

                w.WriteStartElement("day");
                    w.WriteStartElement("date");
                        w.WriteString("04/02/2023");
                    w.WriteEndElement();

                    w.WriteStartElement("programslot");

                        w.WriteStartElement("time");
                            w.WriteString("10:30");
                        w.WriteEndElement();

                        w.WriteStartElement("title");
                            w.WriteString("program1");
                        w.WriteEndElement();

                        w.WriteStartElement("desc");
                            w.WriteString("this is first program");
                        w.WriteEndElement();

                    w.WriteEndElement();
                w.WriteEndElement();
            w.WriteEndElement();
            w.WriteEndDocument();
            w.Close();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string file = Path.Combine(Request.PhysicalApplicationPath, @"App_Data\testfile.xml");
            FileStream fs = new FileStream(file, FileMode.Open);

            XmlTextReader r = new XmlTextReader(fs);

            StringWriter writer=new StringWriter();

            while(r.Read())
            {
                if (r.Name != "")
                {
                    writer.Write("Name:");
                    writer.Write(r.Name);
                    writer.Write("\n");
                }
                if (r.Value != "")
                {
                    writer.Write("Value:");
                    writer.Write(r.Value);
                    writer.Write("\n");
                }

            }
            TextBox1.Text= writer.ToString();
        }
    }
}