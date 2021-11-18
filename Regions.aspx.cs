using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OracleClient;

namespace WebApplication3
{
    public partial class Regions : Page
    {
        string ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {
            ConnectionString = "Data Source=XE;User ID=hr;Password=hr;Unicode=True";
            tjobid0.Text = "";
            TextBox5.Text = "";
        }

     

        protected void Button1_Click1(object sender, EventArgs e)
        {
            ConnectionString = "Data Source=XE;User ID=hr;Password=hr;Unicode=True";
            OracleConnection con = new OracleConnection(ConnectionString);
            con.Open();


            OracleCommand cmd = new OracleCommand("Insert into regions values('" + tjobid0.Text + "','" + TextBox5.Text + "')", con);
            cmd.ExecuteNonQuery();
            tjobid0.Text = "";
            TextBox5.Text = "";
        }

        
    }
}