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
    public partial class display_all_books : System.Web.UI.Page
    {

		//checks if myvalue has a value and returns the appropriate pdf
        public string checkvideo(object myvalue, object id)
        {
            if (myvalue == null)
            {
                return myvalue.ToString();
            }
            else
            {
                return "<a href ='delete_files.aspx?id=" + id + "' style ='color:red'>delete video </a>";
            }


        }

        public string checkpdf(object myvalue1, object id1)
        {
            if (myvalue1 == null)
            {
                return myvalue1.ToString();
            }
            else
            {
                return "<a href ='delete_files.aspx?id=" + id1 + "' style ='color:red'>delete pdf </a>";
            }


        }


    }
}