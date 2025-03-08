using BenTechPatternMVP.DTO.Prices;
using BenTechPatternMVP.Model.Days.CalendarDay;
using BenTechPatternMVP.Services.Dates;
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
        private readonly DatesService _datesService;

        //events:
        public EventHandler<PriceDTO> UpdatePriceInAllDayViews;
        public DayPresenter(DateTime time, string colorCode)
        {
            _view = new DayView();
            _datesService = new DatesService();
            _model = new CalendarDayModel();
            ConfigModel(time, colorCode);
            ConfigView();

            //events
            _view.DayClicked += OnDayClicked;
            _view.DragDropOccurred += OnDragDropOccurred;
        }
        public IDayView GetViewInstance() {
            return _view;
        }
        private void ConfigModel(DateTime time, string colorCode)
        {
            _model.AllowDrop = true;
            _model.IsSelected = false;
            _model.Date = time;
            _model.ColorCode = colorCode;
            _model.DragDropEffect = DragDropEffects.Copy;
        }
        private void ConfigView()
        {
            _view.AllowDropInCalendarDay(_model.AllowDrop);
            _view.DefineDayToLabel(_model.Date.Day.ToString());
            _view.DefineColorCodeToDay(_model.ColorCode);
        }

        private void OnDayClicked()
        {
            _model.IsSelected = !_model.IsSelected;
            Color color;
            if (_model.IsSelected)
            {
                color = Color.FromArgb(210, 210, 210);
            }
            else
            {
                color = Color.FromArgb(235, 235, 235);
            }
            _view.UpdateSelectionStatus(color);
        }

        private void OnDragDropOccurred(object sender, PriceDTO priceDTO)
        {
            UpdatePriceInAllDayViews.Invoke(this, priceDTO);
        }
        public void VerifyDragType()
        {
            //not implemented
        }
        public DragDropEffects GetDragDropEffect()
        {
            return _model.DragDropEffect;
        }
        public async void UpdatePrice(PriceDTO priceDTO)
        {

            if (_model.IsSelected && _model.ColorCode == "")
            {
                _model.ColorCode = priceDTO.ColorCode;
                await _datesService.CreateDate(_model.Date.ToString("yyyy-MM-dd"), priceDTO.ColorCode);
                _view.DefineColorCodeToDay(_model.ColorCode);
                OnDayClicked();
            }
            else if (_model.IsSelected)
            {
                _model.ColorCode = priceDTO.ColorCode;
                await _datesService.UpdateDate(_model.Date.ToString("yyyy-MM-dd"), priceDTO.ColorCode);
                _view.DefineColorCodeToDay(_model.ColorCode);
                OnDayClicked();
            }
        }
    }
}
