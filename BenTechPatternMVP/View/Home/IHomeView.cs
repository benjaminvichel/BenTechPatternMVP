using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BenTechPatternMVP.View.Home
{
    public interface IHomeView
    {
        event Action EmployeesClicked;
        event Action DataBaseClicked;
        event Action PricesCalculatorClicked;
        void ShowView();
        void OpenChildView(Form childView);
    }
}
