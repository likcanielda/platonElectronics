using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class user_login : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\EL-PC\Desktop\el\MSc\WebSite1\App_Data\PlatonElectronics.mdf;Integrated Security=True");
    int total;
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void button1_Click(object sender, EventArgs e)
    {
        
        con.Open();
        SqlCommand cmd = con.CreateCommand();
        cmd.CommandType = CommandType.Text;
        cmd.CommandText = "select * from Registration where email='" + textbox1.Text + "' and password='" + textbox2.Text + "'";
        cmd.ExecuteNonQuery();
        DataTable dt = new DataTable();
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        da.Fill(dt);
        total = Convert.ToInt32(dt.Rows.Count.ToString());

        if (total > 0)
        {
            if (Session["checkoutbutton"] == "yes")
            {
                Session["user"] = textbox1.Text;
                Response.Redirect("update_order_details.aspx");
            }
            else
            {
                Session["user"] = textbox1.Text;
                Response.Redirect("display_item.aspx");
            }
        }
        else
        {
            label1.Text = "You have entered invalid credentials!";
        }

        con.Close();
    }
}