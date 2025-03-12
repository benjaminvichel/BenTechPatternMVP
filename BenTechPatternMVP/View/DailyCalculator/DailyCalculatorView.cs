using BenTechPatternMVP.DTO.Prices;
using System;
using System.Windows.Forms;

namespace BenTechPatternMVP.View.DailyCalculator
{
    public partial class DailyCalculatorView : Form, IDailyCalculatorView
    {
        public event Action CalculatePricesClicked;

        public int NumberOfDays
        {
            get => int.TryParse(txtNumbOfDays.Text, out int days) ? days : 0;
            set => txtNumbOfDays.Text = value.ToString();
        }
        public double Discount
        {
            get => double.TryParse(txbDiscount.Text, out double discount) ? discount : 0;
            set { }
        }
        public DateTime StartDate => DateTime.TryParse(dtStartDate.Text, out DateTime date) ? date : DateTime.MinValue;
        public DateTime EndDate { get => DateTime.TryParse(dtEndDate.Text, out DateTime date) ? date : DateTime.MinValue; }

        public DailyCalculatorView()
        {
            InitializeComponent();
        }

        private void btnCalculatePrices_Click(object sender, EventArgs e)
        {
            CalculatePricesClicked.Invoke();
        }

        public void Display_price_values(DailyAndTotalRoomPrices prices)
        {
            ctb_double_value_daily.SetTextBoxValue(prices.Double_value_daily.ToString());
            ctb_double_value.SetTextBoxValue(prices.Double_value.ToString());

            ctb_double_luxury_value_daily.SetTextBoxValue(prices.Double_Luxury_value_daily.ToString());
            ctb_double_luxury_value.SetTextBoxValue(prices.Double_Luxury_value.ToString());

            ctb_single_value_daily.SetTextBoxValue(prices.Single_value_daily.ToString());
            ctb_single_value.SetTextBoxValue(prices.Single_value.ToString());

            ctb_triple_value_daily.SetTextBoxValue(prices.Triple_value_daily.ToString());
            ctb_triple_value.SetTextBoxValue(prices.Triple_value.ToString());

            ctb_quadruple_value_daily.SetTextBoxValue(prices.Quadruple_value_daily.ToString());
            ctb_quadruple_Value.SetTextBoxValue(prices.Quadruple_value.ToString());

            ctb_quintuple_value_daily.SetTextBoxValue(prices.Quintuple_value_daily.ToString());
            ctb_quintuple_value.SetTextBoxValue(prices.Quintuple_value.ToString());
        }


    }


}

