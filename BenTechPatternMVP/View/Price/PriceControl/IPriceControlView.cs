using BenTechPatternMVP.DTO.Prices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenTechPatternMVP.View.PriceControl
{
    interface IPriceControlView
    {
        event EventHandler<IPriceDTO> ClickedBtnEdit;
        void SetPriceData();
        void DisplayInfos();
    }
}
