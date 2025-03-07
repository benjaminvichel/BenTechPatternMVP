using System;
using System.Windows.Forms;

namespace BenTechPatternMVP.View.Calendar
{
    public interface ICalendarView
    {
        event Action CreateAllDays;
        event Action ChangeToNextMonth;
        event Action ChangeToPreviousMonth;
        event EventHandler<DateTime> TimePickerCalendarValueChanged;
        event EventHandler<DateTime> DateTimePickerCalendarCloseUp;
        event Action CreateAllPredefinedPrices;
        event Action CreateNewPrice;

        void ResetAllPanels();
        void CreateDays();
        void ClearPanelControls();
        void DisplayDayToPanel(Control calendarDay);
        void DisplayDayEmptyToPanel(Control EmptyDay);
        void SetValueInDateTimePicker(DateTime time);
        void OpenPresenterView(Control form);
    }
}
