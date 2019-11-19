using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class admin_view_full_order : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\EL-PC\Documents\Visual Studio 2015\WebSites\WebSite1\App_Data\PlatonElectronics.mdf;Integrated Security=True");
    int id;
    int total = 0;
    protected void Page_Load(object sender, EventArgs e)
    {
        //Ne klikim te nje 'View full order' nga lista merret id e nje porosie dhe shfaqen te gjitha te dhenat e saj nga tabela Orders
        // si dhe te dhenat nga Order_Details
        id = Convert.ToInt32(Request.QueryString["id"].ToString());

        con.Open();
        SqlCommand cmd1 = con.CreateCommand();
        cmd1.CommandType = CommandType.Text;
        cmd1.CommandText = " select * from Orders where id='"+id+"'";
        cmd1.ExecuteNonQuery();
        DataTable dt1 = new DataTable();
        SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
        da1.Fill(dt1);
        repeater2.DataSource = dt1;
        repeater2.DataBind();
        con.Close();

        con.Open();
        SqlCommand cmd = con.CreateCommand();
        cmd.CommandType = CommandType.Text;
        cmd.CommandText = " select * from Order_Details where order_id='"+id+"'";
        cmd.ExecuteNonQuery();
        DataTable dt = new DataTable();
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        da.Fill(dt);
        foreach(DataRow dr in dt.Rows)
        {
            total = total + Convert.ToInt32(dr["product_price"].ToString()) * Convert.ToInt32(dr["product_qty"].ToString());
        }
        repeater1.DataSource = dt;
        repeater1.DataBind();
        con.Close();

        label1.Text = "Total cost is $"+total.ToString();
    }
}