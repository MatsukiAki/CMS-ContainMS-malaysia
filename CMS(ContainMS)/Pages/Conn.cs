using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace CMS_ContainMS_.Pages
{
    public class Conn
    {
        static string strconect = System.Configuration.ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
        public static SqlConnection Connection() {
            SqlConnection con = new SqlConnection(strconect);

            return con;

        }

    }
}