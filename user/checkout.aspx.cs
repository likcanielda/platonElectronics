using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class user_checkout : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //Nese perdoruesi nuk eshte i loguar, i behet ridrejtimi te faqja e login-it te perdoruesve
        // Nese eshte i loguar, ridrejtohet te faqja update_order_details.aspx ku i jepet mundesia te update-oje te dhenat
        if (Session["user"] == null)
        {
            Response.Redirect("login.aspx");
        }
        else
        {
           Response.Redirect("update_order_details.aspx");
        }
    }
}