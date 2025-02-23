using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenTechPatternMVP.View.Login
{
    public interface ILoginView
    {
        event EventHandler<LoginEventArgs> LoginAttempt;
        void ShowView();
        void CloseView();
        void ShowError(string message);
    }
}
