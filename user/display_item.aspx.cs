using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class user_display_item : System.Web.UI.Page
{
    // Shfaqen te gjitha produktet qe gjenden ne databaze

    SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\EL-PC\Desktop\el\MSc\WebSite1\App_Data\PlatonElectronics.mdf;Integrated Security=True");
    protected void Page_Load(object sender, EventArgs e)
    {
        con.Open();
        SqlCommand cmd = con.CreateCommand();
        cmd.CommandType = CommandType.Text;

        if(Request.QueryString["category"]== null)
        {
            cmd.CommandText = "select * from Products";
        }
        else
        {
            cmd.CommandText = "select * from Products where product_category='"+ Request.QueryString["category"] + "'";
        }

        if (Request.QueryString["category"] == null && Request.QueryString["search"] != null)
        {
            cmd.CommandText = "select * from Products where product_name like ('%" + Request.QueryString["search"].ToString() + "%')";
        }
        cmd.ExecuteNonQuery();
        DataTable dt = new DataTable();
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        da.Fill(dt);
        repeater1.DataSource = dt;
        repeater1.DataBind();
        con.Close();
    }
}