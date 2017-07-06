


using CMS_ContainMS_.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace CMS_ContainMS_.Pages
{
    public class DBFunctions
    {
        
        public int login_username(string username, string password)
        {
            try
            {

                string querry = "Select Email, Password,Type from CMS_Login where Email = @username and Password = @password ";

                SqlCommand cmd = new SqlCommand(querry);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                SqlConnection con = Conn.Connection();

                cmd.Connection = con;

                try
                {

                    con.Open();
                    SqlDataReader rdr = cmd.ExecuteReader();

                    if (rdr.Read())
                    {
                        if (rdr["Type"].ToString() == "0")
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                    else
                    {
                        return 3;
                    }

                }
                catch (Exception c)
                {
                    return 5;
                }
                finally
                {
                    con.Close();
                }

            }
            catch (SqlException cc)
            {
                return 4;
            }

        }


        public int submit(string name,string pass,string email,string address,long phone,int type)
        {
            
            try
            {
                string insert_querry = "insert into CMS_Login(Name,Password,Email,Address,PhoneNo,Type) values " +

                   " (@name,@pass,@email,@address,@phoneno,@type)";

                SqlCommand cmd = new SqlCommand(insert_querry);
                cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
                cmd.Parameters.Add("@pass", SqlDbType.NVarChar).Value = pass;
                cmd.Parameters.Add("@email", SqlDbType.NVarChar).Value = email;
                cmd.Parameters.Add("@address", SqlDbType.NVarChar).Value = address;
                cmd.Parameters.Add("@phoneno", SqlDbType.BigInt).Value = phone;
                cmd.Parameters.Add("@type", SqlDbType.Int).Value = type;

                SqlConnection con = Conn.Connection();
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;

                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    return 0;

                }
                catch (SqlException px)
                {
                    return 1;

                }
                finally
                {
                    con.Close();
                }
            }
            catch (SqlException pxx)
            {
                return 2;

            }

           

        }



        public int createDelivery(int Packageid, string sender_name, string sender_email, string sender_num, DateTime sender_date, string sender_address,string recipient_name,
            string recipient_email, string recipient_num, DateTime reciver_date, string recipient_address, int package_type, double package_price, double package_weight,string createdby)
        {
            int delivery_status = 1;
                      try
            {
                string insert_querry = "insert into CMS_DeliveryInformation" +
                    "(Package_ID,Sender_name,Sender_email,Sender_cellnum,Sender_date,Sender_Address,Recipient_name,Recipient_email,Recipient_cellnum,Recipient_delivery_date," +
                    "Recipient_Address,Package_Type,Package_price,Delivery_status,Package_weight,Package_CreatedBy) values " +

                   " (@packageid,@sender_name,@sender_email,@sender_cellnum,@sender_date,@sender_address,@recipient_name,@recipient_email," +
                   "@recipient_cellnum,@recipient_delivery_date,@Recipient_Address,@package_type,@package_price,@delivery_status,@package_weight,@createdby)";

                SqlCommand cmd = new SqlCommand(insert_querry); 
                    cmd.Parameters.Add("@packageid", SqlDbType.Int).Value = Packageid;
                
                cmd.Parameters.Add("@sender_name", SqlDbType.NVarChar).Value = sender_name;
                cmd.Parameters.Add("@sender_email", SqlDbType.NVarChar).Value = sender_email;
                cmd.Parameters.Add("@sender_cellnum", SqlDbType.NVarChar).Value = sender_num;
                cmd.Parameters.Add("@sender_date", SqlDbType.Date).Value = sender_date;
                cmd.Parameters.Add("@sender_address", SqlDbType.NVarChar).Value = sender_address;
                
               
                cmd.Parameters.Add("@recipient_name", SqlDbType.NVarChar).Value = recipient_name;
                cmd.Parameters.Add("@recipient_email", SqlDbType.NVarChar).Value = recipient_email;
                cmd.Parameters.Add("@recipient_cellnum", SqlDbType.NVarChar).Value = recipient_num;
                cmd.Parameters.Add("@recipient_delivery_date", SqlDbType.Date).Value = reciver_date;
                cmd.Parameters.Add("@Recipient_Address", SqlDbType.NVarChar).Value = recipient_address;
                cmd.Parameters.Add("@package_type", SqlDbType.Int).Value = package_type;
                cmd.Parameters.Add("@package_price", SqlDbType.Float).Value = package_price;
                cmd.Parameters.Add("@delivery_status", SqlDbType.Int).Value = delivery_status;
                    cmd.Parameters.Add("@createdby", SqlDbType.NVarChar).Value = createdby;

                cmd.Parameters.Add("@package_weight", SqlDbType.Float).Value = package_weight;
                SqlConnection con = Conn.Connection();
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;

                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    return 0;

                }
                catch (SqlException px)
                {
                    return 1;

                }
                finally
                {
                    con.Close();
                }
            }
            catch (SqlException pxx)
            {
                return 2;

            }


        }



        public List<CMS_DI> list(string username) {
            List<CMS_DI> obj = new List<CMS_DI>();
            try
            {
                string querry = "Select Package_ID, Sender_name,Recipient_name,Package_price,Sender_date,Recipient_delivery_date,Delivery_status from CMS_DeliveryInformation where Package_CreatedBy = @username";
                SqlCommand cmd = new SqlCommand(querry);
                cmd.Parameters.AddWithValue("@username", username);                
                SqlConnection con = Conn.Connection();
                cmd.Connection = con;
                try
                {
                    con.Open();
                    SqlDataReader rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        string status = "";
                        if (rdr[6].ToString() == "0")
                        {
                            status = "Delivered";
                        }
                        else if (rdr[6].ToString() == "1")
                        {
                            status = "In Progress";
                        }
                        else
                        if (rdr[6].ToString() == "2")
                        {
                            status = "Waiting For Confirmation";
                        }
                        CMS_DI objx = new CMS_DI(rdr[0].ToString(), rdr[1].ToString(), rdr[2].ToString(), rdr[3].ToString(), Convert.ToDateTime(rdr[4].ToString()).ToString("MM/dd/yyyy"), Convert.ToDateTime(rdr[5].ToString()).ToString("MM/dd/yyyy"), status);
                        obj.Add(objx);

                    }
                    return obj;


                }
                catch (Exception c)
                {
                   
                }
                finally
                {
                    con.Close();
                }

            }
            catch (SqlException cc)
            {
                
            }


            return null;
        }


        public List<Costumer> Clist()
        {
            List<Costumer> obj = new List<Costumer>();
            try
            {
                string querry = "Select Name, Email,Address,PhoneNo,Type,Status from CMS_Login";
                SqlCommand cmd = new SqlCommand(querry);
                
                SqlConnection con = Conn.Connection();
                cmd.Connection = con;
                try
                {
                    con.Open();
                    SqlDataReader rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        string status = "";
                        if (rdr[5].ToString() == "0")
                        {
                            status = "Active";
                        }
                        else {
                            status = "Inactive";
                        }
                        Costumer objx = new Costumer(rdr[0].ToString(), rdr[1].ToString(), rdr[2].ToString(), rdr[3].ToString(),Convert.ToInt16(rdr[4].ToString()), status);
                        obj.Add(objx);

                    }
                    return obj;


                }
                catch (Exception c)
                {

                }
                finally
                {
                    con.Close();
                }

            }
            catch (SqlException cc)
            {

            }


            return null;
        }

        public DataTable numberofdeliveriesbyname()
        {
            string query = "SELECT  count(Sender_name) as NumberofDeliveries,Sender_name,Package_CreatedBy as SenderEmail," +
                "CONVERT(VARCHAR(10), Sender_date, 103) as Delivery_Date, Delivery_status, case when Delivery_status = 0 then 'Delivered'" +
 "when Delivery_status = 1 then 'In Progress'"+
 "when Delivery_status = 2 then 'Waiting For Delivery'END as DeliveryStatus "+
"FROM CMS_DeliveryInformation "+
"GROUP BY Sender_name, Sender_date, Recipient_name, Delivery_status,Package_CreatedBy; ";

            SqlConnection sqlConn = Conn.Connection();
            sqlConn.Open();
            SqlCommand cmd = new SqlCommand(query, sqlConn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            sqlConn.Close();
            return dt;
        }


        public DataTable alldeliveriesfromtodate(DateTime from,DateTime to)
        {
            string query = "SELECT Package_ID as PackageID, Sender_name, Recipient_name, CONVERT(VARCHAR(10), Recipient_delivery_date, 103) as RecipientDelivery_Date," +
                "Package_price, Delivery_status, Package_weight "+
                        " FROM CMS_DeliveryInformation WHERE(Sender_date BETWEEN @from AND @to) ";

            SqlConnection sqlConn = Conn.Connection();
            sqlConn.Open();
            SqlCommand cmd = new SqlCommand(query, sqlConn);
            cmd.Parameters.Add("@from",SqlDbType.Date).Value = from;
           cmd.Parameters.Add("@to", SqlDbType.Date).Value = to;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
           da.Fill(dt);
            sqlConn.Close();
            return dt;
        }


        public DataTable alldeliveriescreatedby(string user)
        {
            string query = "SELECT        COUNT(Package_CreatedBy) AS Expr1,Package_CreatedBy,CONVERT(VARCHAR(10), Sender_date, 103) as Delivery_Date FROM CMS_DeliveryInformation " +
                "WHERE(Package_CreatedBy = @createdby) GROUP BY    Sender_date, Package_CreatedBy ";

            SqlConnection sqlConn = Conn.Connection();
            sqlConn.Open();
            SqlCommand cmd = new SqlCommand(query, sqlConn);
            cmd.Parameters.Add("@createdby",SqlDbType.VarChar).Value = user;
            //    cmd.Parameters.Add("@to", SqlDbType.DateTime).Value = to;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            sqlConn.Close();
            return dt;
        }

        public Boolean update(string email,int status)
        {
            Boolean upda;
            
            try
            {
                string update_querry = "update CMS_Login  set Status=@status Where  Email = @fn";

                SqlCommand cmd = new SqlCommand(update_querry);
                cmd.Parameters.Add("@fn", SqlDbType.NVarChar).Value = email;
                cmd.Parameters.Add("@status", SqlDbType.Int).Value = status;
                



                SqlConnection con = Conn.Connection();
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;

                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    upda = true;

                }
                catch (Exception px)
                {
                    upda = false;

                }
            }
            catch (Exception pxx)
            {
                upda = false;

            }
            return upda;
        }
    }
}