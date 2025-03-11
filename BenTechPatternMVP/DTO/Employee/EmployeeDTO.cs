using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenTechPatternMVP.DTO.Employee
{
    public class EmployeeDTO
    {
        public Guid Id { get; set; }
        public string User_name { get; set; }
        public string Password { get; set; }
        public bool IsAdmin { get; set; }
    }
}
