using CMS_ContainMS_.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CMS_ContainMS_.Pages.Admin
{
    public partial class viewReport : System.Web.UI.Page
    {
        DataTable dt;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["username"] == null)
            {
                Response.Redirect("~/Default.aspx");
            }
        }
        


        public void createT(DataTable dt)
        {
                        
            Reports.DataSource = dt;
            Reports.DataBind();

        }

        protected void Report_radio_SelectedIndexChanged(object sender, EventArgs e)
        {
            string radio = Report_radio.SelectedValue;

            
             if(radio == "0")
            {
                createT(new DBFunctions().numberofdeliveriesbyname());
            }
        }

        protected void btn_find_email_Click(object sender, EventArgs e)
        {
            createT(new DBFunctions().alldeliveriescreatedby(txt_register_email.Text));
        }

        protected void btn_find_dates_Click(object sender, EventArgs e)
        {
            DateTime dtf = Convert.ToDateTime(fromdates.Text);
            DateTime dto = Convert.ToDateTime(todates.Text);
            createT(new DBFunctions().alldeliveriesfromtodate(dtf,dto));
        }
    }
}