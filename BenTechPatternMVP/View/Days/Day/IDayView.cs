using BenTechPatternMVP.DTO.Prices;
using System;
using System.Drawing;

namespace BenTechPatternMVP.View.Day
{
    public interface IDayView
    {
        event Action DayClicked;
        event EventHandler<PriceDTO> DragDropOccurred;
        DateTime Date { get; }
        void AllowDropInCalendarDay(bool status);
        void DefineDayToLabel(string exactDay);
        void DefineColorCodeToDay(string color);
        void UpdateSelectionStatus(Color color);
    }
}
