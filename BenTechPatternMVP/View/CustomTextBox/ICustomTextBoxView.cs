﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BenTechPatternMVP.View.CustomTextBox
{
    interface ICustomTextBoxView
    {
        void UpdateLabelWithCustomText(string text);
        void UpdateCustomTextAlignment(HorizontalAlignment textAlignment);
        void UpdateUseStarInPassword(bool boolean);
        void SetTextBoxLocation(Point Location);
        void SetTextBoxSize(Size Size);
        void StartTimer();
        void StopTimer();
        void UpdateLabelLocation(Point location);
        void UpdateLabelColor(Color color);
    }
}
