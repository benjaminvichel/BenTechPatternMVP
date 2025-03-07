using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenTechPatternMVP.DTO.Prices
{
    class DefaultPriceDTO : IPriceDTO
    {
        public string ColorCode { get; set; } = "";
        public string Name { get; set; } = "";
        public double Double_value { get; set; } = 0;
        public double Single_value { get; set; } = 0;
        public double Triple_value { get; set; } = 0;
        public double Quadruple_value { get; set; } = 0;
        public double Quintuple_value { get; set; } = 0;
        public double Child03To06_value { get; set; } = 0;
        public double Child07To10_value { get; set; } = 0;
        public string ErrorMessage { get; set; } = "";
    }
}
