using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenTechPatternMVP.DTO.Prices
{
    public interface IPriceDTO
    {
        string ColorCode { get; set; }
        string Name { get; set; }
        double Double_value { get; set; }
        double Single_value { get; set; }
        double Triple_value { get; set; }
        double Quadruple_value { get; set; }
        double Quintuple_value { get; set; }
        double Child03To06_value { get; set; }
        double Child07To10_value { get; set; }
        string ErrorMessage { get; set; }
    }
}
