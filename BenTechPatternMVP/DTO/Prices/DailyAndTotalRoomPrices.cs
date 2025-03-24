using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenTechPatternMVP.DTO.Prices
{
    public class DailyAndTotalRoomPrices
    {
        public double Double_value { get; set; }
        public double Double_Luxury_value { get; set; }
        public double Single_value { get; set; }
        public double Triple_value { get; set; }
        public double Quadruple_value { get; set; }
        public double Quintuple_value { get; set; }
        public double Child03To06_value { get; set; }
        public double Child07To10_value { get; set; }
        public double CustomPriceTotal { get; set; }//custom field
        public double Double_value_daily { get; set; }
        public double Double_Luxury_value_daily { get; set; }
        public double Single_value_daily { get; set; }
        public double Triple_value_daily { get; set; }
        public double Quadruple_value_daily { get; set; }
        public double Quintuple_value_daily { get; set; }
        public double Child03To06_value_daily { get; set; }
        public double Child07To10_value_daily { get; set; }
        public double CustomPriceDaily { get; set; }//custom field
    }
}
