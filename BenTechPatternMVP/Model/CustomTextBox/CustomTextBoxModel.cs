using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BenTechPatternMVP.Model.CustomTextBox
{
    class CustomTextBoxModel: ICustomTextBoxModel
    {
        public string CustomText { get; set; } = "Text";
        public string TextValue { get; set; }
        public HorizontalAlignment TextAlignment { get; set; } = HorizontalAlignment.Left;
        public bool UseStarInPassword { get; set; } = false;
        public bool TextBoxSize { get; set; } = false;
        public bool IsFocused { get; set; } = false;
        public int LabelYPosition { get; set; } = 19;
        public int LabelXPosition { get; set; } = 19;
        public bool IsLabelMovingUp { get; set; } = false;
    }
}
