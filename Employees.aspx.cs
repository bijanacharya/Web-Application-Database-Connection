using System;
using System.Data;
using System.Configuration;
using System.Data.OracleClient;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace WebApplication3
{
    public partial class Employees : Page
    {
        string ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            ConnectionString = "Data Source=XE;User ID=hr;Password=hr;Unicode=True";
            TextBox.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
            TextBox5.Text = "";
            TextBox6.Text = "";
            TextBox7.Text = "";
            TextBox8.Text = "";
            TextBox9.Text = "";
            TextBox10.Text = "";
            textbox11.Text = "";

        }


            protected void Button1_Click(object sender, EventArgs e)
        {
            ConnectionString = "Data Source=XE;User ID=hr;Password=hr;Unicode=True";
            OracleConnection con = new OracleConnection(ConnectionString);
            con.Open();


            OracleCommand cmd = new OracleCommand("Insert into employees values('" + TextBox.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "','" + TextBox5.Text + "','" + TextBox6.Text + "','" + TextBox7.Text + "','" + TextBox8.Text + "','" + TextBox9.Text + "','" + TextBox10.Text + "','" + textbox11.Text + "')", con);
            cmd.ExecuteNonQuery();
            //InsertCommand = "INSERT INTO &quot;EMPLOYEES&quot; (&quot;EMPLOYEE_ID&quot;, &quot;FIRST_NAME&quot;, &quot;LAST_NAME&quot;, &quot;EMAIL&quot;, &quot;PHONE_NUMBER&quot;, &quot;HIRE_DATE&quot;, &quot;JOB_ID&quot;, &quot;SALARY&quot;, &quot;COMMISSION_PCT&quot;, &quot;MANAGER_ID&quot;, &quot;DEPARTMENT_ID&quot;) VALUES (:EMPLOYEE_ID, :FIRST_NAME, :LAST_NAME, :EMAIL, :PHONE_NUMBER, :HIRE_DATE, :JOB_ID, :SALARY, :COMMISSION_PCT, :MANAGER_ID, :DEPARTMENT_ID)";
            TextBox.Text = "";
                TextBox2.Text = "";
                TextBox3.Text = "";
                TextBox4.Text = "";
                TextBox5.Text = "";
                TextBox6.Text = "";
                TextBox7.Text = "";
                TextBox8.Text = "";
                TextBox9.Text = "";
                TextBox10.Text = "";
                textbox11.Text = "";


            }
    }
}