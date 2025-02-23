using BenTechPatternMVP.Model.CustomTextBox;
using BenTechPatternMVP.View.CustomTextBox;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BenTechPatternMVP.Presenter.CustomTextBox
{
    class CustomTextBoxPresenter
    {
        private readonly ICustomTextBoxView _view;
        private readonly ICustomTextBoxModel _model;

        public CustomTextBoxPresenter(ICustomTextBoxView view)
        {
            _view = view;
            _model = new CustomTextBoxModel();
        }
        //for unit tests
        public CustomTextBoxPresenter(ICustomTextBoxModel model, ICustomTextBoxView view)
        {
            _model = model;
            _view = view;
        }

        public string GetLabelText()
        {
            return _model.CustomText;
        }
        public void SetLabelText(string value)
        {
            _model.CustomText = value;
            _view.UpdateLabelWithCustomText(_model.CustomText);
        }
        public HorizontalAlignment GetCustomTextAlign()
        {
            return _model.TextAlignment;
        }
        public void SetCustomTextAlign(HorizontalAlignment value)
        {
            _model.TextAlignment = value;
            _view.UpdateCustomTextAlignment(_model.TextAlignment);
        }
        //password
        public bool GetUseStarInPassword()
        {
            return _model.UseStarInPassword;
        }
        public void SetUseStarInPassword(bool boolean)
        {
            _model.UseStarInPassword = boolean;
            _view.UpdateUseStarInPassword(_model.UseStarInPassword);
        }

        //textBoxSize
        public bool GetTextBoxSize()
        {
            return _model.TextBoxSize;
        }

        public string SetTextValue(string value)
        {
            _model.TextValue = value;
            return _model.TextValue;
        }
        public void SetTextBoxSize(bool size)
        {
            _model.TextBoxSize = size;

            var newLocation = size ? new Point(97, 19) : new Point(19, 19);
            var newSize = size ? new Size(185, 18) : new Size(256, 18);
            _view.SetTextBoxLocation(newLocation);
            _view.SetTextBoxSize(newSize);
        }
        public void HandleTick()
        {
            int y = _model.LabelYPosition;

            if (_model.IsLabelMovingUp)
            {
                y -= 2;
                if (y <= 6) // Posição de destino quando sobe
                {
                    y = 6;
                    _view.UpdateLabelColor(Color.Silver);
                    _model.IsLabelMovingUp = false;
                    _view.StopTimer();
                }
            }
            else
            {
                y += 2;
                if (y >= 19) // Posição de destino quando desce
                {
                    y = 19;
                    _view.UpdateLabelColor(Color.Black);
                    _model.IsLabelMovingUp = true; // Pronto para subir novamente
                    _view.StopTimer();
                }
            }

            _model.LabelYPosition = y;
            _view.UpdateLabelLocation(new Point(_model.LabelXPosition, y));
        }
        public void HandleTextBoxFocus(bool isTextBoxFocused)
        {
            _model.IsLabelMovingUp = isTextBoxFocused; // Sobe se focado, desce se não
            _view.StartTimer();
        }
    }
}
