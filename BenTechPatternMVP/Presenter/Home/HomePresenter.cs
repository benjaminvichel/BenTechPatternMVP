using BenTechPatternMVP.DTO.Prices;
using BenTechPatternMVP.View.Home;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BenTechPatternMVP.Presenter.Home
{
    class HomePresenter
    {
        private readonly IHomeView _view;

        public event Action EmployeesClicked;
        public event Action DataBaseClicked;
        public event Action PricesCalculator;
        public HomePresenter(IHomeView view)
        {
            _view = view;

            //events. Escuta evento no view e repassa para o mainPresenter
            _view.EmployeesClicked += () => EmployeesClicked.Invoke();
            _view.DataBaseClicked += () => DataBaseClicked?.Invoke();
            _view.PricesCalculatorClicked += () => PricesCalculator.Invoke();
        }

        public void ShowHomeView()
        {
            _view.ShowView();
        }

        public void OpenChildView(Form childView)
        {
            _view.OpenChildView(childView);
        }
    }
}

