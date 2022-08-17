using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
public partial class loginAdmin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection();
        con.ConnectionString = ConfigurationManager.ConnectionStrings["myconn"].ConnectionString;

        SqlCommand cmd = new SqlCommand();

        cmd.CommandText = "select AdminEmail ,AdminPassword from AdminReg where AdminEmail=@name and AdminPassword=@password ";
        SqlParameter p1 = new SqlParameter("@name", TextBoxName.Text);
        SqlParameter p2 = new SqlParameter("@Password", TextBoxPassword.Text);
        cmd.Parameters.Add(p1);
        cmd.Parameters.Add(p2);
        cmd.Connection = con;
        con.Open();
        SqlDataReader dr = cmd.ExecuteReader();
        if (dr.Read())
        {
            Session["logid"] = TextBoxName.Text;


            Response.Redirect("profileclient.aspx");


        }
        else
        {
            Label4.Text = "البريد الالكترونى او كلمة المرور غيرصحيحه";
        }
        con.Close();
    }
}