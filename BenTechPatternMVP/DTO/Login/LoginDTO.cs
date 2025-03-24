using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenTechPatternMVP.DTO
{
    public class LoginDTO: ILoginDTO
    {
        public string Name { get; set; }
        public string Token { get; set; }
        public bool IsAdmin { get; set; }
        public string ErrorMessage { get; set; }
    }
}
