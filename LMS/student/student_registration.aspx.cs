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

     
      
    }
 


}