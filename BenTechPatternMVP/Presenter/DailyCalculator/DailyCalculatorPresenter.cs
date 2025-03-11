using BenTechPatternMVP.View.DailyCalculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenTechPatternMVP.Presenter.DailyCalculator
{

    class DailyCalculatorPresenter
    {
        private readonly IDailyCalculatorView _view;

        public IDailyCalculatorView DailyCalculatorView => _view;
        public DailyCalculatorPresenter(IDailyCalculatorView view)
        {
            _view = view;
        }
    }
}
