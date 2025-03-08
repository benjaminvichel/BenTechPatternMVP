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

        public event Action DayClicked;
        public event EventHandler<PriceDTO> DragDropOccurred;
        public DayView()
        {
            InitializeComponent();
        }
        public DateTime Date => _date;
        public void AllowDropInCalendarDay(bool status)
        {
            this.AllowDrop = status;
        }
        public void DefineDayToLabel(string exactDay)
        {
            lblDay.Text = exactDay;
        }
        public void DefineColorCodeToDay(string color) {
            panelDisplayColorCode.BackColor =ColorTranslator.FromHtml(color);
        }
        public void UpdateSelectionStatus(Color color)
        {
            this.BackColor = color;
        }

        private void DayView_Click(object sender, EventArgs e)
        {
            DayClicked.Invoke();
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
                    DragDropOccurred.Invoke(this,priceDTO);
                }
            }
        }
    }
}
