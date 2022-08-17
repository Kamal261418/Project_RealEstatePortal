using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Data.SqlClient;
using System.Configuration;

public partial class regestrationuserbyAdmin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        for (int i = 1; i <= 31; i++)
        {
            ListItem item = new ListItem(i.ToString(), i.ToString());
            DropDownList1.Items.Add(item);
        }
        //for (int x= 1; x <= 12  ; x++)
        //{
        //    ListItem itm = new ListItem(x.ToString(), x.ToString());
        //    DropDownList2.Items.Add(itm);
        //}
        for (int y = DateTime.Now.Year; y >= 1900; y--)
        {
            ListItem items = new ListItem(y.ToString(), y.ToString());
            DropDownList3.Items.Add(items);
        }
        Label1.Text =DropDownList1.SelectedItem.ToString() + " "+ DropDownList2.SelectedItem.ToString() + " " + DropDownList3.SelectedItem.ToString();
    }
    protected void BtnSave_Click(object sender, EventArgs e)
    {
         //Get Filename from fileupload control
string filename = Path.GetFileName(FileUpload1.PostedFile.FileName);
//Save images into Images folder
FileUpload1.SaveAs(Server.MapPath("userimage/" + filename));
        
            SqlConnection con = new SqlConnection();
            con.ConnectionString = ConfigurationManager.ConnectionStrings["myconn"].ConnectionString;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "INSERT INTO ClientReg (clientName,clientDate ,clientCountry,clientPhone,clientEmail,clientPassword,RePwd,clientPhoto)values(@clientName,@clientDate,@clientCountry,@clientPhone,@clientEmail,@clientPassword,@RePwd,@clientPhoto)";
            SqlParameter p1 = new SqlParameter("@clientName", TxtBoxName.Text);
            SqlParameter p2 = new SqlParameter("@clientDate", Label1.Text);
            SqlParameter p3 = new SqlParameter("@clientCountry", TxrBoxCoun.Text);
            SqlParameter p4 = new SqlParameter("@clientPhone", TxtboxPhonr.Text);
            SqlParameter p5 = new SqlParameter("@clientEmail", TxtBoxEmail.Text);
            SqlParameter p6 = new SqlParameter("@clientPassword", TxtBoxPWD.Text);
            SqlParameter p7 = new SqlParameter("@RePwd", TxtBoxRePWD.Text);
            SqlParameter p8 = new SqlParameter("@clientPhoto", "userimage/" + filename);
            cmd.Parameters.Add(p1);
            cmd.Parameters.Add(p2);
            cmd.Parameters.Add(p3);
            cmd.Parameters.Add(p4);
            cmd.Parameters.Add(p5);
            cmd.Parameters.Add(p6);
            cmd.Parameters.Add(p7);
            cmd.Parameters.Add(p8);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            }
    }
