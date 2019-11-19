using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class admin_delete_category : System.Web.UI.Page
{

    SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\EL-PC\Documents\Visual Studio 2015\WebSites\WebSite1\App_Data\PlatonElectronics.mdf;Integrated Security=True");
    string category;
    protected void Page_Load(object sender, EventArgs e)
    {  
        // Marrim emrin e kategorise qe do te fshijme dhe e vendosim si parameter per transaksionin brenda procedures
        category = Request.QueryString["category"].ToString();
        con.Open();
        SqlCommand cmd = con.CreateCommand();
        cmd.CommandType = CommandType.Text;
        cmd.CommandText = "dbo.DeleteCategoryTransaction @category ='"+category.ToString()+"';";
        cmd.ExecuteNonQuery();
        con.Close();

        Response.Redirect("add_category.aspx");
    }
}