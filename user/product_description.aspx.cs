using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class user_product_description : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\EL-PC\Desktop\el\MSc\WebSite1\App_Data\PlatonElectronics.mdf;Integrated Security=True");
    int id;
    int qty;
   
    string product_name, product_desc, product_price, product_qty, product_images;
    protected void Page_Load(object sender, EventArgs e)
    {
       if(Request.QueryString["id"]==null)
       {
        Response.Redirect("display_item.aspx");
       }
       else
       {
        id = Convert.ToInt32(Request.QueryString["id"].ToString());
        con.Open();
        SqlCommand cmd = con.CreateCommand();
        cmd.CommandType = CommandType.Text;
        cmd.CommandText = " select * from Products where id='"+id+"'";
        cmd.ExecuteNonQuery();
        DataTable dt = new DataTable();
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        da.Fill(dt);
        repeater1.DataSource = dt;
        repeater1.DataBind();
        con.Close();

       }

        qty = get_qty(id);

        if(qty==0)
        {
            label2.Visible = false;
            textbox1.Visible = false;
            button1.Visible = false;
            label1.Text = "There is no available quantity of this product!";
        }
    }

    protected void button1_Click(object sender, EventArgs e)
    { 
        if(con.State== ConnectionState.Open)
        {
            con.Close();
        }
        con.Open();
        SqlCommand cmd = con.CreateCommand();
        cmd.CommandType = CommandType.Text;
        cmd.CommandText = "select * from Products where id='" + id + "'";
        cmd.ExecuteNonQuery();
        DataTable dt = new DataTable();
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        da.Fill(dt);
        foreach(DataRow dr in dt.Rows)
        {
            product_name = dr["product_name"].ToString();
            product_desc = dr["product_desc"].ToString();
            product_price = dr["product_price"].ToString();
            product_qty = textbox1.Text;
            product_images = dr["product_images"].ToString();
            
        }
      

       if(Convert.ToInt32(textbox1.Text) > Convert.ToInt32(product_qty))
        {
            label1.Text = "Please enter lower quantity to match the available stock!";
        }
       else
        {
            label1.Text = "";

        if (Request.Cookies["cookie1"] ==null)
        {
                Response.Cookies["cookie1"].Value = product_name.ToString() + "," + product_desc.ToString() + "," +
              product_price.ToString() + "," + product_qty.ToString() + "," + product_images.ToString() + "," + id.ToString();
            Response.Cookies["cookie1"].Expires = DateTime.Now.AddDays(1);
        }
        else
        {
            Response.Cookies["cookie1"].Value = Request.Cookies["cookie1"].Value + "|" + product_name.ToString() + "," + 
                product_desc.ToString() + "," + product_price.ToString() + "," + product_qty.ToString() + "," + product_images.ToString()+"," + id.ToString();
            Response.Cookies["cookie1"].Expires = DateTime.Now.AddDays(1);
        }

            SqlCommand cmd1 = con.CreateCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "update Products set product_qty=product_qty-"+textbox1.Text+ "where id="+id;
            cmd1.ExecuteNonQuery();
            Response.Redirect("product_description.aspx?id=" + id.ToString());


        }
    }

    public int get_qty(int id)
    {
        con.Open();
        SqlCommand cmd = con.CreateCommand();
        cmd.CommandType = CommandType.Text;
        cmd.CommandText = "select * from Products where id='" + id + "'";
        cmd.ExecuteNonQuery();
        DataTable dt = new DataTable();
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        da.Fill(dt);
        foreach (DataRow dr in dt.Rows)
        {
            qty = Convert.ToInt32(dr["product_qty"].ToString());
        }
        return qty;
     }
}