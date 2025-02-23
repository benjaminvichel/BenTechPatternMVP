using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenTechPatternMVP.Model.Calendar
{
    interface ICalendarModel
    {
        DateTime Date { get; set; }
        bool DateTimePickerDateHasChanged { get; set; }
    }
}
