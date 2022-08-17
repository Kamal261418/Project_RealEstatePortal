using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
public partial class MasterPage : System.Web.UI.MasterPage
{ 
 
    protected void Page_Load(object sender, EventArgs e)
    {
        //if (Session["logid"] != null)
        //{
        //    label1.Visible = false;
        //    label2.Visible = false;
        //    label3.Text = Session["logid"].ToString();
        //}
        //else
        //{
        //    label3.Visible = false;
        //}
        //if (Session["about"] != null)
        //{
        //    Label4.Height = 85;
        //    Label4.Text= Session["about"].ToString() + "</br>";
        //}
    }
    protected void TextBox111_TextChanged(object sender, EventArgs e)
    {

    }
   
}

