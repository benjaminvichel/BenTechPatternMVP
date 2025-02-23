using BenTechPatternMVP.DTO.Prices;
using System;
using System.Windows.Forms;
using System.Drawing;

namespace BenTechPatternMVP.View.PriceControl
{
    public partial class PriceControlView : UserControl, IPriceControlView
    {

        private IPriceDTO _priceData;

        public event EventHandler<IPriceDTO> ClickedBtnEdit;
        public PriceControlView(IPriceDTO price = null)
        {
            _priceData = price;
            InitializeComponent();

            if (_priceData != null)
            {
                DisplayColor();
            }
        }

        public void SetPriceData()
        {
        }
        public void DisplayColor()
        {
            PanelColor.BackColor = ColorTranslator.FromHtml(_priceData.ColorCode);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            ClickedBtnEdit.Invoke(this, _priceData);
        }
    }
}
