using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenTechPatternMVP.View.Login
{
    public class LoginEventArgs: EventArgs
    {
        public string Username { get; }
        public string Password { get; }


        public LoginEventArgs(string username, string password)
        {
            Username = username;
            Password = password;
        }
    }
}
