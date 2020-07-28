using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class _Default : System.Web.UI.Page
{
    SqlConnection cn = new SqlConnection();
    protected void Page_Load(object sender, EventArgs e)
    {
        Label1.Text = "";
        cn.ConnectionString = @"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Mansuri\Desktop\RichTextbox\App_Data\Database.mdf;Integrated Security=True;User Instance=True";
    }
    protected void save(object sender, EventArgs e)
    {
        cn.Open();
        SqlCommand cmd = new SqlCommand("INSERT INTO new (data) values (@data)" , cn);
        cmd.Parameters.AddWithValue("@data",text.Text);
        cmd.ExecuteNonQuery();
        text.Text = "";
        cn.Close();

    }

    protected void showData(object sender, EventArgs e)
    {
        cn.Open();
        SqlCommand cmd = new SqlCommand("SELECT data from new where id = 14", cn);
        Label1.Text = cmd.ExecuteScalar().ToString();
        cn.Close();
    }
}