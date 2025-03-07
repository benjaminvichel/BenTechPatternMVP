using BenTechPatternMVP.DTO.Prices;
using System;
using System.Drawing;
using System.Threading.Tasks;

namespace BenTechPatternMVP.View.Price.PriceForm
{
    interface IPriceFormView
    {
        event Func<Task> SaveButtonClick;
        event EventHandler<Color> ColorChanged;
        event Action DeletePrice;
        bool ThisViewWasCalledForPriceCreation { get; }
        void ShowView();
        IPriceDTO GetAllValues();
        void ShowValuesForEdit(IPriceDTO prices);
        void CloseView();
        void ChangeColorFromPanelColor(Color color);
    }
}
