using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class admin_delete_order : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // Behet fshirja e nje Order-i nga tabela Orders
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\EL-PC\Documents\Visual Studio 2015\WebSites\WebSite1\App_Data\PlatonElectronics.mdf;Integrated Security=True");
        string id;
        id = Request.QueryString["id"].ToString();
        con.Open();
        SqlCommand cmd = con.CreateCommand();
        cmd.CommandType = CommandType.Text;
        cmd.CommandText = "delete from Orders where id='" + Convert.ToInt32(id.ToString()) + "'";
        cmd.ExecuteNonQuery();

        //Me ane te triggerit qe eshte krijuar, behet fshirja e Order_Details ne fshirje te nje Order-i

        Response.Redirect("display_order.aspx");
    }
}
