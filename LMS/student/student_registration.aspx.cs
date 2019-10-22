using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using Newtonsoft.Json.Linq;
using System.Configuration;
using System.Net;
using System.IO;

namespace LMS.student
{
    public partial class student_registration : System.Web.UI.Page
    {

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|lms.mdf;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();

        }

        protected void b1_Click(object sender, EventArgs e)
        {


           

        }

        public bool IsReCaptchValid()
        {
           
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