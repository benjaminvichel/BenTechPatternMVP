using BenTechPatternMVP.DTO.Employee;
using System;
using System.Windows.Forms;

namespace BenTechPatternMVP.View.Employee
{
    public partial class EmployeeView : Form, IEmployeeView
    {
        public event Action ButtonEmployeesClicked;
        public event EventHandler<EmployeeDTO> SaveEmployeeCreateClicked;
        public event EventHandler<EmployeeUpdateDTO> SaveEmployeeUpdateClicked;
        public event EventHandler<Guid> DeleteClicked;
        public EmployeeView()
        {
            InitializeComponent();
        }
        private void buttonEmployees_Click(object sender, EventArgs e)
        {
            ButtonEmployeesClicked.Invoke();
        }

        public void ConfigListView()
        {
            listView1.Items.Clear();  // Limpa o ListView antes de adicionar novos itens
            listView1.Columns.Clear();
            listView1.View = System.Windows.Forms.View.Details;  // Define que o ListView será exibido em formato de tabela
            listView1.LabelEdit = true;    // Permite edição de rótulos (nomes das colunas)
            listView1.AllowColumnReorder = true;  // Permite reorganizar as colunas
            listView1.FullRowSelect = true; // Destaca a linha inteira quando o usuário seleciona
            listView1.GridLines = true;    // Exibe as linhas da grade

            // Adicionar as colunas
            listView1.Columns.Add("ID", 230, HorizontalAlignment.Left);
            listView1.Columns.Add("Username", 150, HorizontalAlignment.Left);
            listView1.Columns.Add("IsAdmin", 75, HorizontalAlignment.Left);
        }

        public void ShowEmployeeInListView(ListViewItem employee)
        {
            listView1.Items.Add(employee);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            panelAddEmployee.Visible = true;
            panelUpdateEmployee.Visible = false;
            ResetCreateEmployeeFields();
        }
        public void ResetCreateEmployeeFields()
        {
            ctbEmployeeNameCreate.SetTextBoxValue("");
            ctbEmployeePasswCreate.SetTextBoxValue("");
            cbEmployeeTFCreate.SelectedIndex = 1;
        }
        public void ResetUpdateEmployeeFields()
        {
            ctbEmployeeNameUpdate.SetTextBoxValue("");
            cbEmployeeTFUpdate.SelectedIndex = 1;
        }
        private void btnSaveEmployee_Click(object sender, EventArgs e)
        {
            var employeeDTO = new EmployeeDTO
            {
                Id = Guid.NewGuid(),
                User_name = ctbEmployeeNameCreate.GetTextBoxValue(),
                Password = ctbEmployeePasswCreate.GetTextBoxValue(),
                IsAdmin = cbEmployeeTFCreate.SelectedItem.ToString() == "True"
            };
            SaveEmployeeCreateClicked.Invoke(this, employeeDTO);
        }
        private void btnSaveEmployeeUpdate_Click(object sender, EventArgs e)
        {
            var employeeUpdateDTO = new EmployeeUpdateDTO
            {
                Id = Guid.Parse(listView1.SelectedItems[0].SubItems[0].Text),
                User_name = ctbEmployeeNameUpdate.GetTextBoxValue(),
                IsAdmin = cbEmployeeTFUpdate.SelectedItem.ToString() == "True"
            };
            SaveEmployeeUpdateClicked.Invoke(this, employeeUpdateDTO);
        }

        private void btnDeleteEmployee_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                var selectedItem = listView1.SelectedItems[0].SubItems[0].Text;
                Guid Id = Guid.Parse(selectedItem);
                DeleteClicked.Invoke(this, Id);
            }
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            panelAddEmployee.Visible = false;
            panelUpdateEmployee.Visible = true;

            if (listView1.SelectedItems.Count > 0)
            {
                string employeeName = listView1.SelectedItems[0].SubItems[1].Text;
                ctbEmployeeNameUpdate.SetTextBoxValue(employeeName);
                cbEmployeeTFUpdate.Text = listView1.SelectedItems[0].SubItems[2].Text;
            }
        }
        private void lblCloseEmployeePanel_Click(object sender, EventArgs e)
        {
            panelAddEmployee.Visible = false;
        }

        private void lblCloseUpdatePanelUpdate_Click(object sender, EventArgs e)
        {
            panelUpdateEmployee.Visible = false;
        }


    }
}
