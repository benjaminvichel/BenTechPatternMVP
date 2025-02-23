using BenTechPatternMVP.Context;
using BenTechPatternMVP.DTO;
using BenTechPatternMVP.Services.Login;
using BenTechPatternMVP.View.Login;
using System;

namespace BenTechPatternMVP.Presenter.Login
{


    public class LoginPresenter
    {
        private readonly ILoginView _loginView;
        private readonly LoginService _loginService;
        //events:
        public event Action LoginSuccessful;

        public LoginPresenter(ILoginView loginView)
        {
            this._loginView = loginView;

            _loginView.LoginAttempt += OnLoginAttempt;

            _loginService = new LoginService();

            _loginView.ShowView();
        }
        private async void OnLoginAttempt(object sender, LoginEventArgs e)
        {

            if (string.IsNullOrWhiteSpace(e.Username) || string.IsNullOrWhiteSpace(e.Password))
            {
                _loginView.ShowError("Preencha todos os campos.");
                return;
            }

            try
            {
                ILoginDTO loginDTO = await _loginService.Login(e.Username, e.Password);

                if (!string.IsNullOrEmpty(loginDTO.ErrorMessage))
                {
                    _loginView.ShowError(loginDTO.ErrorMessage);
                    return;
                }
                UserContext.Current.SetUser(loginDTO.Name, loginDTO.Token, loginDTO.IsAdmin);
                LoginSuccessful?.Invoke();
                _loginView.CloseView();
            }
            catch (Exception ex)
            {
                _loginView.ShowError(ex.Message);
            }
        }
    }
}
