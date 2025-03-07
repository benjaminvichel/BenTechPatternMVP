using BenTechPatternMVP.Presenter.Login;
using BenTechPatternMVP.View.Controller;
using BenTechPatternMVP.View.Login;

using System;
using System.Windows.Forms;

namespace BenTechPatternMVP
{
    static class Program
    {

   

        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);



            ILoginView loginView = new LoginView();
            LoginPresenter loginPresenter = new LoginPresenter(loginView);

            Controller controller = new Controller(loginPresenter);

            Application.Run();
        }
    }
}
