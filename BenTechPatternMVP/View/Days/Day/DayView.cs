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
        private readonly DayPresenter _presenter;
        public DayView(DateTime date)
        {
            InitializeComponent();
            _date = date;
            _presenter = new DayPresenter(this);
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

        private void CalendarDaysView_Click(object sender, EventArgs e)
        {
            _presenter.ToggleSelectionState();
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

        private void CalendarDaysView_DragDrop(object sender, DragEventArgs e)
        {

        }
    }
}
