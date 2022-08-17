using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        //in the Next Page Load


        //if ( HttpContext.Current.Request.Cookies["cookiename"] != null )
        //{

        // TextBoxName.Text= HttpContext.Current.Request.Cookies["cookiename"]["UserName"].ToString();



        //TextBoxPassword.Text=HttpContext.Current.Request.Cookies["cookiename"]["Password"].ToString()

        //}

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (RadioButtonList1.SelectedIndex == 0)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = ConfigurationManager.ConnectionStrings["myconn"].ConnectionString;
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select workerEmail ,workerPassword from workersReg where workerEmail=@name and workerPassword=@password ";
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
            if (CheckBox1.Checked == true)
            {
                HttpCookie cookie = new HttpCookie("cookiename");
                cookie.Values.Add("UserName", TextBoxName.Text);

                cookie.Values.Add("Password", TextBoxPassword.Text);

                cookie.Expires = DateTime.Now.AddDays(30);
            }
        }
        else if (RadioButtonList1.SelectedIndex == 0)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = ConfigurationManager.ConnectionStrings["myconn"].ConnectionString;
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select clientEmail ,clientPassword from ClientReg where clientEmail=@name and clientPassword=@password ";
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
            if (CheckBox1.Checked == true)
            {
                HttpCookie cookie = new HttpCookie("cookiename");
                cookie.Values.Add("UserName", TextBoxName.Text);

                cookie.Values.Add("Password", TextBoxPassword.Text);

                cookie.Expires = DateTime.Now.AddDays(30);
            }
        }
        else { Label5.Text = "من فضلك اختار الفئه التى تنتمى اليها"; }
    }
}
