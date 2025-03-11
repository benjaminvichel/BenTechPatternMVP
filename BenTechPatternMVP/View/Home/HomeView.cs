using BenTechPatternMVP.Context;
using BenTechPatternMVP.View.Calendar;
using System;
using System.Windows.Forms;

namespace BenTechPatternMVP.View.Home
{
    public partial class HomeView : Form, IHomeView
    {
        public event Action EmployeesClicked;
        public event Action DataBaseClicked;
        public event Action PricesCalculatorClicked;


        private Form _currentChildForm;
        public HomeView()
        {
            InitializeComponent();
            SetDefaultVisibility();
            VerifyUserAccess();
        }

        private void SetDefaultVisibility()
        {
            ibtnEmployees.Visible = false;
            ibtnDataBase.Visible = false;
        }
        private void VerifyUserAccess()
        {
            if (UserContext.Current.IsAdmin)
            {
                ibtnEmployees.Visible = true;
                ibtnDataBase.Visible = true;
            }


        }

        public void ShowView()
        {
            this.Show();
        }
        private void ibtnEmployees_Click(object sender, EventArgs e)
        {
            EmployeesClicked.Invoke();
        }
        private void ibtnDataBase_Click(object sender, EventArgs e)
        {
            DataBaseClicked?.Invoke();
        }

        public void OpenChildView(Form childView)
        {
            _currentChildForm?.Hide();
            _currentChildForm = childView;
            childView.TopLevel = false;
            childView.FormBorderStyle = FormBorderStyle.None;
            childView.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childView);
            panelDesktop.Tag = childView;
            childView.BringToFront();
            childView.Show();
        }

        private void ibtnPricesCalculator_Click(object sender, EventArgs e)
        {
            PricesCalculatorClicked.Invoke();
        }
    }
}
