using BenTechPatternMVP.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenTechPatternMVP.Services.Login
{
   public interface ILoginService
    {
        Task<LoginDTO> Login(string username, string password);
    }
}
