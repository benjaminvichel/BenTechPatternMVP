using System;
using System.Windows.Forms;

namespace BenTechPatternMVP.Model.Days.CalendarDay
{
    class CalendarDayModel : ICalendarDayModel
    {
        public DateTime Date { get; set; }
        public bool AllowDrop { get; set; } = true;
        public bool IsSelected { get; set; } = false;
        public DragDropEffects DragDropEffect { get; set; } = DragDropEffects.Copy;
    }
}

