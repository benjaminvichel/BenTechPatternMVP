using BenTechPatternMVP.DTO.Employee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BenTechPatternMVP.View.Employee
{
    interface IEmployeeView
    {
        event Action ButtonEmployeesClicked;
        event EventHandler<EmployeeDTO> SaveEmployeeCreateClicked;
        event EventHandler<EmployeeUpdateDTO> SaveEmployeeUpdateClicked;
        event EventHandler<Guid> DeleteClicked;
        void ConfigListView();
        void ShowEmployeeInListView(ListViewItem employee);
        void ResetCreateEmployeeFields();
        void ResetUpdateEmployeeFields();
    }
}
