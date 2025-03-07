using System;
using System.Drawing;

namespace BenTechPatternMVP.View.Day
{
    public interface IDayView
    {
        event Action<IDayView> DayClicked;
        DateTime Date { get; }
        void AllowDropInCalendarDay();
        void DefineDayToLabel(string exactDay);
        void UpdateSelectionStatus(Color color);
    }
}
