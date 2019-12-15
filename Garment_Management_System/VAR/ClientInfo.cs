using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VAR
{
    public class ClientInfo
    {
        //varible Declare varible
        
        string buyer_name;
        string company;
        string image;
        string country;
        string address;
        int mobile_no;
        string skype;
        string email;



        //pulic property
        
        public string Buyer_name { get => buyer_name; set => buyer_name = value; }
        public string Company { get => company; set => company = value; }
        public string Image { get => image; set => image = value; }
        public string Country { get => country; set => country = value; }
        public string Address { get => address; set => address = value; }
        public int Mobile_no { get => mobile_no; set => mobile_no = value; }
        public string Skype { get => skype; set => skype = value; }
        public string Email { get => email; set => email = value; }

    }
}
