using BenTechPatternMVP.DTO.Prices;
using BenTechPatternMVP.Model.DailyCalculator;
using BenTechPatternMVP.Model.Days.DateDTO;
using BenTechPatternMVP.Services.Dates;
using BenTechPatternMVP.View.DailyCalculator;
using System;
using System.Collections.Generic;

namespace BenTechPatternMVP.Presenter.DailyCalculator
{

    class DailyCalculatorPresenter
    {
        private readonly IDailyCalculatorView _view;
        private readonly DailyCalculatorModel _model;
        private readonly DatesService _dateService;


        public IDailyCalculatorView DailyCalculatorView => _view;
        public DailyCalculatorPresenter(IDailyCalculatorView view)
        {
            _view = view;
            _model = new DailyCalculatorModel();
            _dateService = new DatesService();

            _view.CalculatePricesClicked += OnCalculatePricesClicked;
            ViewConfigurations();
        }
        private void ViewConfigurations()
        {
            _view.Discount = _model.Discount;
        }

        private async void OnCalculatePricesClicked()
        {
            int days = _view.NumberOfDays;
            _model.Discount = _view.Discount;

            DateTime startDate = _view.StartDate;
            DateTime endDate = _view.EndDate;

            string startDateString;
            string endDateString;
            //Remove 1 day from endDate.
            //Exclude one day from the calculation, otherwise, it takes the values from the final day as well.
            //The daily rate should be for today to tomorrow,
            //not the value of today plus the value of tomorrow

            if (startDate == endDate)
            {

                startDateString = startDate.ToString("yyy-MM-dd");
                endDateString = endDate.ToString("yyy-MM-dd");
            }
            else
            {
                startDateString = startDate.ToString("yyy-MM-dd");
                endDateString = endDate.AddDays(-1).ToString("yyy-MM-dd");
            }


            List<DateDTO> dateList = await _dateService.GetDatesInRange(startDateString, endDateString);


            int numberOfDays = 0;
            double doubleValue = 0;
            double doubleLuxury;
            double singleValue = 0;
            double tripleValue = 0;
            double quadrupleValue = 0;
            double quintupleValue = 0;
            double child03To06Value = 0;
            double child07To10Value = 0;

            foreach (var d in dateList)
            {
                numberOfDays++;
                doubleValue += d.DoubleValue;
                singleValue += d.SingleValue;
                tripleValue += d.TripleValue;
                quadrupleValue += d.QuadrupleValue;
                quintupleValue += d.QuintupleValue;
                child03To06Value += d.Child03To06Value;
                child07To10Value += d.Child07To10Value;
            }
            //doubleLuxury is not in dateList
            doubleLuxury = doubleValue * 1.15;


            //send to Model
            _model.Double_value = doubleValue;
            _model.Double_luxury_value = doubleLuxury;
            _model.Single_value = singleValue;
            _model.Triple_value = tripleValue;
            _model.Quadruple_value = quadrupleValue;
            _model.Quintuple_value = quintupleValue;
            _model.Child03To06_value = child03To06Value;
            _model.Child07To10_value = child07To10Value;


            //Custom prices calculations for custom field
            double customSingles = _view.NumberOfSingles * _model.Single_value;
            double customChild03To06 = _view.NumberOfChild03To06* _model.Child03To06_value;
            double customChild07To10 = _view.NumberOfChild07To10*_model.Child07To10_value;
            double customPriceTotal = _model.Double_value + customSingles + customChild03To06 + customChild07To10;
            

          //apply discount
          doubleValue *= (1 - _model.Discount / 100);
            doubleLuxury *= (1 - _model.Discount / 100);
            singleValue *= (1 - _model.Discount / 100);
            tripleValue *= (1 - _model.Discount / 100);
            quadrupleValue *= (1 - _model.Discount / 100);
            quintupleValue *= (1 - _model.Discount / 100);
            child03To06Value *= (1 - _model.Discount / 100);
            child07To10Value *= (1 - _model.Discount / 100);
            customPriceTotal *= (1 - _model.Discount / 100);

            //calculate daily values
            double double_daily_price = Math.Round(doubleValue / numberOfDays, 2);
            double double_Luxury_daily_price = Math.Round(doubleLuxury / numberOfDays, 2);
            double single_daily_price = Math.Round(singleValue / numberOfDays, 2);
            double triple_daily_price = Math.Round(tripleValue / numberOfDays, 2);
            double quadruple_daily_price = Math.Round(quadrupleValue / numberOfDays, 2);
            double quintuple_daily_price = Math.Round(quintupleValue / numberOfDays, 2);
            double child03To06_daily_price = Math.Round(child03To06Value / numberOfDays, 2);
            double child07To10_daily_price = Math.Round(child07To10Value / numberOfDays, 2);
            double customPriceDaily = Math.Round(customPriceTotal / numberOfDays, 2);



            //create DTO to send all prices to the View
            DailyAndTotalRoomPrices prices = new DailyAndTotalRoomPrices
            {
                Double_value = doubleValue,
                Double_Luxury_value = doubleLuxury,
                Single_value = singleValue,
                Triple_value = tripleValue,
                Quadruple_value = quadrupleValue,
                Quintuple_value = quintupleValue,
                Child03To06_value = child03To06Value,
                Child07To10_value = child07To10Value,
                CustomPriceTotal = customPriceTotal,
                Double_value_daily = double_daily_price,
                Double_Luxury_value_daily = double_Luxury_daily_price,
                Single_value_daily = single_daily_price,
                Triple_value_daily = triple_daily_price,
                Quadruple_value_daily = quadruple_daily_price,
                Quintuple_value_daily = quintuple_daily_price,
                Child03To06_value_daily = child03To06_daily_price,
                Child07To10_value_daily = child07To10_daily_price,
                CustomPriceDaily = customPriceDaily

            };

            _view.NumberOfDays = numberOfDays;
            _view.Display_price_values(prices);

        }
    }
}
