using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class user_registration : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\EL-PC\Desktop\el\MSc\WebSite1\App_Data\PlatonElectronics.mdf;Integrated Security=True");
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void button1_Click(object sender, EventArgs e)
    {
        con.Open();

        SqlCommand cmd = con.CreateCommand();
        cmd.CommandType = CommandType.Text;
        cmd.CommandText = "insert into Registration values('"+textbox1.Text+"','"+textbox2.Text+"','"+textbox3.Text+"','"+textbox4.Text+"','"+textbox5.Text+"','"+textbox6.Text+"','"+textbox7.Text+"','"+textbox8.Text+"','"+textbox9.Text+"')";
        cmd.ExecuteNonQuery();

        con.Close();

        textbox1.Text = "";
        textbox2.Text = "";
        textbox3.Text = "";
        textbox4.Text = "";
        textbox5.Text = "";
        textbox6.Text = "";
        textbox7.Text = "";
        textbox8.Text = "";
        textbox9.Text = "";

        label1.Text = "Registration was successful!";
    }
}