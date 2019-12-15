using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VAR
{
    public class EmployeeInfo
    {
        //varible Declaration
       
        string full_name;
        string image;
        string position;
        string email;
        string dob;
        int mobile_no;
        string address;
        string blood_group;
        double salary;


        //public property

        
        public string Full_name { get => full_name; set => full_name = value; }
        public string Image { get => image; set => image = value; }
        public string Position { get => position; set => position = value; }
        public string Email { get => email; set => email = value; }
        public string Dob { get => dob; set => dob = value; }
        public int Mobile_no { get => mobile_no; set => mobile_no = value; }
        public string Address { get => address; set => address = value; }
        public string Blood_group { get => blood_group; set => blood_group = value; }
        public double Salary { get => salary; set => salary = value; }
    }
}
