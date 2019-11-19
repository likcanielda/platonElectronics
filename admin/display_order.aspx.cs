using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class admin_display_order : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\EL-PC\Documents\Visual Studio 2015\WebSites\WebSite1\App_Data\PlatonElectronics.mdf;Integrated Security=True");
    protected void Page_Load(object sender, EventArgs e)
    {
        con.Open();
         
        //Me ane te nje procedure llogaritet nje total i te gjithe porosive qe gjenden ne tabelen Orders

        SqlCommand comm = new SqlCommand();
        comm.Connection = con;
        comm.CommandType = CommandType.StoredProcedure;
        comm.CommandText = "SP_total_orders";
        int total = Convert.ToInt32(comm.ExecuteScalar());
        label1.Text = total.ToString();

        //Behet ngarkimi i te gjitha porosive te renditura nga ajo me e fundit
        SqlCommand cmd2 = con.CreateCommand();
        cmd2.CommandType = CommandType.Text;
        cmd2.CommandText = " select * from Orders order by id desc";
        cmd2.ExecuteNonQuery();
        DataTable dt = new DataTable();
        SqlDataAdapter da = new SqlDataAdapter(cmd2);
        da.Fill(dt);
        repeater1.DataSource = dt;
        repeater1.DataBind();
        con.Close();
    }


    protected void button_total_Click(object sender, EventArgs e)
    {
        //Me ane te funksionit Return_total_orders_per_country behet llogaritja e porosive sipas shtetit, ku ky i fundit merret
        // si parameter nga textbox-i i dhene
        con.Open();
        string country = textbox1.Text;
        SqlCommand cmd1 = con.CreateCommand();
        cmd1.CommandType = CommandType.Text;
        cmd1.CommandText = "select dbo.[Return_total_orders_per_country](@country);";
        cmd1.Parameters.AddWithValue("@country", country);

        label2.Text = cmd1.ExecuteScalar().ToString();

        con.Close();
    }
}


