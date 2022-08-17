using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class WorkersProfile : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string projectDetails = Request.QueryString["projectDetails"];
        string Projecthome = Request.QueryString["Projecthome"];
        string clientdate = Request.QueryString["clientdate"];
        string clientcountry = Request.QueryString["clientcountry"];
        string clientphone = Request.QueryString["Clientemail"];
        Label4.Text = projectDetails;
        Label5.Text = Projecthome;
        Label6.Text = clientdate;
        Label7.Text = clientcountry;
        Label8.Text = clientphone;
    }
}