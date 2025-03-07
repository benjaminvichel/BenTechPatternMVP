using BenTechPatternMVP.DTO.Prices;
using BenTechPatternMVP.Presenter.Days;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BenTechPatternMVP.View.Day
{
    public partial class DayView : UserControl, IDayView
    {
        public DateTime _date;
        public string _colorCode;
        public event Action<IDayView> DayClicked;
        private readonly DayPresenter _presenter;
        public DayView(DateTime date, string colorCode = "")
        {
            InitializeComponent();
            _date = date;
            _colorCode = colorCode;
            _presenter = new DayPresenter(this);
            panelDisplayColorCode.BackColor = ColorTranslator.FromHtml(colorCode);//arrumar colorCode
            AllowDropInCalendarDay();
        }
        public DateTime Date => _date;
        public void AllowDropInCalendarDay()
        {
            this.AllowDrop = _presenter.AllowDrop();
        }
        public void DefineDayToLabel(string exactDay)
        {
            lblDays.Text = exactDay;
        }
        public void UpdateSelectionStatus(Color color)
        {
            this.BackColor = color;
        }

        private void CalendarDaysView_DragEnter(object sender, DragEventArgs e)
        {
            //_presenter.VerifyDragType(e.Data);  not implemented
            e.Effect = _presenter.GetDragDropEffect();
        }


        private void DayView_Click(object sender, EventArgs e)
        {
            _presenter.ToggleSelectionState();
        }

        private void DayView_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(PriceDTO)))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else {
                e.Effect = DragDropEffects.None;
            }
        }

        private void DayView_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(PriceDTO)))
            {
                PriceDTO priceDTO = (PriceDTO)e.Data.GetData(typeof(PriceDTO));
                if (priceDTO != null)
                {
                    panelDisplayColorCode.BackColor = ColorTranslator.FromHtml(priceDTO.ColorCode);
                }
            }
        }
    }
}
