using BenTechPatternMVP.DTO.Employee;
using BenTechPatternMVP.Model.Employee;
using BenTechPatternMVP.Services.Employees;
using BenTechPatternMVP.View.Employee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BenTechPatternMVP.Presenter.Employee
{
    class EmployeePresenter
    {
        private readonly IEmployeeView _employeeView;
        private readonly EmployeesService _employeesService;
        private readonly EmployeeModel _model;
        public IEmployeeView EmployeeView => _employeeView;
        public EmployeePresenter(IEmployeeView view)
        {
            _employeeView = view;
            _employeesService = new EmployeesService();
            _model = new EmployeeModel();
            //events:
            _employeeView.ButtonEmployeesClicked += OnButtonEmployeesClicked;
            _employeeView.SaveEmployeeCreateClicked += OnSaveEmployeeCreateClicked;
            _employeeView.SaveEmployeeUpdateClicked += OnSaveEmployeeUpdateClicked;
            _employeeView.DeleteClicked += OnDeleteClicked;
        }

        private async void OnButtonEmployeesClicked()
        {
            _model.Employees = await _employeesService.GetAllEmployeesAsync();

            _employeeView.ConfigListView();

            foreach (var e in _model.Employees)
            {
                var line_listView = new ListViewItem(e.Id.ToString());
                line_listView.SubItems.Add(e.User_name);
                line_listView.SubItems.Add(e.IsAdmin.ToString());

                _employeeView.ShowEmployeeInListView(line_listView);
            }
        }
        private async void OnSaveEmployeeCreateClicked(object sender, EmployeeDTO employeeDto)
        {
            await _employeesService.CreateEmployee(employeeDto);
            _employeeView.ResetCreateEmployeeFields();
            OnButtonEmployeesClicked();
        }
        private async void OnSaveEmployeeUpdateClicked(object sender, EmployeeUpdateDTO employeeDto)
        {
            await _employeesService.UpdatePrice(employeeDto);
            _employeeView.ResetUpdateEmployeeFields();
            OnButtonEmployeesClicked();
        }
        private async void OnDeleteClicked(object sender, Guid id)
        {
            await _employeesService.DeletePrice(id);
            OnButtonEmployeesClicked();
        }

    }
}
