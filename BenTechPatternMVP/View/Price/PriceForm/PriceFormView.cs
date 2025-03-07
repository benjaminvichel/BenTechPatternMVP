using BenTechPatternMVP.DTO.Prices;
using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BenTechPatternMVP.View.Price.PriceForm
{
    public partial class PriceFormView : Form, IPriceFormView
    {
        private IPriceDTO _prices;

        public event Func<Task> SaveButtonClick;
        public event EventHandler<Color> ColorChanged;
        public event Action DeletePrice;
        public bool ThisViewWasCalledForPriceCreation { get; } = true;
        public PriceFormView(bool hideComponents = true)
        {
            InitializeComponent();

            if (!hideComponents)
            {
                ThisViewWasCalledForPriceCreation = false;
                HideComponents();
            }
        }
        private void HideComponents()
        {
            btnColor.Hide();
        }
        public void ShowView()
        {
            this.Show();
        }

        public void ShowValuesForEdit(IPriceDTO prices)
        {
            _prices = prices;
            panelColor.BackColor = ColorTranslator.FromHtml(_prices.ColorCode);
            ctbName.SetTextBoxValue(_prices.Name);
            ctbCouple.SetTextBoxValue(_prices.Double_value.ToString());
            ctbSingle.SetTextBoxValue(_prices.Single_value.ToString());
            ctbTriple.SetTextBoxValue(_prices.Triple_value.ToString());
            ctbQuadruple.SetTextBoxValue(_prices.Quadruple_value.ToString());
            ctbQuintuple.SetTextBoxValue(_prices.Quintuple_value.ToString());
            ctbChild03To06.SetTextBoxValue(_prices.Child03To06_value.ToString());
            ctbChild07To10.SetTextBoxValue(_prices.Child07To10_value.ToString());
        }

        public IPriceDTO GetAllValues()
        {
            _prices.ColorCode = $"#{panelColor.BackColor.R:X2}{panelColor.BackColor.G:X2}{panelColor.BackColor.B:X2}";
            _prices.Name = ctbName.GetTextBoxValue();
            _prices.Double_value = Convert.ToDouble(ctbCouple.GetTextBoxValue());
            _prices.Single_value = Convert.ToDouble(ctbSingle.GetTextBoxValue());
            _prices.Triple_value = Convert.ToDouble(ctbTriple.GetTextBoxValue());
            _prices.Quadruple_value = Convert.ToDouble(ctbQuadruple.GetTextBoxValue());
            _prices.Quintuple_value = Convert.ToDouble(ctbQuintuple.GetTextBoxValue());
            _prices.Child03To06_value = Convert.ToDouble(ctbChild03To06.GetTextBoxValue());
            _prices.Child07To10_value = Convert.ToDouble(ctbChild07To10.GetTextBoxValue());

            return _prices;
        }
        private void btnSave_Click(object sender, System.EventArgs e)
        {
           SaveButtonClick.Invoke();
        }
        public void CloseView()
        {
            this.Close();
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            DialogResult color = ColorDialogPriceFormView.ShowDialog();
            if (color == DialogResult.OK)
            {
                ColorChanged.Invoke(this, ColorDialogPriceFormView.Color);
            }
        }

        public void ChangeColorFromPanelColor(Color color)
        {
            _prices.ColorCode = ColorTranslator.ToHtml(color);
            panelColor.BackColor = color;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeletePrice.Invoke();
        }
    }
}
