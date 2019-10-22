using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace LMS.student
{
    public partial class student_display_all_books : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\LMS\LMS\LMS\App_Data\lms.mdf;Integrated Security=True");

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public string checkpdf(object myvalue1, object id1)
        {
            if (myvalue1 == null)
            {
                return "Not Avalibale";
            }
            else
            {
                myvalue1 = "../librarian/" + myvalue1.ToString();
                return "<a href ='" + myvalue1.ToString() + "' style ='color:green'>view pdf </a>";
            }


        }
    }
}