
namespace BenTechPatternMVP.View.Employee
{
    partial class EmployeeView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeView));
            this.panelAddEmployee = new System.Windows.Forms.Panel();
            this.lblCloseEmployeePanel = new System.Windows.Forms.Label();
            this.lblAdminCreate = new System.Windows.Forms.Label();
            this.cbEmployeeTFCreate = new System.Windows.Forms.ComboBox();
            this.btnSaveEmployee = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDeleteEmployee = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.buttonEmployees = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.panelUpdateEmployee = new System.Windows.Forms.Panel();
            this.lblCloseUpdatePanelUpdate = new System.Windows.Forms.Label();
            this.lblAdminUpdate = new System.Windows.Forms.Label();
            this.cbEmployeeTFUpdate = new System.Windows.Forms.ComboBox();
            this.btnSaveEmployeeUpdate = new System.Windows.Forms.Button();
            this.ctbEmployeeNameUpdate = new BenTechPatternMVP.View.CustomTextBox.CustomTextBoxView();
            this.ctbEmployeePasswCreate = new BenTechPatternMVP.View.CustomTextBox.CustomTextBoxView();
            this.ctbEmployeeNameCreate = new BenTechPatternMVP.View.CustomTextBox.CustomTextBoxView();
            this.panelAddEmployee.SuspendLayout();
            this.panelUpdateEmployee.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelAddEmployee
            // 
            this.panelAddEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.panelAddEmployee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelAddEmployee.Controls.Add(this.lblCloseEmployeePanel);
            this.panelAddEmployee.Controls.Add(this.ctbEmployeePasswCreate);
            this.panelAddEmployee.Controls.Add(this.ctbEmployeeNameCreate);
            this.panelAddEmployee.Controls.Add(this.lblAdminCreate);
            this.panelAddEmployee.Controls.Add(this.cbEmployeeTFCreate);
            this.panelAddEmployee.Controls.Add(this.btnSaveEmployee);
            this.panelAddEmployee.Location = new System.Drawing.Point(63, 214);
            this.panelAddEmployee.Name = "panelAddEmployee";
            this.panelAddEmployee.Size = new System.Drawing.Size(340, 200);
            this.panelAddEmployee.TabIndex = 14;
            this.panelAddEmployee.Visible = false;
            // 
            // lblCloseEmployeePanel
            // 
            this.lblCloseEmployeePanel.AutoSize = true;
            this.lblCloseEmployeePanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCloseEmployeePanel.ForeColor = System.Drawing.Color.Maroon;
            this.lblCloseEmployeePanel.Location = new System.Drawing.Point(320, 1);
            this.lblCloseEmployeePanel.Name = "lblCloseEmployeePanel";
            this.lblCloseEmployeePanel.Size = new System.Drawing.Size(15, 13);
            this.lblCloseEmployeePanel.TabIndex = 7;
            this.lblCloseEmployeePanel.Text = "X";
            this.lblCloseEmployeePanel.Click += new System.EventHandler(this.lblCloseEmployeePanel_Click);
            // 
            // lblAdminCreate
            // 
            this.lblAdminCreate.AutoSize = true;
            this.lblAdminCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminCreate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.lblAdminCreate.Location = new System.Drawing.Point(16, 145);
            this.lblAdminCreate.Name = "lblAdminCreate";
            this.lblAdminCreate.Size = new System.Drawing.Size(36, 13);
            this.lblAdminCreate.TabIndex = 4;
            this.lblAdminCreate.Text = "Admin";
            // 
            // cbEmployeeTFCreate
            // 
            this.cbEmployeeTFCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbEmployeeTFCreate.FormattingEnabled = true;
            this.cbEmployeeTFCreate.Items.AddRange(new object[] {
            "True",
            "False"});
            this.cbEmployeeTFCreate.Location = new System.Drawing.Point(58, 142);
            this.cbEmployeeTFCreate.Name = "cbEmployeeTFCreate";
            this.cbEmployeeTFCreate.Size = new System.Drawing.Size(53, 21);
            this.cbEmployeeTFCreate.TabIndex = 2;
            this.cbEmployeeTFCreate.Text = "False";
            // 
            // btnSaveEmployee
            // 
            this.btnSaveEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(178)))), ((int)(((byte)(237)))));
            this.btnSaveEmployee.FlatAppearance.BorderSize = 0;
            this.btnSaveEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveEmployee.ForeColor = System.Drawing.Color.White;
            this.btnSaveEmployee.Location = new System.Drawing.Point(233, 145);
            this.btnSaveEmployee.Name = "btnSaveEmployee";
            this.btnSaveEmployee.Size = new System.Drawing.Size(75, 23);
            this.btnSaveEmployee.TabIndex = 0;
            this.btnSaveEmployee.Text = "Save";
            this.btnSaveEmployee.UseVisualStyleBackColor = false;
            this.btnSaveEmployee.Click += new System.EventHandler(this.btnSaveEmployee_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.Location = new System.Drawing.Point(12, 129);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(120, 33);
            this.btnEdit.TabIndex = 13;
            this.btnEdit.Text = "Edit";
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDeleteEmployee
            // 
            this.btnDeleteEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnDeleteEmployee.FlatAppearance.BorderSize = 0;
            this.btnDeleteEmployee.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnDeleteEmployee.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnDeleteEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteEmployee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.btnDeleteEmployee.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteEmployee.Image")));
            this.btnDeleteEmployee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteEmployee.Location = new System.Drawing.Point(12, 88);
            this.btnDeleteEmployee.Name = "btnDeleteEmployee";
            this.btnDeleteEmployee.Size = new System.Drawing.Size(120, 33);
            this.btnDeleteEmployee.TabIndex = 12;
            this.btnDeleteEmployee.Text = "Delete";
            this.btnDeleteEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteEmployee.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDeleteEmployee.UseVisualStyleBackColor = false;
            this.btnDeleteEmployee.Click += new System.EventHandler(this.btnDeleteEmployee_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(12, 49);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(120, 33);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Add";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // buttonEmployees
            // 
            this.buttonEmployees.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.buttonEmployees.FlatAppearance.BorderSize = 0;
            this.buttonEmployees.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.buttonEmployees.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.buttonEmployees.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEmployees.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.buttonEmployees.Image = ((System.Drawing.Image)(resources.GetObject("buttonEmployees.Image")));
            this.buttonEmployees.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEmployees.Location = new System.Drawing.Point(12, 12);
            this.buttonEmployees.Name = "buttonEmployees";
            this.buttonEmployees.Size = new System.Drawing.Size(120, 33);
            this.buttonEmployees.TabIndex = 10;
            this.buttonEmployees.Text = "Employees";
            this.buttonEmployees.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEmployees.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonEmployees.UseVisualStyleBackColor = false;
            this.buttonEmployees.Click += new System.EventHandler(this.buttonEmployees_Click);
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(470, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(756, 711);
            this.listView1.TabIndex = 9;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // panelUpdateEmployee
            // 
            this.panelUpdateEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.panelUpdateEmployee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelUpdateEmployee.Controls.Add(this.lblCloseUpdatePanelUpdate);
            this.panelUpdateEmployee.Controls.Add(this.ctbEmployeeNameUpdate);
            this.panelUpdateEmployee.Controls.Add(this.lblAdminUpdate);
            this.panelUpdateEmployee.Controls.Add(this.cbEmployeeTFUpdate);
            this.panelUpdateEmployee.Controls.Add(this.btnSaveEmployeeUpdate);
            this.panelUpdateEmployee.Location = new System.Drawing.Point(63, 434);
            this.panelUpdateEmployee.Name = "panelUpdateEmployee";
            this.panelUpdateEmployee.Size = new System.Drawing.Size(340, 200);
            this.panelUpdateEmployee.TabIndex = 15;
            this.panelUpdateEmployee.Visible = false;
            // 
            // lblCloseUpdatePanelUpdate
            // 
            this.lblCloseUpdatePanelUpdate.AutoSize = true;
            this.lblCloseUpdatePanelUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCloseUpdatePanelUpdate.ForeColor = System.Drawing.Color.Maroon;
            this.lblCloseUpdatePanelUpdate.Location = new System.Drawing.Point(320, 1);
            this.lblCloseUpdatePanelUpdate.Name = "lblCloseUpdatePanelUpdate";
            this.lblCloseUpdatePanelUpdate.Size = new System.Drawing.Size(15, 13);
            this.lblCloseUpdatePanelUpdate.TabIndex = 7;
            this.lblCloseUpdatePanelUpdate.Text = "X";
            this.lblCloseUpdatePanelUpdate.Click += new System.EventHandler(this.lblCloseUpdatePanelUpdate_Click);
            // 
            // lblAdminUpdate
            // 
            this.lblAdminUpdate.AutoSize = true;
            this.lblAdminUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.lblAdminUpdate.Location = new System.Drawing.Point(16, 145);
            this.lblAdminUpdate.Name = "lblAdminUpdate";
            this.lblAdminUpdate.Size = new System.Drawing.Size(36, 13);
            this.lblAdminUpdate.TabIndex = 4;
            this.lblAdminUpdate.Text = "Admin";
            // 
            // cbEmployeeTFUpdate
            // 
            this.cbEmployeeTFUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbEmployeeTFUpdate.FormattingEnabled = true;
            this.cbEmployeeTFUpdate.Items.AddRange(new object[] {
            "True",
            "False"});
            this.cbEmployeeTFUpdate.Location = new System.Drawing.Point(58, 142);
            this.cbEmployeeTFUpdate.Name = "cbEmployeeTFUpdate";
            this.cbEmployeeTFUpdate.Size = new System.Drawing.Size(53, 21);
            this.cbEmployeeTFUpdate.TabIndex = 2;
            this.cbEmployeeTFUpdate.Text = "False";
            // 
            // btnSaveEmployeeUpdate
            // 
            this.btnSaveEmployeeUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(178)))), ((int)(((byte)(237)))));
            this.btnSaveEmployeeUpdate.FlatAppearance.BorderSize = 0;
            this.btnSaveEmployeeUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveEmployeeUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveEmployeeUpdate.ForeColor = System.Drawing.Color.White;
            this.btnSaveEmployeeUpdate.Location = new System.Drawing.Point(233, 145);
            this.btnSaveEmployeeUpdate.Name = "btnSaveEmployeeUpdate";
            this.btnSaveEmployeeUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnSaveEmployeeUpdate.TabIndex = 0;
            this.btnSaveEmployeeUpdate.Text = "Save";
            this.btnSaveEmployeeUpdate.UseVisualStyleBackColor = false;
            this.btnSaveEmployeeUpdate.Click += new System.EventHandler(this.btnSaveEmployeeUpdate_Click);
            // 
            // ctbEmployeeNameUpdate
            // 
            this.ctbEmployeeNameUpdate.BackColor = System.Drawing.Color.White;
            this.ctbEmployeeNameUpdate.ChangeTextBoxSize = true;
            this.ctbEmployeeNameUpdate.CustomText = "Name";
            this.ctbEmployeeNameUpdate.CustomTextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ctbEmployeeNameUpdate.Location = new System.Drawing.Point(19, 20);
            this.ctbEmployeeNameUpdate.Name = "ctbEmployeeNameUpdate";
            this.ctbEmployeeNameUpdate.Password = false;
            this.ctbEmployeeNameUpdate.Size = new System.Drawing.Size(289, 49);
            this.ctbEmployeeNameUpdate.TabIndex = 5;
            // 
            // ctbEmployeePasswCreate
            // 
            this.ctbEmployeePasswCreate.BackColor = System.Drawing.Color.White;
            this.ctbEmployeePasswCreate.ChangeTextBoxSize = true;
            this.ctbEmployeePasswCreate.CustomText = "Password";
            this.ctbEmployeePasswCreate.CustomTextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ctbEmployeePasswCreate.Location = new System.Drawing.Point(19, 75);
            this.ctbEmployeePasswCreate.Name = "ctbEmployeePasswCreate";
            this.ctbEmployeePasswCreate.Password = false;
            this.ctbEmployeePasswCreate.Size = new System.Drawing.Size(289, 49);
            this.ctbEmployeePasswCreate.TabIndex = 6;
            // 
            // ctbEmployeeNameCreate
            // 
            this.ctbEmployeeNameCreate.BackColor = System.Drawing.Color.White;
            this.ctbEmployeeNameCreate.ChangeTextBoxSize = true;
            this.ctbEmployeeNameCreate.CustomText = "Name";
            this.ctbEmployeeNameCreate.CustomTextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ctbEmployeeNameCreate.Location = new System.Drawing.Point(19, 20);
            this.ctbEmployeeNameCreate.Name = "ctbEmployeeNameCreate";
            this.ctbEmployeeNameCreate.Password = false;
            this.ctbEmployeeNameCreate.Size = new System.Drawing.Size(289, 49);
            this.ctbEmployeeNameCreate.TabIndex = 5;
            // 
            // EmployeeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1238, 758);
            this.Controls.Add(this.panelUpdateEmployee);
            this.Controls.Add(this.panelAddEmployee);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDeleteEmployee);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.buttonEmployees);
            this.Controls.Add(this.listView1);
            this.MinimumSize = new System.Drawing.Size(1184, 797);
            this.Name = "EmployeeView";
            this.Text = "Employee";
            this.panelAddEmployee.ResumeLayout(false);
            this.panelAddEmployee.PerformLayout();
            this.panelUpdateEmployee.ResumeLayout(false);
            this.panelUpdateEmployee.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelAddEmployee;
        private CustomTextBox.CustomTextBoxView ctbEmployeePasswCreate;
        private CustomTextBox.CustomTextBoxView ctbEmployeeNameCreate;
        private System.Windows.Forms.Label lblAdminCreate;
        private System.Windows.Forms.ComboBox cbEmployeeTFCreate;
        private System.Windows.Forms.Button btnSaveEmployee;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDeleteEmployee;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button buttonEmployees;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label lblCloseEmployeePanel;
        private System.Windows.Forms.Panel panelUpdateEmployee;
        private System.Windows.Forms.Label lblCloseUpdatePanelUpdate;
        private CustomTextBox.CustomTextBoxView ctbEmployeeNameUpdate;
        private System.Windows.Forms.Label lblAdminUpdate;
        private System.Windows.Forms.ComboBox cbEmployeeTFUpdate;
        private System.Windows.Forms.Button btnSaveEmployeeUpdate;
    }
}