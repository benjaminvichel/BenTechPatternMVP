using BenTechPatternMVP.Context;
using BenTechPatternMVP.Presenter.Calendar;
using BenTechPatternMVP.Presenter.Home;
using BenTechPatternMVP.Presenter.Login;
using BenTechPatternMVP.Presenter.Main;
using BenTechPatternMVP.View.Calendar;
using BenTechPatternMVP.View.PriceControl;
using BenTechPatternMVP.View.Home;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BenTechPatternMVP.Presenter.PriceControl;
using BenTechPatternMVP.View.Employee;
using BenTechPatternMVP.Presenter.Employee;
using BenTechPatternMVP.View.DailyCalculator;
using BenTechPatternMVP.Presenter.DailyCalculator;

namespace BenTechPatternMVP.View.Controller
{
    public partial class Controller : Form, IController
    {
        private readonly LoginPresenter _loginPresenter;
        public Controller(LoginPresenter loginPresenter)
        {
            _loginPresenter = loginPresenter;
            InitializeComponent();

            _loginPresenter.LoginSuccessful += OnLoginSuccessful;

        }

        public void OnLoginSuccessful()
        {

            if (UserContext.Current.IsAdmin)
            {
                IHomeView homeView = new HomeView();
                IDailyCalculatorView dailyCalculatorView = new DailyCalculatorView();
                IEmployeeView employeeView = new EmployeeView();
                ICalendarView calendarView = new CalendarView();
                IPriceControlView priceControl = new PriceControlView();

                HomePresenter homePresenter = new HomePresenter(homeView);
                DailyCalculatorPresenter dailyCalculatorPresenter = new DailyCalculatorPresenter(dailyCalculatorView);
                EmployeePresenter employeePresenter = new EmployeePresenter(employeeView);
                ICalendarPresenter calendarPresenter = new CalendarPresenter(calendarView);
                PriceControlPresenter priceControlPresenter = new PriceControlPresenter(priceControl);

                MainPresenter mainPresenter = new MainPresenter(this, homePresenter, dailyCalculatorPresenter, employeePresenter, calendarPresenter, priceControlPresenter);
            }
            else
            {
                IHomeView homeView = new HomeView();
                HomePresenter homePresenter = new HomePresenter(homeView);

                MainPresenter mainPresenter = new MainPresenter(this, homePresenter);
            }
        }
    }
}
