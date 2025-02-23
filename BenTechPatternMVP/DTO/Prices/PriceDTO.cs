using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenTechPatternMVP.DTO.Prices
{
    class PriceDTO : IPriceDTO
    {
        public string ColorCode { get; set; }
        public double Double_value { get; set; }
        public double Single_value { get; set; }
        public double Triple_value { get; set; }
        public double Quadruple_value { get; set; }
        public double Quintuple_value { get; set; }
        public double Child03To06_value { get; set; }
        public double Child07To10_value { get; set; }
        public string ErrorMessage { get; set; }
    }
}
