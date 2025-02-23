using BenTechPatternMVP.Model.Days.CalendarDay;
using BenTechPatternMVP.View.Day;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BenTechPatternMVP.Presenter.Days
{
    class DayPresenter
    {
        private readonly IDayView _view;
        private readonly ICalendarDayModel _model;
        public DayPresenter(IDayView view)
        {
            _view = view;
            _model = new CalendarDayModel();
            StoreDate();
        }
        public void StoreDate()
        {
            _model.Date = _view.Date;
        }
        public bool AllowDrop()
        {
            return _model.AllowDrop;
        }
        public void ToggleSelectionState()
        {
            _model.IsSelected = !_model.IsSelected;
            Color color = _model.IsSelected ? Color.Green : Color.Gray;
            _view.UpdateSelectionStatus(color);
        }
        public void VerifyDragType()
        {
            //not implemented
        }
        public DragDropEffects GetDragDropEffect()
        {
            return _model.DragDropEffect;
        }
    }
}
