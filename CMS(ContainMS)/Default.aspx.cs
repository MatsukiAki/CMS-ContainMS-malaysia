using CMS_ContainMS_.Models;
using CMS_ContainMS_.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CMS_ContainMS_
{
    public partial class _Default : Page
    {

        public _Default() {

            
        }
        protected void Page_Load(object sender, EventArgs e)
        {

           
            /*
             userName.Text = "Arsalan@example.com";
             password.Text = "123";
              */
           
        }

        protected void btn_login_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                int login = new DBFunctions().login_username(userName.Text, password.Text);
                Session["username"] = userName.Text;
                if (login == 0)
                {
                    Response.Redirect("~/Pages/Admin/admin_index.aspx");
                }
                else if (login == 1)
                {
                    Response.Redirect("~/Pages/User/index.aspx");
                }
                else
                {
                    Response.Write("<script>alert('Wrong Email or Password');</script>");
                }
            }
            
            
        }
        protected void btn_register_Click(object sender, EventArgs e)
        {
            string name = txt_register_username.Text;
            string pass = txt_register_pass.Text;
            string email = txt_register_email.Text;
            string address = txt_register_address.Text;
            long phone = Convert.ToInt64(txt_register_phone.Text);

            int submit = new DBFunctions().submit(name, pass, email, address, phone, 1);
            if (submit == 0)
            {
                Response.Write("<script>alert('New User Registered');</script>");

            }
            else if (submit == 1)
            {
                Response.Write("<script>alert('User Exists Please Enter another Email ');</script>");
            }
            else {
                Response.Write("<script>alert('Connection Error ');</script>");
            }
           
            


        }
        protected void btn_forgot_Click(object sender, EventArgs e)
        {
           
              
                    Response.Write("<script>alert('Wrong Email or Password');</script>");
                
            


        }

        
    }
}