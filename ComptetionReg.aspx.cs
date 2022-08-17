using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;

public partial class ComptetionReg : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Panel1.Visible = false;
        Panel2.Visible = false;
        
    }
    protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
    {
if (RadioButtonList1.SelectedIndex == 0)
        {
            Panel1.Visible = true;

        }
        else
        {
            Panel2.Visible = true;
        }
    }
    protected void BtnSave_Click(object sender, EventArgs e)
    {
        if (RadioButtonList1.SelectedIndex == 0)
        {
            //Get Filename from fileupload control
            string filename = Path.GetFileName(FileUpload1.PostedFile.FileName);
            //Save images into Images folder
            FileUpload1.SaveAs(Server.MapPath("compimage/" + filename));
            SqlConnection con = new SqlConnection();
            con.ConnectionString = ConfigurationManager.ConnectionStrings["myconn"].ConnectionString;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "insert into compStudUser (compStudName,compStudCountry,compStudFac,compStudUniv,compStudUnivImag,compStudClass,compStudId)values(@compStudName,@compStudCountry,@compStudFac,@compStudUniv,@compStudUnivImag,@compStudClass,@compStudId)";
            SqlParameter p1 = new SqlParameter("@compStudName", txtBoxName.Text);
            SqlParameter p2 = new SqlParameter("@compStudCountry", txtBoxCoun.Text);
            SqlParameter p3 = new SqlParameter("@compStudFac", txtBoxfac.Text);
            SqlParameter p4 = new SqlParameter("@compStudUniv", txtBoxUniv.Text);
            SqlParameter p5 = new SqlParameter("@compStudUnivImag", "compimage/" + filename);
            SqlParameter p6 = new SqlParameter("@compStudClass", txtBoxClass.Text);
            SqlParameter p7 = new SqlParameter("@compStudId", "compimage/" + filename);
            cmd.Parameters.Add(p1);
            cmd.Parameters.Add(p2);
            cmd.Parameters.Add(p3);
            cmd.Parameters.Add(p4);
            cmd.Parameters.Add(p5);
            cmd.Parameters.Add(p6);
            cmd.Parameters.Add(p7);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

        }
        else
        {
            //Get Filename from fileupload control
            string filename = Path.GetFileName(FileUpload1.PostedFile.FileName);
            //Save images into Images folder
            FileUpload1.SaveAs(Server.MapPath("compimage/" + filename));
            SqlConnection con = new SqlConnection();
            con.ConnectionString = ConfigurationManager.ConnectionStrings["myconn"].ConnectionString;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "insert into compUserGrad (compUserGradName,compUserGradCountry,compUserGradFac,compUserGradUniv,compUserGradIdd,compUserGradcard,compUserGradYearGrad)values(@compUserGradName,@compUserGradCountry,@compUserGradFac,@compUserGradUniv,@compUserGradIdd,@compUserGradcard,@compUserGradYearGrad)";
            SqlParameter p1 = new SqlParameter("@compUserGradName", textName.Text);
            SqlParameter p2 = new SqlParameter("@compUserGradCountry", textCountry.Text);
            SqlParameter p3 = new SqlParameter("@compUserGradFac", TextFac.Text);
            SqlParameter p4 = new SqlParameter("@compUserGradUniv", textUniv.Text);
            SqlParameter p5 = new SqlParameter("@compUserGradIdd", "compimage/" + filename);
            SqlParameter p6 = new SqlParameter("@compUserGradcard", "compimage/" + filename);
            SqlParameter p7 = new SqlParameter("@compUserGradYearGrad",TextYear.Text);
            cmd.Parameters.Add(p1);
            cmd.Parameters.Add(p2);
            cmd.Parameters.Add(p3);
            cmd.Parameters.Add(p4);
            cmd.Parameters.Add(p5);
            cmd.Parameters.Add(p6);
            cmd.Parameters.Add(p7);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}