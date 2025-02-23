using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenTechPatternMVP.Context
{
    class UserContext
    {
        public static UserContext Current { get; } = new UserContext();

        public string Username { get; private set; }
        public string Token { get; private set; }
        public bool IsAdmin { get; private set; }

        public void SetUser(string username, string token, bool isAdmin)
        {
            Username = username;
            Token = token;
            IsAdmin = isAdmin;
        }
        public void ClearUser()
        {
            Username = null;
            Token = null;
            IsAdmin = false;
        }
    }
}
