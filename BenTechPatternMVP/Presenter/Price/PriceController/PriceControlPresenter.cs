using BenTechPatternMVP.DTO.Prices;
using BenTechPatternMVP.Services.Prices;
using BenTechPatternMVP.View.PriceControl;
using System;
using System.Collections.Generic;

namespace BenTechPatternMVP.Presenter.PriceControl
{
    class PriceControlPresenter
    {
        private readonly IPriceControlView _view;
        private readonly PriceService _priceService;

        
        public event EventHandler<List<IPriceDTO>> PricesRetrieved;
        public event EventHandler<IPriceDTO> PriceControlView_btnClick;
        public PriceControlPresenter(IPriceControlView view)
        {
            _view = view;
            _priceService = new PriceService();
            _view.ClickedBtnEdit += OnClickedBtnEdit;
        }
        public async void GetAllPrices()
        {
            List<IPriceDTO> prices = await _priceService.GetAllPrices();

            PricesRetrieved.Invoke(this, prices);
        }

        private void OnClickedBtnEdit(object sender, IPriceDTO priceDTO)
        {
            PriceControlView_btnClick.Invoke(this,priceDTO);//MainPresenter is listening
        }
    }
}
