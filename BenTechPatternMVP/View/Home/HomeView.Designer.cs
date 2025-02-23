
namespace BenTechPatternMVP.View.Home
{
    partial class HomeView
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
            System.Windows.Forms.Panel panelShadow;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeView));
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.lblTitleChildForm = new System.Windows.Forms.Label();
            this.MenuSidePanel = new System.Windows.Forms.Panel();
            this.ibtnDataBase = new FontAwesome.Sharp.IconButton();
            this.ibtnEmployees = new FontAwesome.Sharp.IconButton();
            this.ibtnPricesCalculator = new FontAwesome.Sharp.IconButton();
            this.panelHome = new System.Windows.Forms.Panel();
            this.ibLogout = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            panelShadow = new System.Windows.Forms.Panel();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
            this.MenuSidePanel.SuspendLayout();
            this.panelHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelShadow
            // 
            panelShadow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(178)))), ((int)(((byte)(237)))));
            panelShadow.Dock = System.Windows.Forms.DockStyle.Top;
            panelShadow.Location = new System.Drawing.Point(220, 62);
            panelShadow.Name = "panelShadow";
            panelShadow.Size = new System.Drawing.Size(1184, 9);
            panelShadow.TabIndex = 7;
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(220, 71);
            this.panelDesktop.Margin = new System.Windows.Forms.Padding(0);
            this.panelDesktop.MinimumSize = new System.Drawing.Size(1184, 797);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(1184, 810);
            this.panelDesktop.TabIndex = 8;
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.White;
            this.panelTitleBar.Controls.Add(this.iconCurrentChildForm);
            this.panelTitleBar.Controls.Add(this.lblTitleChildForm);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(220, 0);
            this.panelTitleBar.Margin = new System.Windows.Forms.Padding(0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(1184, 62);
            this.panelTitleBar.TabIndex = 6;
            // 
            // iconCurrentChildForm
            // 
            this.iconCurrentChildForm.BackColor = System.Drawing.Color.White;
            this.iconCurrentChildForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(178)))), ((int)(((byte)(237)))));
            this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.House;
            this.iconCurrentChildForm.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(178)))), ((int)(((byte)(237)))));
            this.iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCurrentChildForm.Location = new System.Drawing.Point(18, 21);
            this.iconCurrentChildForm.Name = "iconCurrentChildForm";
            this.iconCurrentChildForm.Size = new System.Drawing.Size(32, 32);
            this.iconCurrentChildForm.TabIndex = 2;
            this.iconCurrentChildForm.TabStop = false;
            // 
            // lblTitleChildForm
            // 
            this.lblTitleChildForm.AutoSize = true;
            this.lblTitleChildForm.BackColor = System.Drawing.Color.White;
            this.lblTitleChildForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(100)))), ((int)(((byte)(131)))));
            this.lblTitleChildForm.Location = new System.Drawing.Point(56, 31);
            this.lblTitleChildForm.Name = "lblTitleChildForm";
            this.lblTitleChildForm.Size = new System.Drawing.Size(35, 13);
            this.lblTitleChildForm.TabIndex = 1;
            this.lblTitleChildForm.Text = "Home";
            // 
            // MenuSidePanel
            // 
            this.MenuSidePanel.BackColor = System.Drawing.Color.White;
            this.MenuSidePanel.Controls.Add(this.ibtnDataBase);
            this.MenuSidePanel.Controls.Add(this.ibtnEmployees);
            this.MenuSidePanel.Controls.Add(this.ibtnPricesCalculator);
            this.MenuSidePanel.Controls.Add(this.panelHome);
            this.MenuSidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuSidePanel.Location = new System.Drawing.Point(0, 0);
            this.MenuSidePanel.Name = "MenuSidePanel";
            this.MenuSidePanel.Size = new System.Drawing.Size(220, 881);
            this.MenuSidePanel.TabIndex = 5;
            // 
            // ibtnDataBase
            // 
            this.ibtnDataBase.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibtnDataBase.FlatAppearance.BorderSize = 0;
            this.ibtnDataBase.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.ibtnDataBase.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.ibtnDataBase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnDataBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.ibtnDataBase.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(100)))), ((int)(((byte)(131)))));
            this.ibtnDataBase.IconChar = FontAwesome.Sharp.IconChar.Database;
            this.ibtnDataBase.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(100)))), ((int)(((byte)(131)))));
            this.ibtnDataBase.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnDataBase.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnDataBase.Location = new System.Drawing.Point(0, 231);
            this.ibtnDataBase.Name = "ibtnDataBase";
            this.ibtnDataBase.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ibtnDataBase.Size = new System.Drawing.Size(220, 60);
            this.ibtnDataBase.TabIndex = 3;
            this.ibtnDataBase.Text = "DataBase";
            this.ibtnDataBase.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnDataBase.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnDataBase.UseVisualStyleBackColor = true;
            this.ibtnDataBase.Visible = false;
            this.ibtnDataBase.Click += new System.EventHandler(this.ibtnDataBase_Click);
            // 
            // ibtnEmployees
            // 
            this.ibtnEmployees.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibtnEmployees.FlatAppearance.BorderSize = 0;
            this.ibtnEmployees.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.ibtnEmployees.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.ibtnEmployees.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.ibtnEmployees.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(100)))), ((int)(((byte)(131)))));
            this.ibtnEmployees.IconChar = FontAwesome.Sharp.IconChar.User;
            this.ibtnEmployees.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(100)))), ((int)(((byte)(131)))));
            this.ibtnEmployees.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnEmployees.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnEmployees.Location = new System.Drawing.Point(0, 171);
            this.ibtnEmployees.Name = "ibtnEmployees";
            this.ibtnEmployees.Size = new System.Drawing.Size(220, 60);
            this.ibtnEmployees.TabIndex = 2;
            this.ibtnEmployees.Text = "Employees";
            this.ibtnEmployees.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnEmployees.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnEmployees.UseVisualStyleBackColor = true;
            this.ibtnEmployees.Visible = false;
            // 
            // ibtnPricesCalculator
            // 
            this.ibtnPricesCalculator.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibtnPricesCalculator.FlatAppearance.BorderSize = 0;
            this.ibtnPricesCalculator.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.ibtnPricesCalculator.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.ibtnPricesCalculator.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnPricesCalculator.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.ibtnPricesCalculator.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(100)))), ((int)(((byte)(131)))));
            this.ibtnPricesCalculator.IconChar = FontAwesome.Sharp.IconChar.Calculator;
            this.ibtnPricesCalculator.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(100)))), ((int)(((byte)(131)))));
            this.ibtnPricesCalculator.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnPricesCalculator.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnPricesCalculator.Location = new System.Drawing.Point(0, 111);
            this.ibtnPricesCalculator.Name = "ibtnPricesCalculator";
            this.ibtnPricesCalculator.Size = new System.Drawing.Size(220, 60);
            this.ibtnPricesCalculator.TabIndex = 1;
            this.ibtnPricesCalculator.Text = "Prices Calculator";
            this.ibtnPricesCalculator.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnPricesCalculator.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnPricesCalculator.UseVisualStyleBackColor = true;
            // 
            // panelHome
            // 
            this.panelHome.BackColor = System.Drawing.Color.White;
            this.panelHome.Controls.Add(this.ibLogout);
            this.panelHome.Controls.Add(this.label1);
            this.panelHome.Controls.Add(this.pictureBoxLogo);
            this.panelHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHome.Location = new System.Drawing.Point(0, 0);
            this.panelHome.Name = "panelHome";
            this.panelHome.Size = new System.Drawing.Size(220, 111);
            this.panelHome.TabIndex = 0;
            // 
            // ibLogout
            // 
            this.ibLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ibLogout.BackColor = System.Drawing.Color.White;
            this.ibLogout.Cursor = System.Windows.Forms.Cursors.Default;
            this.ibLogout.FlatAppearance.BorderSize = 0;
            this.ibLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibLogout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(100)))), ((int)(((byte)(131)))));
            this.ibLogout.IconChar = FontAwesome.Sharp.IconChar.RightFromBracket;
            this.ibLogout.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(178)))), ((int)(((byte)(237)))));
            this.ibLogout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibLogout.IconSize = 18;
            this.ibLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ibLogout.Location = new System.Drawing.Point(3, 0);
            this.ibLogout.Name = "ibLogout";
            this.ibLogout.Size = new System.Drawing.Size(66, 23);
            this.ibLogout.TabIndex = 5;
            this.ibLogout.Text = "Logout";
            this.ibLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.ibLogout.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(178)))), ((int)(((byte)(237)))));
            this.label1.Location = new System.Drawing.Point(109, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 30);
            this.label1.TabIndex = 4;
            this.label1.Text = "BenTech";
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.Image")));
            this.pictureBoxLogo.Location = new System.Drawing.Point(3, 21);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(100, 87);
            this.pictureBoxLogo.TabIndex = 3;
            this.pictureBoxLogo.TabStop = false;
            // 
            // HomeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1404, 881);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(panelShadow);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.MenuSidePanel);
            this.MinimumSize = new System.Drawing.Size(1420, 920);
            this.Name = "HomeView";
            this.Text = "HomeView";
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
            this.MenuSidePanel.ResumeLayout(false);
            this.panelHome.ResumeLayout(false);
            this.panelHome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.Panel panelTitleBar;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private System.Windows.Forms.Label lblTitleChildForm;
        private System.Windows.Forms.Panel MenuSidePanel;
        private FontAwesome.Sharp.IconButton ibtnDataBase;
        private FontAwesome.Sharp.IconButton ibtnEmployees;
        private FontAwesome.Sharp.IconButton ibtnPricesCalculator;
        private System.Windows.Forms.Panel panelHome;
        private FontAwesome.Sharp.IconButton ibLogout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
    }
}