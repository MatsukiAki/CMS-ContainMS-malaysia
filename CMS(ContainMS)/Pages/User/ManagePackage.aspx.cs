using CMS_ContainMS_.Pages;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CMS_ContainMS_
{
    public partial class CreatePackage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["username"] == null)
            {
                Response.Redirect("~/Default.aspx");
            }
            else
            {
                package_combo();
                txt_send_add_pckg_w.Text = "1";
                Random rand = new Random(DateTime.Now.Millisecond);
                txt_package_id.Text = rand.Next().ToString();
            }

            //testing

        }
        

        protected void package_SelectedIndexChanged(object sender, EventArgs e)
        {
            combo_selection();
        }

        protected void send_add_DropDownList_State_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            double price = Convert.ToDouble(txt_price.Text);
            double weight = Convert.ToDouble(txt_send_add_pckg_w.Text);
            int packageid = Convert.ToInt32(txt_package_id.Text);
            DateTime dr = Convert.ToDateTime(txt_receive_add_date.Text);
            int insert = new DBFunctions().createDelivery(packageid, txt_send_add_name.Text,txt_send_add_email.Text,txt_send_add_number.Text,DateTime.Now,txt_send_add_address.Text,
                txt_receive_add_name.Text,txt_receive_add_email.Text,txt_receive_add_number.Text,dr,txt_receive_add_address.Text,package.SelectedIndex, price, weight, Session["username"].ToString());
            if (insert == 0)
            {
                Response.Write("<script>alert('Delivery Has been Placed');</script>");
                //Response.Redirect("~/Pages/User/index.aspx");
            }
            else if (insert == 1)
            {
                Response.Write("<script>alert('Package Id Exists');</script>");
            }
            else if (insert == 2)
            {
                Response.Write("<script>alert('Connection Error');</script>");
            }

                    }

        protected void btnDelete_Click(object sender, EventArgs e)
        {

        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {

        }
        private void package_combo()
        {
            if (package.Items.Count == 0)
            {

                try
                {

                    string querry = "Select Package_Description from CMS_Package ";

                    SqlCommand cmd = new SqlCommand(querry);

                    SqlConnection con = Conn.Connection();

                    cmd.Connection = con;

                    try
                    {

                        con.Open();



                        SqlDataReader rdr = cmd.ExecuteReader();

                        while (rdr.Read())
                        {
                            package.Items.Add(rdr[0].ToString());
                        }





                    }
                    catch (Exception c)
                    {

                    }
                    finally
                    {
                        con.Close();
                    }

                }
                catch (Exception)
                {
                }
            }

        }
        private void combo_selection()
        {

            string pck = package.SelectedItem.ToString();
            try
            {

                string querry = "Select Package_price,Package_DeliveryDays from CMS_Package where Package_Description=@pck ";

                SqlCommand cmd = new SqlCommand(querry);
                cmd.Parameters.AddWithValue("@pck", pck);
                SqlConnection con = Conn.Connection();

                cmd.Connection = con;

                try
                {

                    con.Open();



                    SqlDataReader rdr = cmd.ExecuteReader();

                    while (rdr.Read())
                    {
                       float initial_price = Convert.ToInt16(rdr[0]);
                        int package_days = Convert.ToInt16(rdr[1]);
                        

                        double finalprice = Convert.ToDouble(txt_send_add_pckg_w.Text)*initial_price;
                        txt_price.Text = ""+finalprice;
                        DateTime td = DateTime.Now.AddDays(package_days);
                        txt_receive_add_date.Text = ""+ td.Date.ToString("MM/dd/yyyy");
                    }
                   }
                catch (Exception c)
                {

                }
                finally
                {
                    con.Close();
                }

            }
            catch (Exception cc)
            {
            }

        }
    }
}