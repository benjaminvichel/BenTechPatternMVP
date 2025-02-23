using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BenTechPatternMVP.Model.CustomTextBox
{
    interface ICustomTextBoxModel
    {
        string CustomText { get; set; }
        string TextValue { get; set; }
        HorizontalAlignment TextAlignment { get; set; }
        bool UseStarInPassword { get; set; }
        bool TextBoxSize { get; set; }
        bool IsFocused { get; set; }
        int LabelYPosition { get; set; }
        int LabelXPosition { get; set; }
        bool IsLabelMovingUp { get; set; }
    }
}
