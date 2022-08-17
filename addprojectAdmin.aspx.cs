using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.IO;
public partial class addprojectAdmin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void save_Click(object sender, EventArgs e)
    {
        //Get Filename from fileupload control
        string filename = Path.GetFileName(FileUpload1.PostedFile.FileName);
        //Save images into Images folder
        FileUpload1.SaveAs(Server.MapPath("proimage/" + filename));
        SqlConnection con = new SqlConnection();
        con.ConnectionString = ConfigurationManager.ConnectionStrings["myconn"].ConnectionString;
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = con;
        cmd.CommandText = "INSERT INTO Projects(ProjectName,ProjectImage,ProjectDetails,Projecthome,projecttrade,projectwork) VALUES (@ProjectName,@ProjectImage,@ProjectDetails,@Projecthome,@projecttrade,@projectwork)";
        SqlParameter p1 = new SqlParameter("@ProjectName", TextBoxname.Text);
        SqlParameter p2 = new SqlParameter("@ProjectImage", "proimage/" + filename);
        SqlParameter p3 = new SqlParameter("@ProjectDetails", TextBoxdet.Text);
        SqlParameter p4 = new SqlParameter("@Projecthome", TextBoxhome.Text);
        SqlParameter p5 = new SqlParameter("@projecttrade", TextBoxtrade.Text);
        SqlParameter p6 = new SqlParameter("@projectwork", TextBoxwork.Text);
              cmd.Parameters.Add(p1);
        cmd.Parameters.Add(p2);
        cmd.Parameters.Add(p3);
        cmd.Parameters.Add(p4);
        cmd.Parameters.Add(p5);
        cmd.Parameters.Add(p6);
                con.Open();
        cmd.ExecuteNonQuery();
        con.Close();
    }
}