using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CMS_ContainMS_.Pages.User
{
    public partial class viewOlddelivery : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["username"] != null && Session["username"].ToString() != "")
            {
                addtbl();
            }
            else
            {
                
                    Response.Redirect("~/Default.aspx");
             
           
                
            }
                
            
            
        }

        private void addtbl()
        {

            DataTable dt = new DataTable();


            DataColumn[] dc = new DataColumn[6];
            DataColumn  Delivery_id = new DataColumn("Package_id");
            DataColumn name = new DataColumn("SenderName");
            DataColumn address = new DataColumn("RecieverName");
            DataColumn Package = new DataColumn("Package_Price");
            DataColumn Datesent = new DataColumn("Datesent");
            DataColumn Daterecieved = new DataColumn("Daterecieved");
            DataColumn status = new DataColumn("status");


            dt.Columns.Add(Delivery_id);
            dt.Columns.Add(name);
            dt.Columns.Add(address);
            dt.Columns.Add(Package);
            dt.Columns.Add(Datesent);
            dt.Columns.Add(Daterecieved);
            dt.Columns.Add(status);
           
            System.Collections.Generic.List<CMS_DI> list = new DBFunctions().list(Session["username"].ToString());
            if (list != null)
            {
                if (list.Count > 0)
                {
                    foreach (CMS_DI o in list)
                    {
                        dt.Rows.Add(o.Package_ID, o.Sender_name, o.Recipient_name, o.Package_price, o.Sender_date, o.Recipient_delivery_date, o.Delivery_status);
                    }
                }
                else
                {
                    myDiv.InnerHtml = "<h1>There Are No Deliveries Created By this User</h1>";
                }
            }
            else
            {
                myDiv.InnerHtml = "<h1>There Are No Deliveries Created By this User</h1>";
            }




            viewdeliverytbl.DataSource = dt;
            viewdeliverytbl.DataBind();
           
        }
    }
}