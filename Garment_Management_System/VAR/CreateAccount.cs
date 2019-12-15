using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VAR
{
    public class CreateAccount
    {
        string username;
        string firstName;
        string lastname;
        string password;
        string email;
        int mobileno;
        string image;
        string position;

        public string Username { get => username; set => username = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string Lastname { get => lastname; set => lastname = value; }
        public string Password { get => password; set => password = value; }
        public string Email { get => email; set => email = value; }
        
        public string Image { get => image; set => image = value; }
        public string Position { get => position; set => position = value; }
        public int Mobileno { get => mobileno; set => mobileno = value; }
    }
}
