using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class user_update_order_details : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\EL-PC\Desktop\el\MSc\WebSite1\App_Data\PlatonElectronics.mdf;Integrated Security=True");
    protected void Page_Load(object sender, EventArgs e)
    {
        //Textbox-et mbushen automatikisht

        if (IsPostBack)
        {
            return;
        }
        con.Open();
        SqlCommand cmd = con.CreateCommand();
        cmd.CommandType = CommandType.Text;
        cmd.CommandText = "select * from Registration where email='" + Session["user"].ToString() + "'";
        cmd.ExecuteNonQuery();
        DataTable dt = new DataTable();
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        da.Fill(dt);
        foreach (DataRow dr in dt.Rows)
        {
            textbox1.Text = dr["firstname"].ToString();
            textbox2.Text = dr["lastname"].ToString();
            textbox3.Text = dr["address"].ToString();
            textbox4.Text = dr["country"].ToString();
            textbox5.Text = dr["city"].ToString();
            textbox6.Text = dr["mobile"].ToString();
        }

            con.Close();
    }

    protected void button1_Click(object sender, EventArgs e)
    {
        //Aplikohen ndryshimet ne databaze ne rast se perdoruesi ben ndryshime

        con.Open();
        SqlCommand cmd = con.CreateCommand();
        cmd.CommandType = CommandType.Text;
        cmd.CommandText = "update Registration set firstname='"+textbox1.Text+"',lastname='"+textbox2.Text+"', address='"+textbox3.Text+"', country='"+textbox4.Text+"', city='"+textbox5.Text+"', mobile='"+textbox6.Text+"' where email='" + Session["user"].ToString() + "'";
        cmd.ExecuteNonQuery();
        con.Close();

        Response.Redirect("payment_gateway.aspx");
    }
}