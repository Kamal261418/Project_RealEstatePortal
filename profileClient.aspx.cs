using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;

public partial class profileClient : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
        DataTable ds = new DataTable();
        SqlConnection con = new SqlConnection();
        con.ConnectionString = ConfigurationManager.ConnectionStrings["myconn"].ConnectionString;
        SqlDataAdapter da = new SqlDataAdapter("select top 5 postname from posts", con);
        da.Fill(ds);
        DataList1.DataSource = ds;
        DataList1.DataBind();
        DataTable dss = new DataTable();
        SqlDataAdapter daa = new SqlDataAdapter("select top 5 newsID,newsname,newsDetails from news", con);
        daa.Fill(dss);
        ds1.DataSource = dss;
        ds1.DataBind();
        
        SqlDataAdapter dah = new SqlDataAdapter("select clientphot from ClientReg", con);
       
        Label2.Text = Session["logid"].ToString();
    }
    protected void DataList1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void ds1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}