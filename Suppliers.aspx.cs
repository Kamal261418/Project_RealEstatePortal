using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.IO;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {

    }
    protected void btnSave_Click(object sender, EventArgs e)
    {
        //Get Filename from fileupload control
        string filename = Path.GetFileName(FileUpload1.PostedFile.FileName);
        //Save images into Images folder
        FileUpload1.SaveAs(Server.MapPath("suppimage/" + filename));
       
        SqlConnection con = new SqlConnection();
        con.ConnectionString = ConfigurationManager.ConnectionStrings["myconn"].ConnectionString;
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = con;
        cmd.CommandText = "insert into suppliers (companyName,alternateName,GeogrWork,artWork,mobile,Emaile,workPef,logo,Taxcard,Recordtrading)values(@companyName,@alternateName,@GeogrWork,@artWork,@mobile,@Emaile,@workPef,@logo,@Taxcard,@Recordtrading)";
        SqlParameter p1 = new SqlParameter("@companyName",txtBoxcoName.Text);
        SqlParameter p2 = new SqlParameter("@alternateName", txtBoxaltNAme.Text);
        SqlParameter p3 = new SqlParameter("@GeogrWork",txtBoxGeo.Text);
        SqlParameter p4 = new SqlParameter("@artWork", txtBoxArt.Text);
        SqlParameter p5 = new SqlParameter("@mobile",txtBoxMobile.Text);
        SqlParameter p6 = new SqlParameter("@Emaile",txtEmaile.Text);
        SqlParameter p7 = new SqlParameter("@workPef",txtBoxWork.Text);
        SqlParameter p8 = new SqlParameter("@logo", "suppimage/" + filename);
        SqlParameter p9 = new SqlParameter("@Taxcard", CheckBox1.Checked);
        SqlParameter p10 = new SqlParameter("@Recordtrading", CheckBox2.Checked);
        cmd.Parameters.Add(p1);
        cmd.Parameters.Add(p2);
        cmd.Parameters.Add(p3);
        cmd.Parameters.Add(p4);
        cmd.Parameters.Add(p5);
        cmd.Parameters.Add(p6);
        cmd.Parameters.Add(p7);
        cmd.Parameters.Add(p8);
        cmd.Parameters.Add(p9);
        cmd.Parameters.Add(p10);
        con.Open();
        cmd.ExecuteNonQuery();
        con.Close();
    }
}