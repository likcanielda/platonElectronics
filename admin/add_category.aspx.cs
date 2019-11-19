using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class admin_add_category : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\EL-PC\Documents\Visual Studio 2015\WebSites\WebSite1\App_Data\PlatonElectronics.mdf;Integrated Security=True");
    protected void Page_Load(object sender, EventArgs e)
    {
        // Nese admini nuk eshte i loguar behet redirect te faqja e log in-it
        if (Session["admin"] == null)
        {
            Response.Redirect("adminlogin.aspx");
        }


        // Ne Page_Load behet ngarkimi i te gjitha kategorive ekzistuese
        con.Open();
        SqlCommand cmd = con.CreateCommand();
        cmd.CommandType = CommandType.Text;
        cmd.CommandText = "select * from Product_Category";
        cmd.ExecuteNonQuery();
        DataTable dt = new DataTable();
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        da.Fill(dt);
        datalist1.DataSource = dt;
        datalist1.DataBind();
        con.Close();
    }


    protected void button1_Click(object sender, EventArgs e)
    {
        // Behet shtimi i nje kategorie te re
        con.Open();
        SqlCommand cmd = con.CreateCommand();
        cmd.CommandType = CommandType.Text;
        cmd.CommandText = "insert into Product_Category values('" + textbox1.Text + "')";
        cmd.ExecuteNonQuery();
        con.Close();

        Response.Write("<script>alert('Product Category added successfully!');</script>");
        textbox1.Text = string.Empty;
       
    }
}