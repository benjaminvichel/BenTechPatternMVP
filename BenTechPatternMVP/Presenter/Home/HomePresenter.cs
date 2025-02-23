using BenTechPatternMVP.DTO.Prices;
using BenTechPatternMVP.View.Home;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BenTechPatternMVP.Presenter.Home
{
    class HomePresenter
    {
        private readonly IHomeView _view;

        public event EventHandler DataBaseClicked;
        public HomePresenter(IHomeView view)
        {
            _view = view;

            //events. escuta evento no view e repassa para o mainPresenter
            _view.DataBaseClicked += (sender, args) => DataBaseClicked?.Invoke(sender, args);
        }

        public void ShowHomeView()
        {
            _view.ShowView();
        }

        public void OpenChildView(Form childView)
        {
            _view.OpenChildView(childView);
        }
    }
}

