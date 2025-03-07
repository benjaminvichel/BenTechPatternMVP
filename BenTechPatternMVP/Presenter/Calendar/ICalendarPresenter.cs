using BenTechPatternMVP.Model.Days.CalendarDay;
using BenTechPatternMVP.Model.Days.DateDTO;
using BenTechPatternMVP.View.Calendar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BenTechPatternMVP.Presenter.Calendar
{
    interface ICalendarPresenter
    {
        //events
        event Action<DateTime> DayCreated;
        event Action DayEmptyCreated;
        event Action CreateNewPriceView;
        event EventHandler<List<DateDTO>> DatesInRange;

        ICalendarView CalendarView { get; }

        void ResetAllPanels();
        void CreateDays();

        void AddDaysInView(Control calendarDay);

        void AddDayEmptyInView(Control emptyDay);
        void OnChangeToNextMonth();

        void OnChangeToPreviousMonth();


        void OnTimePickerCalendarValueChanged(object sender, DateTime newDate);

        void OnDateTimePickerCalendarCloseUp(object sender, DateTime newDate);

        void AddPriceControlView(Control priceControlView);

    }
}

