using BenTechPatternMVP.DTO.Prices;
using System.Windows.Forms;

namespace BenTechPatternMVP.View.Price.PriceForm
{
    public partial class PriceFormView : Form, IPriceFormView
    {


        public PriceFormView()
        {
            InitializeComponent();
        }

        public void ShowView()
        {
            this.Show();
        }

        public void ShowValuesForEdit(IPriceDTO prices)
        {
            ctbCouple.SetTextBoxValue(prices.Double_value.ToString());
            ctbSingle.SetTextBoxValue(prices.Single_value.ToString());
            ctbTriple.SetTextBoxValue(prices.Triple_value.ToString());
            ctbQuadruple.SetTextBoxValue(prices.Quadruple_value.ToString());
            ctbQuintuple.SetTextBoxValue(prices.Quintuple_value.ToString());
            ctbChild03To06.SetTextBoxValue(prices.Child03To06_value.ToString());
            ctbChild07To10.SetTextBoxValue(prices.Child07To10_value.ToString());

        }
    }
}
