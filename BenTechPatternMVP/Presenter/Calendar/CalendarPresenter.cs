using BenTechPatternMVP.Context;
using BenTechPatternMVP.Model.Calendar;
using BenTechPatternMVP.Model.Days.CalendarDay;
using BenTechPatternMVP.Model.Days.DateDTO;
using BenTechPatternMVP.Services.Dates;
using BenTechPatternMVP.View.Calendar;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BenTechPatternMVP.Presenter.Calendar
{
    class CalendarPresenter : ICalendarPresenter
    {
        private readonly ICalendarView _view;
        private readonly ICalendarModel _model;
        private readonly DatesService _datesService;


        public ICalendarView CalendarView => _view;

        //events
        public event Action<DateTime> DayCreated;
        public event Action DayEmptyCreated;
        public event Action CreateNewPriceView;
        public event EventHandler<List<DateDTO>> DatesInRange;



        public CalendarPresenter(ICalendarView view)
        {
            _view = view;
            _model = new CalendarModel();
            _datesService = new DatesService();
            _view.CreateAllDays += OnCreateAllDays;
            _view.ChangeToNextMonth += OnChangeToNextMonth;
            _view.ChangeToPreviousMonth += OnChangeToPreviousMonth;
            _view.TimePickerCalendarValueChanged += OnTimePickerCalendarValueChanged;
            _view.DateTimePickerCalendarCloseUp += OnDateTimePickerCalendarCloseUp;
            _view.CreateNewPrice += () => CreateNewPriceView?.Invoke();

        }

        public void ResetAllPanels()
        {
            _view.ResetAllPanels();
        }

        public void CreateDays()
        {
            _view.CreateDays();
        }
        private async void OnCreateAllDays()
        {

            DateTime firstDayOfMonth = new DateTime(_model.Date.Year, _model.Date.Month, 1);

            // Número de dias no mês
            int daysInMonth = DateTime.DaysInMonth(_model.Date.Year, _model.Date.Month);

            // Último dia do mês
            DateTime lastDayOfMonth = new DateTime(_model.Date.Year, _model.Date.Month, daysInMonth);

            // Dia da semana do primeiro dia do mês (como número)
            int dayOfWeek = Convert.ToInt32(firstDayOfMonth.DayOfWeek.ToString("d"));

            string formattedFirstDay = firstDayOfMonth.ToString("yyyy-MM-dd");
            string formattedLastDay = lastDayOfMonth.ToString("yyyy-MM-dd");

            var dates = await _datesService.GetDatesInRange(formattedFirstDay, formattedLastDay);//continuar daqui!!!
            DatesInRange.Invoke(this, dates);

            _view.SetValueInDateTimePicker(_model.Date);
            _view.ClearPanelControls();

            AddBlankDays(dayOfWeek);
            AddDays(daysInMonth);

        }



        private void AddDays(int days)
        {
            for (int i = 1; i <= days; i++)
            {
                DateTime currentDate = new DateTime(_model.Date.Year, _model.Date.Month, i);
                DayCreated?.Invoke(currentDate); // Dispara o evento informando que um novo dia foi criado
            }
        }
        private void AddBlankDays(int dayOfWeek)
        {
            for (int i = 1; i <= dayOfWeek; i++)
            {
                DayEmptyCreated?.Invoke();
            }
        }
        public void AddDaysInView(Control calendarDay)
        {
            _view.DisplayDayToPanel(calendarDay);
        }
        public void AddDayEmptyInView(Control emptyDay)
        {
            _view.DisplayDayEmptyToPanel(emptyDay);
        }

        public void OnChangeToNextMonth()
        {
            Console.WriteLine(_model.Date);
            _model.Date = _model.Date.AddMonths(1);
            Console.WriteLine(_model.Date);
        }
        public void OnChangeToPreviousMonth()
        {
            _model.Date = _model.Date.AddMonths(-1);
        }

        public void OnTimePickerCalendarValueChanged(object sender, DateTime newDate)
        {
            if (_model.Date != newDate) _model.DateTimePickerDateHasChanged = true;

        }
        public void OnDateTimePickerCalendarCloseUp(object sender, DateTime newDate)
        {
            if (_model.DateTimePickerDateHasChanged)
            {

                _model.DateTimePickerDateHasChanged = false;
                _model.Date = newDate;
                OnCreateAllDays();
            }
        }


        public void AddPriceControlView(Control priceControlView)
        {
            _view.OpenPresenterView(priceControlView);
        }

    }
}
