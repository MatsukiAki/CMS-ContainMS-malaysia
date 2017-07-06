using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CMS_ContainMS_
{
    public class CMS_DI
    {

      public  string Package_ID;
        public string Sender_name;
        public string Recipient_name;
        public string Sender_date;
        public string Recipient_delivery_date;
        public string Package_price;
        public string Delivery_status;

        public CMS_DI(string package_ID, string sender_name, string recipient_name, string package_price, string sender_date, string recipient_delivery_date,  string delivery_status)
        {
            Package_ID = package_ID;
            Sender_name = sender_name;
            Recipient_name = recipient_name;
            Sender_date = sender_date;
            Recipient_delivery_date = recipient_delivery_date;
            Package_price = package_price;
            Delivery_status = delivery_status;
        }
    }
}