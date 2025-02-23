using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenTechPatternMVP.DTO
{
    interface ILoginDTO
    {
        string Name { get; set; }
        string Token { get; set; }
        bool IsAdmin { get; set; }
        string ErrorMessage { get; set; }
    }
}
