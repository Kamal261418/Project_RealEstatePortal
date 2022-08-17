using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;


public partial class newsDetails : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //SqlConnection con = new SqlConnection();
        //con.ConnectionString = ConfigurationManager.ConnectionStrings["myconn"].ConnectionString;
        //SqlCommand cmd = new SqlCommand();
        //cmd.Connection = con;
        //DataTable dss = new DataTable();
        //SqlDataAdapter daa = new SqlDataAdapter("select newsDetails where newsid=@newsid from news", con);
        //SqlParameter p1 =new SqlParameter  ("@newsid",);
        //cmd.Parameters.Add(p1);
        //daa.Fill(dss);
        //Literal1.Text = dss.ToString();
        //Literal1.DataBind(); 
        Label4.Text = Request.QueryString["newsid"];
      
    }
}