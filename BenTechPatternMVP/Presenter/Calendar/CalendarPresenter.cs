using BenTechPatternMVP.Context;
using BenTechPatternMVP.Model.Calendar;
using BenTechPatternMVP.View.Calendar;
using System;
using System.Windows.Forms;

namespace BenTechPatternMVP.Presenter.Calendar
{
    class CalendarPresenter : ICalendarPresenter
    {
        private readonly ICalendarView _view;
        private readonly ICalendarModel _model;

        public ICalendarView CalendarView => _view;

        //events
        public event Action<DateTime> DayCreated;
        public event Action DayEmptyCreated;



        public CalendarPresenter(ICalendarView view)
        {
            _view = view;
            _model = new CalendarModel();
            _view.CreateAllDays += OnCreateAllDays;
            _view.ChangeToNextMonth += OnChangeToNextMonth;
            _view.ChangeToPreviousMonth += OnChangeToPreviousMonth;
            _view.TimePickerCalendarValueChanged += OnTimePickerCalendarValueChanged;
            _view.DateTimePickerCalendarCloseUp += OnDateTimePickerCalendarCloseUp;


        }

        public void ResetAllPanels()
        {
            _view.ResetAllPanels();
        }

        public void CreateDays()
        {
            _view.CreateDays();
        }
        private void OnCreateAllDays()
        {

            DateTime firstDayOfMonth = new DateTime(_model.Date.Year, _model.Date.Month, 1);

            // Número de dias no mês
            int daysInMonth = DateTime.DaysInMonth(_model.Date.Year, _model.Date.Month);

            // Dia da semana do primeiro dia do mês (como número)
            int dayOfWeek = Convert.ToInt32(firstDayOfMonth.DayOfWeek.ToString("d"));


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
