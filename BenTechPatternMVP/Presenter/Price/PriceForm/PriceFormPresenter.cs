using BenTechPatternMVP.DTO.Prices;
using BenTechPatternMVP.Services.Prices;
using BenTechPatternMVP.View.Price.PriceForm;
using System;
using System.Drawing;
using System.Threading.Tasks;

namespace BenTechPatternMVP.Presenter.Price.PriceForm
{
    class PriceFormPresenter
    {
        private readonly IPriceFormView _priceFormView;
        private readonly IPriceDTO _priceDTO;
        private readonly PriceService _priceService;
        public event Action ResetDatabase;
        public PriceFormPresenter(IPriceFormView view)
    : this(view, new DefaultPriceDTO())
        {
        }
        public PriceFormPresenter(IPriceFormView view, IPriceDTO priceDTO)
        {
            _priceFormView = view;
            _priceDTO = priceDTO;
            _priceService = new PriceService();

            _priceFormView.ShowView();
            _priceFormView.ShowValuesForEdit(_priceDTO);
            _priceFormView.SaveButtonClick += OnSaveButtonClickHandler;
            _priceFormView.ColorChanged += OnColorChanged;
            _priceFormView.DeletePrice += OnDeletePrice;
        }
        private async Task OnSaveButtonClickHandler()
        {
            await OnSaveButtonClick();// Executa a Task sem bloquear a UI
        }
        private async Task OnSaveButtonClick()
        {
            IPriceDTO newPriceDTO = _priceFormView.GetAllValues();
            bool viewCalledForPriceCreation = _priceFormView.ThisViewWasCalledForPriceCreation;
            try
            {
                if (!viewCalledForPriceCreation)
                {
                    await _priceService.UpdatePrice(newPriceDTO);
                }
                else
                {
                    await _priceService.CreatePrice(newPriceDTO);
                }
                _priceFormView.CloseView();
                ResetDatabase.Invoke();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro capturado na camada superior: {ex.Message}");
            }

        }
        private void OnColorChanged(object sender, Color color)
        {
            _priceFormView.ChangeColorFromPanelColor(color);
        }
        private async void OnDeletePrice()
        {
            IPriceDTO newPriceDTO = _priceFormView.GetAllValues();
            string colorCode = newPriceDTO.ColorCode.Substring(1);//remove the # from colorCode **IMPORTANT
            await _priceService.DeletePrice(colorCode);
            ResetDatabase.Invoke();
        }

    }
}
