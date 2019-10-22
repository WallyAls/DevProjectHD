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
    public partial class student_active : System.Web.UI.Page
    {
       
            id = Convert.ToInt32(Request.QueryString["id"].ToString());
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update student_registration set approved = 'yes' where id ="+id+"";
            cmd.ExecuteNonQuery();
         

            Response.Redirect("display_student_info.aspx");
        }
    }
}