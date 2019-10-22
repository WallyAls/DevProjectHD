using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace LMS.librarian
{
	//used to delete books
    public partial class delete_file : System.Web.UI.Page
    {

		// this is the connection string that is needed to connect to the local database.
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\LMS\LMS\LMS\App_Data\lms.mdf;Integrated Security=True");

        protected void Page_Load(object sender, EventArgs e)
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
			// this is to get the session thata is it doesnt allow people to use the software if the person isnt logged in
            if (Session["librarian"] == null)
            {
                Response.Redirect("login.aspx");
            }


            if (Request.QueryString["id"] != null)
            {
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update books set books_video='' where id='" + Request.QueryString["id"].ToString() + "' ";
                cmd.ExecuteNonQuery();
            }

           

            Response.Redirect("display_all_books.aspx");
           


        }

    }
}