using System.ComponentModel.DataAnnotations;

namespace CMS_ContainMS_.Models
{
    public class Costumer
    {
        public Costumer(string name, string email, string address, string phoneNo, int type,string status)
        {
            Name = name;
            Email = email;
            Address = address;
            PhoneNo = phoneNo;
            Type = type;
            Status = status;
        }

        public string Name { get; set; }
           
        public string Email { get; set; }
         public string Address { get; set; }

       public string PhoneNo { get; set; }

       public int Type { get; set; }
        public string Status { get; set; }


    }
}