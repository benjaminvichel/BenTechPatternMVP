using BenTechPatternMVP.DTO.Prices;
using BenTechPatternMVP.Model.Days.CalendarDay;
using BenTechPatternMVP.Model.Days.DateDTO;
using BenTechPatternMVP.Presenter.Calendar;
using BenTechPatternMVP.Presenter.Home;
using BenTechPatternMVP.Presenter.Price.PriceForm;
using BenTechPatternMVP.Presenter.PriceControl;
using BenTechPatternMVP.View.Calendar;
using BenTechPatternMVP.View.Controller;
using BenTechPatternMVP.View.Day;
using BenTechPatternMVP.View.Days.EmptyDay;
using BenTechPatternMVP.View.Price.PriceForm;
using BenTechPatternMVP.View.PriceControl;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BenTechPatternMVP.Presenter.Main
{
    class MainPresenter
    {

        private readonly IController _controller;
        private readonly HomePresenter _homePresenter;
        private readonly ICalendarPresenter _calendarPresenter;
        private readonly PriceControlPresenter _priceControlPresenter;
        private readonly List<PriceControlPresenter> _priceControlPresenters = new List<PriceControlPresenter>();
        private readonly List<DateDTO> _listDateDTO = new List<DateDTO>();



        public MainPresenter(IController controller, HomePresenter homePresenter)
        {
            _controller = controller;
            _homePresenter = homePresenter;
            _homePresenter.ShowHomeView();

        }
        public MainPresenter(IController controller, HomePresenter homePresenter,
         ICalendarPresenter calendarPresenter, PriceControlPresenter priceControlPresenter)
        {
            _controller = controller;
            _homePresenter = homePresenter;
            _calendarPresenter = calendarPresenter;
            _priceControlPresenter = priceControlPresenter;


            _homePresenter.DataBaseClicked += OnDatabaseClicked;
            _calendarPresenter.DayCreated += OnDayCreated;
            _calendarPresenter.DayEmptyCreated += OnDayEmptyCreated;
            _priceControlPresenter.PricesRetrieved += OnPricesRetrieved;
            _calendarPresenter.CreateNewPriceView += OnCreateNewPriceView;
            _calendarPresenter.DatesInRange += OnDatesInRange;

            _homePresenter.ShowHomeView();

        }

        private void OnDatesInRange(object sender, List<DateDTO> listDates)
        {
            _listDateDTO.Clear();
            foreach (var item in listDates)
            {
                _listDateDTO.Add(new DateDTO
                {
                    Date = item.Date,
                    ColorCode = item.ColorCode
                });
            }
        }

        private void OnDayCreated(DateTime date)
        {
            string colorCode ="";
            foreach (var item in _listDateDTO)
            {
                if (date == item.Date)
                {
                    colorCode = item.ColorCode;
                }
            }
            var ucDay = new DayView(date,colorCode);
            string exactDay = date.ToString("dd");
            ucDay.DefineDayToLabel(exactDay);
            _calendarPresenter.AddDaysInView(ucDay);
        }
        private void OnDayEmptyCreated()
        {
            var emptyDay = new DayEmptyView();
            _calendarPresenter.AddDayEmptyInView(emptyDay);
        }


        private void OnDatabaseClicked(object sender, EventArgs e)
        {
            _calendarPresenter.ResetAllPanels();
            _homePresenter.OpenChildView((Form)_calendarPresenter.CalendarView);
            _calendarPresenter.CreateDays(); //here because this way it will not call when user is not admin  
            _priceControlPresenter.GetAllPrices();
        }

        private void OnPricesRetrieved(object sender, List<IPriceDTO> list)
        {
            foreach (var price in list)
            {
                IPriceControlView priceControlView = new PriceControlView(price);
                var pricePresenter = new PriceControlPresenter(priceControlView);

                pricePresenter.PriceControlView_btnClick += OnPriceControlView_btnClick;

                _priceControlPresenters.Add(pricePresenter);
                _calendarPresenter.AddPriceControlView((Control)priceControlView); // Adiciona na HomeView
            }
        }

        private void OnPriceControlView_btnClick(object sender, IPriceDTO priceDTO)
        {
            IPriceFormView priceFormView = new PriceFormView(false);//false to indicate view to hide componentes
            PriceFormPresenter priceFormPresenter = new PriceFormPresenter(priceFormView, priceDTO);
            priceFormPresenter.ResetDatabase += OnResetDatabase;
        }
        private void OnResetDatabase()
        {
            OnDatabaseClicked(this, EventArgs.Empty);
        }
        private void OnCreateNewPriceView()
        {
            IPriceFormView priceFormView = new PriceFormView();
            PriceFormPresenter priceFormPresenter = new PriceFormPresenter(priceFormView);
            priceFormPresenter.ResetDatabase += OnResetDatabase;
        }
    }
}
