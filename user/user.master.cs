using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class user_user : System.Web.UI.MasterPage
{
    string s;
    string t;
    string[] a = new string[6];
    int totalcost = 0;
    int totalcount = 0;

    SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\EL-PC\Desktop\el\MSc\WebSite1\App_Data\PlatonElectronics.mdf;Integrated Security=True");
    protected void Page_Load(object sender, EventArgs e)
    {
        con.Open();
        SqlCommand cmd = con.CreateCommand();
        cmd.CommandType = CommandType.Text;
        cmd.CommandText = "select * from Product_Category";
        cmd.ExecuteNonQuery();
        DataTable dt = new DataTable();
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        da.Fill(dt);
        dataList1.DataSource = dt;
        dataList1.DataBind();
        con.Close();



        if (Request.Cookies["cookie1"] != null)
        {
            s = Convert.ToString(Request.Cookies["cookie1"].Value);
            string[] strArr = s.Split('|');
            for (int i = 0; i < strArr.Length; i++)
            {
                t = Convert.ToString(strArr[i].ToString());
                string[] strArr1 = t.Split(',');
                for (int j = 0; j < strArr1.Length; j++)
                {
                    a[j] = strArr1[j].ToString();
                }

                totalcost = totalcost + (Convert.ToInt32(a[2].ToString()) * Convert.ToInt32(a[3].ToString()));
                totalcount = totalcount + 1;

                totcart.Text = totalcount.ToString();
                totcost.Text = totalcost.ToString();
            }
        }
    }

    protected void button1_Click(object sender, EventArgs e)
    {

    }
}
