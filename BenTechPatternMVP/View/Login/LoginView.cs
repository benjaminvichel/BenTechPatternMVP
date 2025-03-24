using BenTechPatternMVP.DTO.LoginEventArgs;
using System;
using System.Windows.Forms;

namespace BenTechPatternMVP.View.Login
{
    public partial class LoginView : Form, ILoginView
    {
        public event EventHandler<LoginEventArgs> LoginAttempt;

        public LoginView()
        {       
            InitializeComponent();
        }
        public void ShowView() => Show();
        public void CloseView() => Close();
        public void ShowError(string message) => lblErrorMessage.Text = message;

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var username = ctbUser.GetTextBoxValue();
            var password = ctbPassword.GetTextBoxValue();

            LoginAttempt?.Invoke(this, new LoginEventArgs(username, password));
        }
    }
}
