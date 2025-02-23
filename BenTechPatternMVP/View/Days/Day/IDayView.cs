using System;
using System.Drawing;

namespace BenTechPatternMVP.View.Day
{
    interface IDayView
    {
        DateTime Date { get; }
        void AllowDropInCalendarDay();
        void DefineDayToLabel(string exactDay);
        void UpdateSelectionStatus(Color color);
    }
}
