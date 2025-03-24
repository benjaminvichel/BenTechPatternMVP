using BenTechPatternMVP.DTO.LoginEventArgs;
using System;

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
