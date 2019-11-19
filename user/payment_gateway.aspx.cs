using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class user_payment_gateway : System.Web.UI.Page
{
    int total = 0;
    string s;
    string t;
    string[] a = new string[6];
    string order_no;

    protected void Page_Load(object sender, EventArgs e)
    {
        // Merret totali nga cookies

        if (Request.Cookies["cookie1"] != null)
        {
            s = Convert.ToString(Request.Cookies["cookie1"].Value);
            string[] strArr = s.Split('|');
            for (int i = 0; i < strArr.Length; i++)
            {
                t = Convert.ToString(strArr[i].ToString());
                string[] strArr1 = t.Split(',');
                for (int j = 0; j < strArr1.Length; j++)
                {
                    a[j] = strArr1[j].ToString();
                }

                total = total + (Convert.ToInt32(a[2].ToString()) * Convert.ToInt32(a[3].ToString()));
            }

            Session["total"] = total.ToString();
        }

        //Implementimi i paypal

        order_no = Class1.GetRandomPassword(10).ToString();
        Session["order_no"] = order_no.ToString();

        Response.Write("<form action='https://www.sandbox.paypal.com/cgi-bin/webscr' method='post' name='buyCredits' id='buyCredits'>");
        Response.Write("<input type='hidden' name='cmd' value='_xclick' >");
        Response.Write("<input type='hidden' name='business' value='elda47502-facilitator@gmail.com' >");
        Response.Write("<input type='hidden' name='currency_code' value='USD' >");
        Response.Write("<input type='hidden' name='item_name' value='payment for purchase' >");
        Response.Write("<input type='hidden' name='item_number' value='0' >");
        Response.Write("<input type='hidden' name='amount' value='" + Session["total"].ToString() + "' >");
        Response.Write("<input type='hidden' name='return' value='http://localhost:17170/user/payment_success.aspx?order=" + order_no.ToString()+"' >");
        Response.Write("</form>");

        Response.Write("<script type='text/javascript'>");
        Response.Write("document.getElementById('buyCredits').submit();");
        Response.Write("</script>");

        //perfundimi i implementimit
    }
}