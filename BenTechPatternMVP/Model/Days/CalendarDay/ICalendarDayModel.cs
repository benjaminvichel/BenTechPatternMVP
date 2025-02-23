using System;
using System.Windows.Forms;

namespace BenTechPatternMVP.Model.Days.CalendarDay
{
    interface ICalendarDayModel
    {
        DateTime Date { get; set; }
        bool AllowDrop { get; set; }
        bool IsSelected { get; set; }
        DragDropEffects DragDropEffect { get; set; }
    }
}
