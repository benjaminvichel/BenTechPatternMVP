using BenTechPatternMVP.DTO.Prices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenTechPatternMVP.View.Price.PriceForm
{
    interface IPriceFormView
    {
        void ShowView();
        void ShowValuesForEdit(IPriceDTO prices);
    }
}
