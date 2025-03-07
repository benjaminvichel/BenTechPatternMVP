using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BenTechPatternMVP.View.Calendar
{
    public partial class CalendarView : Form, ICalendarView
    {
        public event Action CreateAllDays;
        public event Action ChangeToNextMonth;
        public event Action ChangeToPreviousMonth;
        public event EventHandler<DateTime> TimePickerCalendarValueChanged;
        public event EventHandler<DateTime> DateTimePickerCalendarCloseUp;
        public event Action CreateAllPredefinedPrices;
        public event Action CreateNewPrice;
        public CalendarView()
        {
            InitializeComponent();
        }

        public void ResetAllPanels()
        {
            fpanelPredefinedPricesInner.Controls.Clear();
        }

        public void DisplayDayToPanel(Control day)
        {
            calendarPanel.Controls.Add(day);
        }
        public void DisplayDayEmptyToPanel(Control EmptyDay)
        {
            calendarPanel.Controls.Add(EmptyDay);
        }
        public void ClearPanelControls()
        {
            calendarPanel.Controls.Clear();
        }

        public void CreateDays()
        {
            CreateAllDays?.Invoke();
        }

        public void SetValueInDateTimePicker(DateTime time)
        {
            dateTimePickerCalendar.Value = time;
        }

        public void CreatePredefinedPrices()
        {
            CreateAllPredefinedPrices?.Invoke();
        }


        private void pbtnPreviousMonth_Click(object sender, EventArgs e)
        {
            ChangeToPreviousMonth?.Invoke();
            CreateAllDays?.Invoke();
        }

        private void pbtnNextMonth_Click(object sender, EventArgs e)
        {
            ChangeToNextMonth?.Invoke();
            CreateAllDays?.Invoke();
        }

        private void dateTimePickerCalendar_ValueChanged(object sender, EventArgs e)
        {
            TimePickerCalendarValueChanged?.Invoke(this, dateTimePickerCalendar.Value);
        }

        private void dateTimePickerCalendar_CloseUp(object sender, EventArgs e)
        {
            DateTimePickerCalendarCloseUp?.Invoke(this, dateTimePickerCalendar.Value);
        }

        public void OpenPresenterView(Control form)
        {
            fpanelPredefinedPricesInner.Controls.Add(form);
        }

        private void ibtnCreateNewPredefinedValues_Click(object sender, EventArgs e)
        {
            CreateNewPrice.Invoke();
        }
    }
}
