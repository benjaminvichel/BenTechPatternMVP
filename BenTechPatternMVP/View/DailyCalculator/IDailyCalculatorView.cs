using BenTechPatternMVP.DTO.Prices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenTechPatternMVP.View.DailyCalculator
{
    interface IDailyCalculatorView
    {
        event Action CalculatePricesClicked;

        int NumberOfDays { get; set; }
        double Discount { get; set; }
        double NumberOfSingles { get; set; }

        double NumberOfChild03To06 { get; set; }

        double NumberOfChild07To10 { get; set; }

        DateTime StartDate { get; }
        DateTime EndDate { get; }

        void Display_price_values(DailyAndTotalRoomPrices prices);

    }
}
