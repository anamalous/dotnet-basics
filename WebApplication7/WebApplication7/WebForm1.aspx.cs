using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication7
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string connString;
            SqlConnection cnn;
            connString = "Data Source=.\\SQLEXPRESS01;Initial Catalog=Student;Integrated Security=True";
            cnn = new SqlConnection(connString);
            cnn.Open();
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            String sql = "";
            String newsap = TextBox1.Text;
            String newname = TextBox2.Text;
            String newstream = TextBox3.Text;
            sql = "Insert into Student1 values('" + newsap + "', '" + newname + "','" + newstream + "')";
            command = new SqlCommand(sql, cnn);
            adapter.InsertCommand = new SqlCommand(sql, cnn);
            adapter.InsertCommand.ExecuteNonQuery();
            command.Dispose();
            cnn.Close();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string connString;
            SqlConnection cnn;
            connString = "Data Source=.\\SQLEXPRESS01;Initial Catalog=Student;Integrated Security=True";
            cnn = new SqlConnection(connString);
            cnn.Open();
            SqlCommand command;
            SqlDataReader dataReader;
            String sql, Output = " ";
            sql = "Select * from Student1";
            command = new SqlCommand(sql, cnn);
            dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                Output = dataReader.GetValue(0) + " - " + dataReader.GetValue(1) + " - " + dataReader.GetValue(2);
                ListBox1.Items.Add(Output);
            }
            dataReader.Close();
            cnn.Close();

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            string connString;
            SqlConnection cnn;
            connString = "Data Source=.\\SQLEXPRESS01;Initial Catalog=Student;Integrated Security=True";
            cnn = new SqlConnection(connString);
            cnn.Open();
            SqlCommand command;
            String sql;
            sql = "Select * from Student1";
            command = new SqlCommand(sql, cnn);
            ListBox2.DataSource = command.ExecuteReader();
            ListBox2.DataTextField = "name";
            ListBox2.DataValueField = "sap";
            ListBox2.DataBind();
            command.Dispose();
            cnn.Close();
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            string connString;
            SqlConnection cnn;
            connString = "Data Source=localhost\\SQLEXPRESS01;Initial Catalog=Student;Integrated Security=True";
            cnn = new SqlConnection(connString);
            cnn.Open();
            SqlCommand command;
            SqlDataReader dataReader;
            String sql, Output = " ";
            sql = "Select * from Student1 where roll='"+TextBox4.Text+"'";
            command = new SqlCommand(sql, cnn);
            dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                Label1.Text=dataReader.GetValue(1).ToString();
            }
            dataReader.Close();
            cnn.Close();
        }

        protected void SqlDataSource1_Selecting(object sender, SqlDataSourceSelectingEventArgs e)
        {

        }
    }
}