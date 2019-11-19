using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class admin_add_product : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\EL-PC\Documents\Visual Studio 2015\WebSites\WebSite1\App_Data\PlatonElectronics.mdf;Integrated Security=True");
    string a, b;
    protected void Page_Load(object sender, EventArgs e)
    {
        // Nese admini nuk eshte i loguar behet redirect te faqja e log in-it
        if (Session["admin"] == null)
        {
            Response.Redirect("adminlogin.aspx");
        }

        //Behet mbushja e DropDownList-es me kategorite e produkteve nga databaza
        if (IsPostBack) return;
        dropdownlist1.Items.Clear();


        con.Open();
        SqlCommand cmd = con.CreateCommand();
        cmd.CommandType = CommandType.Text;
        cmd.CommandText = "select * from Product_Category";
        cmd.ExecuteNonQuery();
        DataTable dt = new DataTable();
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        da.Fill(dt);
        foreach(DataRow dr in dt.Rows)
        {
            dropdownlist1.Items.Add(dr["product_category"].ToString());
        }
        con.Close();

    }

    protected void button1_Click(object sender, EventArgs e)
    {   //Behet shtimi i te dhenave te marra nga forma ne tabelen Products
        a = Class1.GetRandomPassword(10).ToString();
        fileUpload1.SaveAs(Request.PhysicalApplicationPath+"./images/"+ a + fileUpload1.FileName.ToString());
        b= "images/" + a + fileUpload1.FileName.ToString();

        con.Open();
        SqlCommand cmd = con.CreateCommand();
        cmd.CommandType = CommandType.Text;
        cmd.CommandText = "insert into Products values('"+textbox1.Text+"','"+textbox2.Text+"',"+textbox3.Text+","+textbox4.Text+",'"+b.ToString()+"','"+dropdownlist1.SelectedItem.ToString()+"')";
        cmd.ExecuteNonQuery();
        con.Close();
    }
}