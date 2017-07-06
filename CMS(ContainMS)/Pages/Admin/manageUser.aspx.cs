using CMS_ContainMS_.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CMS_ContainMS_.Pages.Admin
{
    public partial class manageUser : System.Web.UI.Page
    {
        DataTable dt;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["username"] == null)
            {
                Response.Redirect("Default.aspx");
            }
            else
            {
                if (!Page.IsPostBack)
                {
                    createT();
                }
            }
           

        }

        public void createT() {
            dt = new DataTable();
            MakeDataTable();
            AddToDataTable();
            BindGrid();
        }
        private void MakeDataTable()
        {
            dt.Columns.Add("Name");
            dt.Columns.Add("Email");
            dt.Columns.Add("Address");
            dt.Columns.Add("PhoneNo");
            dt.Columns.Add("Type");
            dt.Columns.Add("Status");


        }

      

        private void AddToDataTable()
        {
            List<Costumer> obj = new DBFunctions().Clist();
            if (obj != null)
            {
                foreach (Costumer item in obj)
                {
                    DataRow dr = dt.NewRow();
                    dr["Name"] = item.Name;
                    dr["Email"] = item.Email;
                    dr["Address"] = item.Address;
                    dr["PhoneNo"] = item.PhoneNo;
                    dr["Type"] = getUS(item.Type);
                    dr["Status"] = item.Status;
                    dt.Rows.Add(dr);
                }
            }
           
           
        }

        private void BindGrid()
        {
            UserTbl.DataSource = dt;
            UserTbl.DataBind();
        }

        private string getUS(int x) {
            if (x == 0)
            {
                return "ADMIN";
            }
            else {
                return "USER";
            }
        }

        protected void btn_activate_Click(object sender, EventArgs e)
        {
            if (txt_register_email.Text != "")
            {
                if (new DBFunctions().update(txt_register_email.Text, 0))
            {
                Response.Write("<script>alert('User Activated');</script>");
            }
            }
            else
            {
                Response.Write("<script>alert('User Not Activated');</script>");
            }

            createT();

        }

        protected void btn_deactivate_Click(object sender, EventArgs e)
        {
            if (txt_register_email.Text != "")
            {
                if (new DBFunctions().update(txt_register_email.Text, 1))
                {
                    Response.Write("<script>alert('User Deactivated');</script>");
                }
                else {
                    Response.Write("<script>alert('User Not Deactivated');</script>");
                }
            }

            createT();
        }
       
        protected void OnRowDataBound(object sender, System.Web.UI.WebControls.GridViewRowEventArgs e)
        {
            e.Row.Attributes["onmouseover"] = "this.style.backgroundColor='aquamarine';";
            e.Row.Attributes["onmouseout"] = "this.style.backgroundColor='white';";
        }

        protected void UserTbl_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_register_email.Text = UserTbl.SelectedRow.Cells[2].Text;
            UserTbl.SelectedRow.BackColor = Color.Aquamarine;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string email = txt_register_email.Text;


            foreach (GridViewRow row in UserTbl.Rows)
            {
              
                    
                    String cellText = row.Cells[2].Text;
               
                    if (email == cellText)
                    {
                    
                    row.BackColor = Color.Aquamarine;
                    }
                
            }
           
        }
    }
}




