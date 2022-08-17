using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Configuration;
using System.Data.SqlClient;
public partial class AdminReg : System.Web.UI.Page
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
        Label1.Text = DropDownList1.SelectedItem.ToString() + " " + DropDownList2.SelectedItem.ToString() + " " + DropDownList3.SelectedItem.ToString();
    }
    protected void BtnSave_Click(object sender, EventArgs e)
    {
           SqlConnection con = new SqlConnection();
            con.ConnectionString = ConfigurationManager.ConnectionStrings["myconn"].ConnectionString;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "INSERT INTO AdminReg (AdminName,AdminDate ,AdminCountry,AdminPhone,AdminEmail,AdminPassword,AdminRePwd)values(@AdminName,@AdminDate,@AdminCountry,@AdminPhone,@AdminEmail,@AdminPassword,@AdminRePwd)";
            SqlParameter p1 = new SqlParameter("@AdminName", TxtBoxName.Text);
            SqlParameter p2 = new SqlParameter("@AdminDate", Label1.Text);
            SqlParameter p3 = new SqlParameter("@AdminCountry", TxrBoxCoun.Text);
            SqlParameter p4 = new SqlParameter("@AdminPhone", TxtboxPhonr.Text);
            SqlParameter p5 = new SqlParameter("@AdminEmail", TxtBoxEmail.Text);
            SqlParameter p6 = new SqlParameter("@AdminPassword", TxtBoxPWD.Text);
            SqlParameter p7 = new SqlParameter("@AdminRePwd", TxtBoxRePWD.Text);
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
