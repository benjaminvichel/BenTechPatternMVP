using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenTechPatternMVP.Model.Calendar
{
    class CalendarModel : ICalendarModel
    {
        public DateTime Date { get; set; } = DateTime.UtcNow;
        public bool DateTimePickerDateHasChanged { get; set; } = false;
    }
}
