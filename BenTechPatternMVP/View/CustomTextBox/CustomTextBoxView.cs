using BenTechPatternMVP.Presenter.CustomTextBox;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BenTechPatternMVP.View.CustomTextBox
{
    public partial class CustomTextBoxView : UserControl, ICustomTextBoxView
    {
        private CustomTextBoxPresenter _presenter;
        public CustomTextBoxView()
        {
            InitializeComponent();
            lblTimer.Interval = 30;
            _presenter = new CustomTextBoxPresenter(this);

        }
        [Category("Custom Properties")]
        [Description("Give a name to your textBox")]
        public string CustomText
        {
            get => _presenter.GetLabelText();
            set => _presenter.SetLabelText(value);
        }

        public void UpdateLabelWithCustomText(string text)
        {
            label1.Text = text;
        }

        [Category("Custom Properties")]
        [Description("Defines the text alignment.")]
        public HorizontalAlignment CustomTextAlign
        {
            get => _presenter.GetCustomTextAlign();
            set => _presenter.SetCustomTextAlign(value);
        }
        public void UpdateCustomTextAlignment(HorizontalAlignment newTextAlignment)
        {
            textBox1.TextAlign = newTextAlignment;
        }

        [Category("Custom Properties")]
        [Description("Changes display to *.")]
        public bool Password
        {
            get => _presenter.GetUseStarInPassword();
            set => _presenter.SetUseStarInPassword(value);
        }
        public void UpdateUseStarInPassword(bool boolean)
        {
            textBox1.UseSystemPasswordChar = boolean;  //Does not work with Multiline Property = True
        }

        [Category("Custom Properties")]
        [Description("Changes textBox Size and Point to the Right")]

        public bool ChangeTextBoxSize
        {
            get { return _presenter.GetTextBoxSize(); }
            set
            {
                _presenter.SetTextBoxSize(value);
            }
        }
        public void SetTextBoxLocation(Point location)
        {
            textBox1.Location = location;
        }
        public void SetTextBoxSize(Size Size)
        {
            textBox1.Size = Size;
        }
        //timer
        public void UpdateLabelLocation(Point location)
        {
            label1.Location = location;
        }
        public void UpdateLabelColor(Color color)
        {
            label1.ForeColor = color;
        }
        private void lblTimer_Tick_1(object sender, EventArgs e)
        {
            _presenter.HandleTick();
        }
        public void StartTimer()
        {
            lblTimer.Start();
        }

        public void StopTimer()
        {
            lblTimer.Stop();
        }
        public string GetTextBoxValue()
        {
            return textBox1.Text;
        }
        public void SetTextBoxValue(string value)
        {
            textBox1.Text = _presenter.SetTextValue(value);
        }

        private void textBox1_Enter_1(object sender, EventArgs e)
        {
            _presenter.HandleTextBoxFocus(true);
        }

        private void textBox1_Leave_1(object sender, EventArgs e)
        {
            _presenter.SetTextBoxSize(string.IsNullOrEmpty(textBox1.Text) ? false : true);
            _presenter.HandleTextBoxFocus(false);
        }
    }
}
