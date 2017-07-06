using CMS_ContainMS_.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;

namespace CMS_ContainMS_
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            // Initialize the product database.    
           
        }
       
        void Application_Error(object sender, EventArgs e)
        {
            // Code that runs when an unhandled error occurs
            if (Context.IsCustomErrorEnabled)
            {
                Exception ex = Server.GetLastError();
                Application["TheException"] = ex; //store the error for later
            }
            //direct user to error page 
            Server.Transfer("~/ErrorPage.aspx");
        }
      
    }
}