using BenTechPatternMVP.DTO;
using BenTechPatternMVP.DTO.LoginEventArgs;
using BenTechPatternMVP.Presenter.Login;
using BenTechPatternMVP.Services.Login;
using BenTechPatternMVP.View.Login;
using Moq;
using System.Reflection;
using Xunit;

namespace BenTechPetternMVP.UnitTests.Presenter.Login
{

    public class LoginPresenterUnitTests
    {
        private readonly Mock<ILoginService> _loginServiceMock;
        private readonly Mock<ILoginView> _loginViewMock;
        private readonly LoginPresenter _loginPresenter;

        public LoginPresenterUnitTests()
        {
            // Crie um mock do LoginService (ou use Mock.Of<LoginService>())
            _loginServiceMock = new Mock<ILoginService>();
            _loginViewMock = new Mock<ILoginView>();

            // Crie o presenter e substitua a criação real do LoginService
            _loginPresenter = new LoginPresenter(_loginViewMock.Object);

            // Agora, você substitui o serviço real pelo mock.
            _loginPresenter.GetType()
                .GetField("_loginService", BindingFlags.NonPublic | BindingFlags.Instance)
                .SetValue(_loginPresenter, _loginServiceMock.Object);
        }


        [Fact]
        public void OnLoginAttempt_ShouldShowError_WhenFieldsAreEmpty()
        {

            // Arrange
            var eventArgs = new LoginEventArgs("", "");
            // Configurar mock para capturar a chamada de ShowError
            _loginViewMock.Setup(v => v.ShowError(It.IsAny<string>()));

            // Act
            _loginViewMock.Raise(v => v.LoginAttempt += null, new object(), eventArgs);

            // Assert
            _loginViewMock.Verify(v => v.ShowError("Preencha todos os campos."), Times.Once);
        }

        [Fact]
        public void OnLoginAttempt_ShouldShowError_WhenFieldsAreIncorrect()
        {

            // Arrange
            _loginServiceMock.Setup(v => v.Login(It.IsAny<string>(), It.IsAny<string>()))
                 .ReturnsAsync(new LoginDTO { ErrorMessage = "Incorrect Values" });

            var eventArgs = new LoginEventArgs("user", "123");
            // Configurar mock para capturar a chamada de ShowError
            _loginViewMock.Setup(v => v.ShowError(It.IsAny<string>()));
            // Act
            _loginViewMock.Raise(v => v.LoginAttempt += null, eventArgs);

            // Assert
            _loginViewMock.Verify(v => v.ShowError("Incorrect Values"), Times.Once);
        }

        [Fact]
        public void OnLoginAttempt_ShouldCloseView_WhenFieldsAreCorrect()
        {

            // Arrange
            _loginServiceMock.Setup(v => v.Login(It.IsAny<string>(), It.IsAny<string>()))
                 .ReturnsAsync(new LoginDTO { Name = "user", Token = "token123", IsAdmin = true });

            var eventArgs = new LoginEventArgs("user", "123");
            // Configurar mock para capturar a chamada de ShowError
            _loginViewMock.Setup(v => v.CloseView());

            // Act
            _loginViewMock.Raise(v => v.LoginAttempt += null, eventArgs);

            // Assert
            _loginViewMock.Verify(v => v.CloseView(), Times.Once);
        }
    }
}
