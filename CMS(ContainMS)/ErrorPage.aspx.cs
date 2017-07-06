using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CMS_ContainMS_
{
    public partial class ErrorPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string htmlErrorMessage = string.Empty;
            Exception ex = (Exception)Application["TheException"];
            
            //continue with ex to get htmlErrorMessage 

        }
    }
}