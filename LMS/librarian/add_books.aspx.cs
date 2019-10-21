using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace LMS.librarian
{
    public partial class add_books : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\LMS\LMS\LMS\App_Data\lms.mdf;Integrated Security=True");


        protected void Page_Load(object sender, EventArgs e)
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();

            if (Session["librarian"] == null)
            {
                Response.Redirect("login.aspx");
            }
        }

        protected void b1_Click(object sender, EventArgs e)
        {
            string books_image_name = Class1.GetRandomPassword(10) + ".jpg";
            string books_pdf = "";
            string books_video = "";
            string path2 = "";
            string path3 = "";
            string path = "";
            fo1.SaveAs(Request.PhysicalApplicationPath + "/librarian/books_images/" + books_image_name.ToString());
            path = "books_images/" + books_image_name.ToString();


            if (f2.FileName.ToString() != "")
            {
                books_pdf = Class1.GetRandomPassword(10) + ".pdf";
                
                f2.SaveAs(Request.PhysicalApplicationPath + "/librarian/books_pdf/" + books_pdf.ToString());
                path2 = "books_pdf/" + books_pdf.ToString();
            }
            if (f3.FileName.ToString() != "")
            {
                books_video = Class1.GetRandomPassword(10) + ".mp4";
                
            f3.SaveAs(Request.PhysicalApplicationPath + "/librarian/books_videos/" + books_video.ToString());
            path3 = "books_videos/" + books_video.ToString();
        }


            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into books values('"+bookstitle.Text+"','"+path.ToString()+ "','" + path2.ToString() + "','" + path3.ToString() + "','" + authorname.Text+"','"+isbn.Text+"','"+qty.Text+"')";
            cmd.ExecuteNonQuery();

            msg.Style.Add("display", "block");

        }
    }



    public class Class1
    {

        public static string GetRandomPassword(int length)
        {
            char[] chars = "abcdefghijklmnopqrstuvwxyz1234567890ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            string password = string.Empty;
            Random random = new Random();

            for (int i = 0; i < length; i++)
            {
                int x = random.Next(1, chars.Length);
                //For avoiding Repetation of Characters
                if (!password.Contains(chars.GetValue(x).ToString()))
                    password += chars.GetValue(x);
                else
                    i = i - 1;
            }
            return password;
        }

    }


}