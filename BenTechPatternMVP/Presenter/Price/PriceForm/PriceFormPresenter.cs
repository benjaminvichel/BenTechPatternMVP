using BenTechPatternMVP.DTO.Prices;
using BenTechPatternMVP.View.Price.PriceForm;

namespace BenTechPatternMVP.Presenter.Price.PriceForm
{
    class PriceFormPresenter
    {
        private readonly IPriceFormView _priceFormView;
        private readonly IPriceDTO _priceDTO;
        public PriceFormPresenter(IPriceFormView view, IPriceDTO priceDTO)
        {
            _priceFormView = view;
            _priceDTO = priceDTO;

            _priceFormView.ShowView();
            _priceFormView.ShowValuesForEdit(_priceDTO);
        }


    }
}
